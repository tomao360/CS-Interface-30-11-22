using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_TheInterface
{
    internal class Manager
    {
        private Manager() { }

        private readonly static Manager _instance = new Manager();
        public static Manager INSTANCE
        {
            get
            {
                return _instance;
            }
        }
        public IShape HighestVerticesNum(IShape shape1, IShape shape2)
        {
            if (shape1.VerticesNum() == shape2.VerticesNum())
            {
                return shape1;
            }
            else if (shape1.VerticesNum() < shape2.VerticesNum())
            {
                return shape1;
            }
            else
            {
                return shape2;
            }
        }
    }
}
