using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake
    {
        public List<pair> body;
        public bool alive;

        public snake()
        {
            body = new List<pair>();
            alive = true;
        }
  
        public snake(int x, int y)
        {
            pair t = new pair(x, y);
            body = new List<pair>();
            body.Add(t);
            alive = true;
        }       

        public void add(pair t)
        {
            body.Add(t);
        }
    }
}
