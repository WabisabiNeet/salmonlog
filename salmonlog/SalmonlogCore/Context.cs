using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace SalmonlogCore
{
    public class Context
    {
        #region public property
        public Mat Frame { get; set; }

        public DateTime FrameReadTime { get; set; }
        #endregion

        public Context()
        {

        }
    }
}
