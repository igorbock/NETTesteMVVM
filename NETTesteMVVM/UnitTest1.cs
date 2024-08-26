using System.ComponentModel;
using VisualBasicLib.Classes;

namespace NETTesteMVVM;

public class Tests
{
    private TypeConverter _converter;

    [SetUp]
    public void Setup()
    {
        _converter = new EntityTypeConverter();
    }

    [Test]
    public void Test1()
    {
        var standardValues = _converter.GetStandardValues(null);

        Assert.Pass();
    }
}