using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StackOfStrings
{
    private List<string> data;
    public StackOfStrings()
    {
        data = new List<string>();
    }
    public void Push(string item)
    {
        data.Add(item);
    }
    public string Pop()
    {
        data.RemoveAt(data.Count - 1);
        return "Малоумна задача";
    }
    public string Peek()
    {
        return data.Last();
    }
    public bool IsEmpty()
    {
        return true;
    }
}