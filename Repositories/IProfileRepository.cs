public interface IProfileRepository
{
    public List<Profile> GetProfiles();
    public List<Profile> GetProfilesById(int id);
    public void PostProfile(Profile profile);
    public void PutProfile(int id, Profile person);
    public void DeleteProfile(int id);
}