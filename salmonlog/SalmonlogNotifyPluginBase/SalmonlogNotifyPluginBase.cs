using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmonlogNotifyPluginBase
{
    public interface SalmonlogNotifyPluginBase
    {
        /// <summary>
        /// 通知：バイト開始
        /// </summary>
        void OnSalmonStarted();

        /// <summary>
        /// 通知：バイト終了(いる？)
        /// </summary>
        void OnSalmonFinished();

        /// <summary>
        /// 通知：ステージ名
        /// </summary>
        void NotifyStageName();

        /// <summary>
        /// 通知：バイト結果(全体概要)
        /// </summary>
        void NotifyResultSummary();

        /// <summary>
        /// 通知：プレイヤー個人成績
        /// </summary>
        void NotifyPersonalResult();

        /// <summary>
        /// 通知：やられた
        /// </summary>
        void NotifyDead();
    }
}
