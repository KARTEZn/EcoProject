using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Directory
/// </summary>
public class Directory:IDirectory
{
    public string Name { get; set; }
    public int HeaderCount { get; }
    public IDirectoryProvider Provider { get; set; }

    public Directory(string _Name, IDirectoryProvider _Provider)
    {
        this.Name = _Name;
        HeaderCount = 0;
        Provider = _Provider;
    }

    public void AddHeader(string value)
    {
        throw new NotImplementedException();
    }

    public void AddHeaderAfter(string value, string prev)
    {
        throw new NotImplementedException();
    }

    public void DropHeaders()
    {
        throw new NotImplementedException();
    }

    public void RemoveHeader(string value)
    {
        throw new NotImplementedException();
    }
}