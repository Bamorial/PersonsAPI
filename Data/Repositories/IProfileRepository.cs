public interface IProfileRepository
{
    public List<Company> GetProfiles();
    public List<Company> GetProfilesById(int id);
    public void PostProfile(Company profile);
    public void PutProfile(int id, Company person);
    public void DeleteProfile(int id);
}