namespace FXbox.Cloud.Shared
{
    public interface IEncryptor
    {
        string GetSalt(string value);
        string GetHash(string value, string salt);
    }
}
