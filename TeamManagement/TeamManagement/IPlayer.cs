using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement
{
    public interface IPlayer
    {
        int PlayerId {  get; }
        string Name { get; }
        int Age {  get; }
    }
}
