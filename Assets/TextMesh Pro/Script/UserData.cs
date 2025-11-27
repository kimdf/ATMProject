using Newtonsoft.Json;

public class UserData 
{
    public string userName;
    public int cash;
    public int bankcash;
   
    public UserData()
    {
        userName = string.Empty;
        bankcash = 0;
        cash = 0;
    }

    public UserData (string inputname, int inputcash, int inputBankcash)
    {
        userName=inputname;
        cash = inputcash;
        bankcash = inputBankcash;
    }

}
