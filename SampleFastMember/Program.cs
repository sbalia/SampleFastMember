using FastMember;

namespace SampleFastMember
{
    enum SomeEnum
    {
        Hi = 1,
        Bye = 2
    }
    
    class Simple
    {
        public SomeEnum? Value { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Simple();
            var accessor = TypeAccessor.Create(typeof(Simple));
            accessor[instance, "Value"] = 2;
        }
    }
}