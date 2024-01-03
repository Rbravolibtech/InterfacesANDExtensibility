using System;
namespace InterfacesANDExtensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

}