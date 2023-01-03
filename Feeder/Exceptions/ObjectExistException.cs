namespace Exceptions
{
    public sealed class ObjectExistException : Exception
    {
        public ObjectExistException(string objName) : base($"{objName} already exists")
        {

        }
    }
}