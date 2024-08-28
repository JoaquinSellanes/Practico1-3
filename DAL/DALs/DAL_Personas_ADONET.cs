using DAL.IDALs;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DAL.DALs
{
    public class DAL_Personas_ADONET : IDAL_Personas
    {

        public Persona AddPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public void DeletePersona(long id)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersona(long id)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public Persona UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }
        // private readonly string connectionString;

        // public DAL_Personas_ADONET()
        // {
        //     SqlConnectionStringBuilder con = new SqlConnectionStringBuilder
        //     {
        //         DataSource = "JOACOXPC\\SQLEXPRESSNET2",
        //         InitialCatalog = "practico1",
        //         IntegratedSecurity = true
        //     };

        //     connectionString = con.ConnectionString;
        // }

        // public void AddPersona(Persona persona)
        // {
        //     using (SqlConnection connection = new SqlConnection(connectionString))
        //     {
        //         connection.Open();
        //         string sql = "INSERT INTO Persona (Nombre, CI) VALUES (@Nombre, @CI)";

        //         using (SqlCommand command = new SqlCommand(sql, connection))
        //         {
        //             command.Parameters.AddWithValue("@Nombre", persona.Nombre);
        //             command.Parameters.AddWithValue("@CI", persona.Documento);
        //             command.ExecuteNonQuery();
        //         }
        //     }
        // }


        // public void DeletePersona(long id)
        // {
        //     using (SqlConnection connection = new SqlConnection(connectionString))
        //     {
        //         connection.Open();
        //         string sql = "DELETE FROM Persona WHERE Id = @Id";

        //         using (SqlCommand command = new SqlCommand(sql, connection))
        //         {
        //             command.Parameters.AddWithValue("@Id", id);
        //             command.ExecuteNonQuery();
        //         }
        //     }
        // }


        // public Persona GetPersona(long Documento)
        // {
            
        //     Persona persona = null;

        //     using (SqlConnection connection = new SqlConnection(connectionString))
        //     {
        //         connection.Open();
        //         string sql = "SELECT * FROM Persona WHERE Ci = @Ci";

        //         using (SqlCommand command = new SqlCommand(sql, connection))
        //         {
        //             command.Parameters.AddWithValue("@Ci", Documento);

        //             using (SqlDataReader reader = command.ExecuteReader())
        //             {
        //                 if (reader.Read())
        //                 {
        //                     persona = new Persona
        //                     {
        //                         Id = reader.GetInt32(0),
        //                         Nombre = reader.GetString(1),
        //                         Documento = reader.GetString(2)
        //                     };
        //                 }
        //             }
        //         }
        //     }

        //     return persona;
        // }


        // public List<Persona> GetPersonas()
        // {
        //     List<Persona> personas = new List<Persona>();

        //     using (SqlConnection connection = new SqlConnection(connectionString))
        //     {
        //         connection.Open();
        //         string sql = "SELECT Id, Nombre, CI FROM Persona";

        //         using (SqlCommand command = new SqlCommand(sql, connection))
        //         {
        //             using (SqlDataReader reader = command.ExecuteReader())
        //             {
        //                 while (reader.Read())
        //                 {
        //                     Persona persona = new Persona
        //                     {
        //                         Id = reader.GetInt32(0),
        //                         Nombre = reader.GetString(1),
        //                         Documento = reader.GetString(2)
        //                     };

        //                     personas.Add(persona);
        //                 }
        //             }
        //         }
        //     }

        //     return personas;
        // }


        // public void UpdatePersona(Persona persona)
        // {
        //     Console.WriteLine(persona);
        //     using (SqlConnection connection = new SqlConnection(connectionString))
        //     {
        //         connection.Open();
        //         string sql = "UPDATE Persona SET Nombre = @Nombre, CI = @CI WHERE Id = @Id";

        //         using (SqlCommand command = new SqlCommand(sql, connection))
        //         {
        //             command.Parameters.AddWithValue("@Id", persona.Id);
        //             command.Parameters.AddWithValue("@Nombre", persona.Nombre);
        //             command.Parameters.AddWithValue("@CI", persona.Documento);
        //             command.ExecuteNonQuery();
        //         }
        //     }
        // }

    }
}
