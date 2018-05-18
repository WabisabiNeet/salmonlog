using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonlogCore
{
    public abstract class Scene
    {
        protected Context ctx { get; set; }

        public Scene(Context c)
        {
            ctx = c;
        }

        /// <summary>
        /// 前回のマッチングから指定した時間以内にマッチングが実行されたかどうか
        /// </summary>
        /// <param name="duration_msec"></param>
        /// <returns></returns>
        protected bool MatchedIn(int duration_msec)
        {
            DateTime now = DateTime.Now;

            var elapsed = now - ctx.FrameReadTime;
            var elapsed_msec = elapsed.TotalMilliseconds;

            return elapsed_msec < duration_msec;
        }

        #region abstract method.
        public abstract bool Analyze();
        #endregion
    }
}
