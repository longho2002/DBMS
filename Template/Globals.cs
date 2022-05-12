using System.Runtime.CompilerServices;

namespace Template
{
    public static class Globals
    {
        public static string idUser { get; private  set; }
        public static string idUsertmp { get; private set; }
        public static string role { get; private set; }
        public static  string nameUser { get; private set; }
        public static string idBook_Infor { get; private set; }
        public static string idBook { get; private set; }
        public static  string idAuth { get; private set; }
        public static string idPublish { get; private set; }
        public static string idPos { get; private set; }


        //public static string setRole(string roleUser)
        //{
        //    role = 
        //}
        public static void SetidBook(string id)
        {
            idBook = id;
        }
        public static void setIDAuth(string id)
        {
            idAuth = id;
        }
        public static void setIDPublish(string id)
        {
            idPublish = id;
        }
        public static void setIDPos(string id)
        {
            idPos = id;
        }
        public static void setIDBook(string idB)
        {
            idBook_Infor = idB;
        }
        public static void setIDUser(string idU)
        {
            idUser = idU;
        }
        public static void setIDUsertmp(string idU)
        {
            idUsertmp = idU;
        }
        public static void SetUser(string id, string roleUser, string name)
        {
            idUser = id;
            role = roleUser;
            nameUser = name;
        }
    }
}