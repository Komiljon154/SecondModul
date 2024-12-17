using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using _2._2Dars.Models;

namespace ConsoleApp4.Services;

public class DirectorServices
{
    private string directorPath = "../../../Data/Director.json";

    public DirectorServices()
    {

    }

    public void SaveInform(List<Director> director)
    {
        var res = JsonSerializer.Serialize(director);
        File.WriteAllText(directorPath, res);
    }

    public List<Director> GetDirectorInformations() 
    { 
        var inform = File.ReadAllText(directorPath);
        var res = JsonSerializer.Deserialize<List<Director>>(inform);
        return res;
    }

    public bool ChekDirektorPasswords(string login, string password)
    {
        var resInFile = File.ReadAllText(directorPath);
        var res = JsonSerializer.Deserialize<List<Director>>(resInFile);
        if(login == res[0].Username && password == res[0].Password)
        {
            return true;
        }
        return false;
    }
    public void ChangeLogin(string login, string parol)
    {
        var resInFile = File.ReadAllText(directorPath);
        var res = JsonSerializer.Deserialize<List<Director>>(resInFile) ;

        res[0].Username = login;
        res[0].Password = parol;
        SaveInform(res);

    }

}
