using System.Runtime.CompilerServices;

namespace Template
{
    public static class Globals
    {
        public static string idUser { get; private  set; }
        public static string role { get; private set; }
        public static  string nameUser { get; private set; }
        public static  string idBook_Infor { get; private set; }

        //public static string setRole(string roleUser)
        //{
        //    role = 
        //}
        public static void setIDBook(string idB)
        {
            idBook_Infor = idB;
        }
        public static void setIDUser(string idU)
        {
            idUser = idU;
        }
        public static void SetUser(string id, string roleUser, string name)
        {
            idUser = id;
            role = roleUser;
            nameUser = name;
        }
    }
}