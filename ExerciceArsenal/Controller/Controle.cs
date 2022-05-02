using ExerciceArsenal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArsenal.Controller
{
    class Controle
    {
        string connectionString = "server=localhost;user id=root;database=arsenal";

        public List<LotDate> Winnings { get; private set; }

        public Controle()
        {
            Winnings = new List<LotDate>();
        }

        public List<LotDate> searchWinnings(DateTime date)
        {
            List<LotDate> winnings = new List<LotDate>();
            DBConnection connection = DBConnection.GetInstance(connectionString);
            String query = "SELECT * FROM lots_Date WHERE winningDate = @winningDate";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@winningDate", date.Date);
            connection.ReqSelect(query, parameters);

            while (connection.Read())
            {
                winnings.Add(
                    new LotDate((int)connection.Field("idLotDate"),
                    (int)connection.Field("idLot"),
                    (DateTime)connection.Field("winningDate"),
                    (TimeSpan)connection.Field("winningTime"))
                    );
            }

            Winnings.Clear();
            Winnings.AddRange(winnings);
            connection.Close();

            return winnings;
        }

        public Lot searchLot(int idLot)
        {
            DBConnection connection = DBConnection.GetInstance(connectionString);
            String query = "SELECT * FROM lot WHERE id = @id";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", idLot);
            connection.ReqSelect(query, parameters);

            if (connection.Read())
            {
                var lot = new Lot((int)connection.Field("id"), (int)connection.Field("quantity"));
                connection.Close();
                return lot;
            }
            connection.Close();
            return null;
        }

        public WinningHistory searchWinningHistory(DateTime date)
        {
            DBConnection connection = DBConnection.GetInstance(connectionString);
            String query = "SELECT * FROM winnings_history WHERE date = @date";
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@date", date);
            connection.ReqSelect(query, parameters);

            if (connection.Read())
            {
                var winningHistory = new WinningHistory((DateTime)connection.Field("date"), (int)connection.Field("players"), (int)connection.Field("lotsWon"));
                connection.Close();
                return winningHistory;
            }
            connection.Close();
            return null;
        }

    }
}
