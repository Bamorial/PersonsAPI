
using MySql.Data.MySqlClient;

public class ProfileRepository : IProfileRepository
{
    private readonly string _connectionString;

    public ProfileRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public List<Profile> GetProfiles()
    {
        return null;
    }
    public List<Profile> GetProfilesById(int id)
    {
        return null;
    }
    public void PostProfile(Profile profile){}
    public void PutProfile(int id, Profile person){}
    public void DeleteProfile(int id){}
    // public List<Person> GetPersons()
    // {
    //     string query = @"
    //     SELECT
    //         p.Id AS PersonId,
    //         p.Email,
    //         pr.Name,
    //         pr.Age,
    //         pr.Company
    //     FROM Person p
    //     INNER JOIN Profile pr ON pr.Id = p.ProfileId;
    // ";
    //     List<Person> persons = new List<Person>();

    //     using (MySqlConnection conn = new MySqlConnection(_connectionString))
    //     using (MySqlCommand cmd = new MySqlCommand(query, conn))
    //     {
    //         conn.Open();
    //         using (MySqlDataReader reader = cmd.ExecuteReader())
    //         {
    //             while (reader.Read())
    //             {
    //                 var person = new Person
    //                 {
    //                     Id = Convert.ToInt32(reader["PersonId"]),
    //                     Email = reader["Email"].ToString(),
    //                     Profile = new Profile
    //                     {
    //                         Name = reader["Name"].ToString(),
    //                         Age = Convert.ToInt32(reader["Age"]),
    //                         Company = reader["Company"].ToString()
    //                     }
    //                 };
    //                 persons.Add(person);
    //             }
    //         }
    //     }

    //     return persons;
    // }
    // public List<Person> GetPersonById(int id)
    // {
    //     string query = @"
    //     SELECT
    //         p.Id AS PersonId,
    //         p.Email,
    //         pr.Name,
    //         pr.Age,
    //         pr.Company
    //     FROM Person p
    //     INNER JOIN Profile pr ON pr.Id = p.ProfileId
    //     WHERE p.Id=@Id;
    // ";
    //     List<Person> persons = new List<Person>();

    //     using (MySqlConnection conn = new MySqlConnection(_connectionString))
    //     using (MySqlCommand cmd = new MySqlCommand(query, conn))
    //     {
    //         conn.Open();
    //         cmd.Parameters.AddWithValue("@Id", id);
    //         using (MySqlDataReader reader = cmd.ExecuteReader())
    //         {
    //             while (reader.Read())
    //             {
    //                 var person = new Person
    //                 {
    //                     Id = Convert.ToInt32(reader["PersonId"]),
    //                     Email = reader["Email"].ToString(),
    //                     Profile = new Profile
    //                     {
    //                         Name = reader["Name"].ToString(),
    //                         Age = Convert.ToInt32(reader["Age"]),
    //                         Company = reader["Company"].ToString()
    //                     }
    //                 };
    //                 persons.Add(person);
    //             }
    //         }
    //     }

    //     return persons;
    // }
    // public void PostPerson(Person person)
    // {
    //     string insertProfileQuery = @"
    //     INSERT INTO Profile (Name, Age, Company)
    //     VALUES (@Name, @Age, @Company);
    //     SELECT LAST_INSERT_ID();";

    //     string insertPersonQuery = @"
    //     INSERT INTO Person (Email, ProfileId)
    //     VALUES (@Email, @ProfileId);";

    //     using (MySqlConnection conn = new MySqlConnection(_connectionString))
    //     using (MySqlCommand cmdProfile = new MySqlCommand(insertProfileQuery, conn))
    //     {
    //         conn.Open();

    //         cmdProfile.Parameters.AddWithValue("@Name", person.Profile.Name);
    //         cmdProfile.Parameters.AddWithValue("@Age", person.Profile.Age);
    //         cmdProfile.Parameters.AddWithValue("@Company", person.Profile.Company);

    //         int profileId;
    //         using (var reader = cmdProfile.ExecuteReader())
    //         {
    //             reader.Read();
    //             profileId = Convert.ToInt32(reader[0]);
    //             Console.WriteLine(profileId);
    //         }

    //         using (MySqlCommand cmdPerson = new MySqlCommand(insertPersonQuery, conn))
    //         {
    //             cmdPerson.Parameters.AddWithValue("@Email", person.Email);
    //             cmdPerson.Parameters.AddWithValue("@ProfileId", profileId);
    //             cmdPerson.ExecuteNonQuery();
    //         }
    //     }
    // }
    // public void PutPerson(int id, Person updatedPerson)
    // {
    //     string updateProfileQuery = @"
    //     UPDATE Profile pr
    //     JOIN Person p ON pr.Id = p.ProfileId
    //     SET pr.Name = @Name,
    //         pr.Age = @Age,
    //         pr.Company = @Company
    //     WHERE p.Id = @PersonId;";

    //     string updatePersonQuery = @"
    //     UPDATE Person
    //     SET Email = @Email
    //     WHERE Id = @PersonId;";

    //     using (MySqlConnection conn = new MySqlConnection(_connectionString))
    //     {
    //         conn.Open();

    //         using (MySqlCommand cmdProfile = new MySqlCommand(updateProfileQuery, conn))
    //         {
    //             cmdProfile.Parameters.AddWithValue("@Name", updatedPerson.Profile.Name);
    //             cmdProfile.Parameters.AddWithValue("@Age", updatedPerson.Profile.Age);
    //             cmdProfile.Parameters.AddWithValue("@Company", updatedPerson.Profile.Company);
    //             cmdProfile.Parameters.AddWithValue("@PersonId", id);
    //             cmdProfile.ExecuteNonQuery();
    //         }

    //         using (MySqlCommand cmdPerson = new MySqlCommand(updatePersonQuery, conn))
    //         {
    //             cmdPerson.Parameters.AddWithValue("@Email", updatedPerson.Email);
    //             cmdPerson.Parameters.AddWithValue("@PersonId", id);
    //             cmdPerson.ExecuteNonQuery();
    //         }
    //     }
    // }
    // public void DeletePerson(int id)
    // {
    //     int profileId = 0;

    //     using (MySqlConnection conn = new MySqlConnection(_connectionString))
    //     {
    //         conn.Open();

    //         // 1. Obține ProfileId
    //         using (MySqlCommand getProfileIdCmd = new MySqlCommand("SELECT ProfileId FROM Person WHERE Id = @Id", conn))
    //         {
    //             getProfileIdCmd.Parameters.AddWithValue("@Id", id);
    //             using (var reader = getProfileIdCmd.ExecuteReader())
    //             {
    //                 if (reader.Read())
    //                     profileId = Convert.ToInt32(reader["ProfileId"]);
    //             }
    //         }

    //         // 2. Șterge persoana
    //         using (MySqlCommand deletePersonCmd = new MySqlCommand("DELETE FROM Person WHERE Id = @Id", conn))
    //         {
    //             deletePersonCmd.Parameters.AddWithValue("@Id", id);
    //             deletePersonCmd.ExecuteNonQuery();
    //         }

    //         // 3. Șterge profilul (dacă nu e partajat de altă persoană)
    //         using (MySqlCommand deleteProfileCmd = new MySqlCommand("DELETE FROM Profile WHERE Id = @Id", conn))
    //         {
    //             deleteProfileCmd.Parameters.AddWithValue("@Id", profileId);
    //             deleteProfileCmd.ExecuteNonQuery();
    //         }
    //     }
    // }


}
