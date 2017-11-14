using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;  // DataTable,DataRow
using System.Data.SQLite;   // System.Data.SQLite.DLL
using System.IO;    // Path


namespace sqlite
{
    /// <summary>
    /// 使用方法：
    /// using System.Data;
    /// using sqlite;
    /// Sqlite ms = new Sqlite("test.sqlite");
    /// string sql = "select * from `posts` where `id`=@id";
    /// Dictionary<string, object> param = new Dictionary<string, object>();
    /// param.Add("@id", 1);
    /// DataRow[] rows = ms.getRows(sql, param);
    /// </summary>
    public class Sqlite
    {
        private string _dbpath;
        //public string _dbpath;
        private SQLiteConnection _conn;

        /// <summary>
        /// SQLite连接
        /// </summary>
        private SQLiteConnection conn
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new SQLiteConnection(string.Format("Data Source={0};Version=3;",this._dbpath));
                    _conn.Open();
                }
                return _conn;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbpath">sqlite数据库文件路径，要求绝对路径</param>
        public Sqlite(string dbpath)
        {
            /*if (Path.IsPathRooted(dbpath))
            {
                this._dbpath = dbpath;
            }
            else
            {
                this._dbpath = string.Format("{0}/{1}", AppDomain.CurrentDomain.SetupInformation.ApplicationBase, dbpath);
            }*/
            this._dbpath = dbpath;
        }

        /// <summary>
        /// 获取多行
        /// </summary>
        /// <param name="sql">执行sql</param>
        /// <param name="param">sql参数</param>
        /// <returns>多行结果</returns>
        public DataRow[] getRows(string sql, Dictionary<string, object> param = null)
        {
            List<SQLiteParameter> sqlite_param = new List<SQLiteParameter>();

            if (param != null)
            {
                foreach (KeyValuePair<string, object> row in param)
                {
                    sqlite_param.Add(new SQLiteParameter(row.Key, row.Value.ToString()));
                }
            }

            DataTable dt = this.ExecuteDataTable(sql, sqlite_param.ToArray());
            return dt.Select();
        }

        /// <summary>
        /// 获取单行
        /// </summary>
        /// <param name="sql">执行sql</param>
        /// <param name="param">sql参数</param>
        /// <returns>单行数据</returns>
        public DataRow getRow(string sql, Dictionary<string, object> param = null)
        {
            DataRow[] rows = this.getRows(sql, param);
            return rows[0];
        }

        /// <summary>
        /// 获取字段1
        /// </summary>
        /// <param name="sql">执行sql</param>
        /// <param name="param">sql参数</param>
        /// <returns>字段数据</returns>
        public Object getOne(string sql, Dictionary<string, object> param = null)
        {
            DataRow row = this.getRow(sql, param);
            return row[0];
        }

        /// <summary>
        /// SQLite增删改
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="parameters">所需参数</param>
        /// <returns>所受影响的行数</returns>
        public int query(string sql, Dictionary<string, object> param = null)
        {
            List<SQLiteParameter> sqlite_param = new List<SQLiteParameter>();

            if (param != null)
            {
                foreach (KeyValuePair<string, object> row in param)
                {
                    sqlite_param.Add(new SQLiteParameter(row.Key, row.Value.ToString()));
                }
            }

            return this.ExecuteNonQuery(sql, sqlite_param.ToArray());
        }

        /// <summary>
        /// SQLite增删改
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="parameters">所需参数</param>
        /// <returns>所受影响的行数</returns>
        private int ExecuteNonQuery(string sql, SQLiteParameter[] parameters)
        {
            int affectedRows = 0;

            System.Data.Common.DbTransaction transaction = conn.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = sql;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            /* try
             {
                 affectedRows = command.ExecuteNonQuery();
             }
             catch(System.Data.SQLite.SQLiteException e)
             {
                 //throw(e.Message);
             }*/
            affectedRows = command.ExecuteNonQuery();
            transaction.Commit();

            return affectedRows;
        }

        /// <summary>
        /// SQLite查询
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="parameters">所需参数</param>
        /// <returns>结果DataTable</returns>
        private DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters)
        {
            DataTable data = new DataTable();

            SQLiteCommand command = new SQLiteCommand(sql, conn);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);

            return data;
        }

        /// <summary>
        /// 查询数据库表信息
        /// </summary>
        /// <returns>数据库表信息DataTable</returns>
        public DataTable GetSchema()
        {
            DataTable data = new DataTable();

            data = conn.GetSchema("TABLES");

            return data;
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        public void CreatDB()
        {
            //string path = @"C:\Users\Luca\Documents\test.sqlite";
            SQLiteConnection cn = new SQLiteConnection(string.Format("Data Source={0};Version=3;", this._dbpath));
            cn.Open();
            cn.Close();
        }

        /// <summary>
        /// 创建表结构
        /// </summary>
        public void CreatTable()
        {
            string strsql = string.Format("CREATE TABLE test(username varchar(20),password varchar(20))");
            ExecuteNonQuery(strsql, null);
        }
    }
}
