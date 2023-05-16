using MySql.Data.MySqlClient;

namespace KutuphaneProjesi
{
    internal class MySqlAdapter
    {
        private MySqlCommand komut;

        public MySqlAdapter(MySqlCommand komut)
        {
            this.komut = komut;
        }
    }
}