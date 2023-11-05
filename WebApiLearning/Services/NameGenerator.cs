namespace WebApiLearning.Services;

public static class NameGenerator
{
    public static string GetName()
    {
        List<string> names = new() { "Adam", "John", "David", "Peter" };

        //Slower than a standard random function, but a fun example of using SQL guid tricks to generate random value
        return names.OrderBy(x => Guid.NewGuid()).First();
    }
}
