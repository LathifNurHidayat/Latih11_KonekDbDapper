using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih11_KonekDbDapper
{
    public class NilaiDal
    {
        private const string _connString = "Server = localhost; Database = LatihanDb ; Trusted_Connection = True ; TrustServerCertificate = True";


        public IEnumerable<NilaiModel> ListNilai()
        {
            const string sql = @"
              SELECT 
                MS.Nama, MK.MataKuliahName, N.Nilai
              FROM 
                Nilai N
                INNER JOIN MataKuliah MK ON N.MataKuliahId = MK.MataKuliahId 
                INNER JOIN Mahasiswa MS ON N.MahasiswaId = MS.MahasiswaId";

            using var conn = new SqlConnection(_connString);
            var listNilai = conn.Query<NilaiModel>(sql);
            return listNilai;
        }
    }
}
