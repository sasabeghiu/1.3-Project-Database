using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        //returning a list of rooms
        public List<Room> GetAllRooms()
        {
            string query = "SELECT RoomNr, Room_Type, Room_Size FROM [Room]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (int)dr["RoomNr"],
                    Type = (string)(dr["Room_Type"]),
                    Capacity = (int)(dr["Room_Size"])
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
