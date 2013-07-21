using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace 手速测试
{
    public enum CalcMethod{
        ByTime,
        ByHits
    };
    public class HitCalc
    {
        protected bool ready;
        protected bool singlekey;
        public bool SingleKey
        {
            set { singlekey = value; }
            get { return singlekey; }
        }

        protected int hits;
        public int Hits
        {
            get { return hits; }
        }
        protected long starttime;
        public long LeftTime
        {
            get { if (started) { return targettime-(DateTime.Now.Ticks - starttime); } else return 0; }
        }
        protected long endtime;
        protected Timer timer;
        protected bool started;
        public bool IsRunning
        {
            get { return started; }
        }
        protected CalcMethod method;
        public CalcMethod Method
        {
            get { return method; }
            set { method = value; }
        }
        protected int targethits;
        public int TargetHits
        {
            get { return targethits; }
            set { targethits = value; }
        }
        protected long targettime;
        public long TargetTime
        {
            get { return targettime; }
            set { targettime = value; }
        }
        public event EventHandler Updated;
        public double BPM
        {
            get
            {
                if (started)
                {
                    return hits/((DateTime.Now.Ticks-starttime)/10000000.0)*60/(singlekey?2:4);
                }
                else
                {
                    return hits / ((endtime - starttime) / 10000000.0) * 60 / (singlekey ? 2 : 4);
                }
            }
        }
        public HitCalc():this(CalcMethod.ByTime)
        {
        }
        public HitCalc(CalcMethod m)
        {
            method = m;
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            Stop();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Updated!=null) Updated(null,null);
            if (method == CalcMethod.ByTime)
            {
                if (DateTime.Now.Ticks - starttime >= targettime) Stop();
            }
            else
            {
                if (targethits <= hits) Stop();
            }
            
        }
        protected bool k1, k2, m1, m2;//是否按下
        public void K1Down()
        {
            if (ready && !started) { Start(); }
            if (started)
            {
                if (!m1 && !k1) hits++;
                k1 = true;
            }
        }
        public void K1Up()
        {
            k1 = false;
        }
        public void K2Down()
        {
            if (ready && !started) Start();
            if (started)
            {
                if (!m2 && !k2) hits++;
                k2 = true;
            }
        }
        public void K2Up()
        {
            k2 = false;
        }

        public void M1Down()
        {
            if (ready && !started) Start();
            if (started)
            {
                if (!m1 && !k1) hits++;
                m1 = true;
            }
        }
        public void M1Up()
        {
            m1 = false;
        }
        public void M2Down()
        {
            if (ready && !started) Start();
            if (started)
            {
                if (!m2 && !k2) hits++;
                m2 = true;
            }
        }
        public void M2Up()
        {
            m2 = false;
        }
        public void Start()
        {
            starttime = DateTime.Now.Ticks;
            hits = 0;

            timer.Start();
            started = true;
            k1 = k2 = m1 = m2 = false;
            ready = false;
        }
        public void Stop()
        {
            timer.Interval = 10;
            timer.Stop();
            timer.Enabled = false;
            endtime = DateTime.Now.Ticks;
            started = false;
        }
        public void Reset()
        {
            ready = true;
        }
    }
}
