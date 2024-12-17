using _2._2Dars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace _2._2_dars.Services;


public class TestService
{
    private string testFilePath;
    private List<Test> test;
    public TestService ()
    {
        testFilePath = "../../../Data/Test.json";
        if(File.Exists (testFilePath))
        {
            File.WriteAllText(testFilePath, "[]");
        }
        test = new List<Test> ();
        test=GetAllTests ();
    }
    public Test AddTest (Test test)
    {
        test.Id= Guid.NewGuid ();
        this.test.Add (test);
        SaveData ();
        return test;
    }
    public Test GetById(Guid testId)
    {
        foreach(var test in test)
        {
            if(test.Id == testId)
                return test;
        }
        return null;
    }
    public bool DeletedTest(Guid testId)
    {
        var test = GetById (testId);
        if(test is null)
        {
           return false;
        }
        this.test.Remove (test);
        SaveData ();
        return true;
    }
    public bool UpdatedTest(Test updatedTest)
    {
        var test= GetById (updatedTest.Id);
        if(test is null)
        {
            return false;
        }
        var index = this.test.IndexOf (test);
        this.test[index] = updatedTest;
        SaveData ();
        return true;
    }
    public List<Test> GetAllTests()
    {
        return GetTests();
    }
    public List<Test> RandomTests(int count)
    {
        if(count>=test.Count)
        {
            return test;
        }
        var randomTests=new List<Test> ();
        var rand=new Random();
        for(var i=0;i<count;)
        {
            var option=rand.Next(0, test.Count);
            if (randomTests.Contains(test[option]) is false)
            {
                randomTests.Add(test[option]);
                i++;
            }
        }
        return randomTests;
    }
    public void SaveData()
    {
        var testJson = JsonSerializer.Serialize(test);
        File.WriteAllText (testFilePath, testJson);
    }
    public List<Test> GetTests()
    {
        var testJson=File.ReadAllText(testFilePath);
        var tests=JsonSerializer.Deserialize<List<Test>>(testJson);
        return tests;
    }

    internal IEnumerable<object> GetRandomTests(int amount)
    {
        throw new NotImplementedException();
    }
}