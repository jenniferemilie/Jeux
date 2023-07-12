using Jeux.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jeux.Repository
{
    public class JeuRepo 
    {
        private string _cnstr;
        public JeuRepo(string cnstr)
        {
            _cnstr = cnstr;
        }
        
        public int Add (Jeu obj)
        {
            int id;
            try
            {
                using(SqlConnection conn = new SqlConnection(_cnstr))
                {

                }
            }
        }
    }
    
    
}
