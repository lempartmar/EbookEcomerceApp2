﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace EbookApp.Infrastructure
{
    internal class SessionManager : ISessionManager
    {

        private HttpSessionState session;

        public SessionManager()
        {
            session = HttpContext.Current.Session;
        }
       
        public T Get<T>(string key)
        {
            return (T)session[key];
        }

        public void Set<T>(string name, T value)
        {
            session[name] = value;
        }

        public void Abandon()
        {
            session.Abandon();
        }

        public T TryGet<T>(string key)
        {
            try
            {
                return (T)session[key];

            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
}
