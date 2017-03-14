using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public interface ITimeCode
    {
        long Miliseconds { get; }
        double Fps { get; }
        byte Hour { get; }
        byte Minute { get; }
        byte Second { get; }
        byte Frame { get; }       
    }
    public class TimeCode : ITimeCode
    {
        protected int? _Numerator = 25000;
        protected int? _Demoniator = 1000;
        public int Numerator
        {
            get
            {
                if (_Numerator == 0 || _Numerator == null)
                    return 25;
                else
                    return (int)_Numerator;
            }               
        }
        public int Demoniater
        {
            get
            {
                if (_Demoniator == 0 || _Demoniator == null)
                    return 1;
                else return (int)_Demoniator;
            }
        }
        private byte _h = 0;
        public double Fps
        {
            get
            {
                if (_Demoniator != 0 && _Demoniator!=null && _Numerator!=null)
                    return (int)Math.Round((float)((int)_Numerator / (int)_Demoniator));
                else return 0;
            }
           
        }
        public byte Hour
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }
        private byte _m;

        public byte Minute
        {
            get { return _m; }
            set { _m = value; }
        }
        private byte _s;

        public byte Second
        {
            get { return _s; }
            set { _s = value; }
        }
        private byte _f;

        public byte Frame
        {
            get { return _f; }
            set { _f = value; }
        }
        private long _Miliseconds = 0;

        public long Miliseconds
        {
            get { return _Miliseconds; }
        }
        public long TotalFrame
        {
            get
            {
                return (long)( _h * 3600 * Fps + _m * Fps + _s * Fps + _f);

            }
        }
        /// <summary>
        /// Contrustor Timecode with frame rate = 25 frame/s
        /// </summary>
        public TimeCode()
        {
            _Numerator = 25;
            _Demoniator = 1;
        }
        public TimeCode(FrameRate frmRate)
        {
            GetFrameRateFromFrameRate(frmRate);
        }
        public TimeCode(TimeCode tc)
        {
            _h = tc._h;
            _m = tc._m;
            _s = tc._s;
            _f = tc._f;
            _Numerator = tc._Numerator;
            _Demoniator = tc._Demoniator;
            _Miliseconds = tc._Miliseconds;
        }
        public TimeCode(int? numorator, int? demoniator)
        {
            _Demoniator = demoniator;
            _Numerator = numorator;
        }
        /// <summary>
        /// Construtor with Framerate = 25 frame/s
        /// </summary>
        /// <param name="milisecond"></param>
        public TimeCode(long miliseconds)
        {
            _Miliseconds = miliseconds;
            _Demoniator = 1;
            _Numerator = 25;
            RecaculatorTimecode();
        }
        /// <summary>
        /// Contrustor Timecode from miliseconds
        /// </summary>
        /// <param name="miliseconds"></param>
        /// <param name="frmRate"></param>
        public TimeCode(long miliseconds, FrameRate frmRate)
        {
            _Miliseconds = miliseconds;
            GetFrameRateFromFrameRate(frmRate);
            RecaculatorTimecode();
        }
        public TimeCode(long miliseconds, int? numorator, int? demoniator)
        {
            _Miliseconds = miliseconds;
            _Numerator = numorator;
            _Demoniator = demoniator;
            RecaculatorTimecode();
        }
        /// <summary>
        /// Construtor with Framerate = 25 frame/s
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        /// <param name="frame"></param>
        public TimeCode(byte hour, byte minute, byte second, byte frame)
        {
            _h = hour;
            _m = minute;
            _s = second;
            _f = frame;
            _Numerator = 25;
            _Demoniator = 1;
            _Miliseconds = hour * 3600000 + minute * 60000 + second * 1000 + (frame * 1000 * Demoniater) / Numerator;
        }
        public TimeCode(byte hour, byte minute, byte second, byte frame, FrameRate frmRate)
        {
            _h = hour;
            _m = minute;
            _s = second;
            _f = frame;
            GetFrameRateFromFrameRate(frmRate);
            _Miliseconds = hour * 3600000 + minute * 60000 + second * 1000 + (frame * 1000 * Demoniater) / Numerator;

        }
        public TimeCode(byte hour, byte minute, byte second, byte frame, int? numorator, int? demoniator)
        {
            _h = hour;
            _m = minute;
            _s = second;
            _f = frame;
            _Numerator = numorator;
            _Demoniator = demoniator;
            _Miliseconds = hour * 3600000 + minute * 60000 + second * 1000 + (frame * 1000 * Demoniater) / Numerator;
        }
        private void RecaculatorTimecode()
        {
            
            var totalSecond = (int)Miliseconds / 1000;
            var totalMinute = (int)totalSecond / 60;
            var totalHour = (int)totalMinute / 60;
            Frame = (byte)Math.Round((float)((Miliseconds - (long)totalSecond * 1000) * Numerator) /(Demoniater * 1000),MidpointRounding.AwayFromZero) ;
            Second = (byte)(totalSecond - totalMinute * 60);
            Minute = (byte)(totalMinute - totalHour * 60);
            Hour = (byte)totalHour;
        }
        public void FromFrame(long frame)
        {
            byte myhour, myminute, mysecond, myframe;
            myhour = (byte)(frame / (3600 * Fps));
            myminute = (byte)((frame - myhour * 3600 * Fps) / (60 * Fps));
            mysecond = (byte)((frame - myhour * 3600 * Fps - myminute * 60 * Fps) / Fps);
            myframe = (byte)((frame - myhour * 3600 * Fps - myminute * 60 * Fps - mysecond * Fps));
            _h = myhour;
            _m = myminute;
            _s = mysecond;
            _f = myframe;
            _Miliseconds = Hour * 3600000 + Minute * 60000 + Second * 1000 + (frame * 1000 * Demoniater) / Numerator;
        }
        /// <summary>
        /// Return false if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc1"></param>
        /// <param name="tc2"></param>
        /// <returns></returns>
        public static bool operator ==(TimeCode tc1, TimeCode tc2)
        {
            if (tc1._Numerator == tc2._Numerator && tc1._Demoniator == tc2._Demoniator)
            {
                if (tc1.Hour == tc2.Hour && tc1.Minute == tc2.Minute && tc1.Second == tc2.Second && tc1.Frame == tc2.Frame)
                    return (true);
                else
                    return (false);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Return true if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc1"></param>
        /// <param name="tc2"></param>
        /// <returns></returns>
        public static bool operator !=(TimeCode tc1, TimeCode tc2)
        {
            return !(tc1 == tc2);
        }
        public static TimeCode operator -(TimeCode tc2, TimeCode tc1)
        {
            var tc = new TimeCode(tc2.Numerator, tc2.Demoniater);
            if (tc1._Numerator == tc2._Numerator && tc1._Demoniator == tc2._Demoniator)
            {
              //  tc = new TimeCode(tc1._Numerator, tc1._Demoniator);
                long subTc;
                if (tc2.TotalFrame > tc1.TotalFrame)
                    subTc = tc2.TotalFrame - tc1.TotalFrame;
                else
                    subTc = 0;
                tc.FromFrame(subTc);
            }
            else
            {
                long subTc;
                if (tc2.Miliseconds > tc1.Miliseconds)
                {
                    subTc = tc2.Miliseconds - tc1.Miliseconds;
                }
                else
                    subTc = 0;
                tc = new TimeCode(subTc, tc2.Numerator, tc2.Demoniater);
            }
            return tc;
        }

        public static TimeCode operator +(TimeCode tc1, TimeCode tc2)
        {
            var tc = new TimeCode(tc2.Numerator, tc2.Demoniater);
            if (tc1.Numerator == tc2.Numerator && tc1.Demoniater == tc2.Demoniater)
            {
                //  tc = new TimeCode(tc1._Numerator, tc1._Demoniator);
                
                tc.FromFrame(tc2.TotalFrame + tc1.TotalFrame);
            }
            else
            {                   
                tc = new TimeCode(tc1.Miliseconds + tc2.Miliseconds, tc2.Numerator, tc2.Demoniater);
            }
            return tc;

            //return new TimeCode((byte)(tc1.hour+tc2.h), 0, 0, 0);
        }
        /// <summary>
        /// Return false if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc1"></param>
        /// <param name="tc2"></param>
        /// <returns></returns>
        public static bool operator >=(TimeCode tc1, TimeCode tc2)
        {
            if (tc1.Numerator == tc2.Numerator && tc1.Demoniater == tc2.Demoniater)
            {
                return (tc1.TotalFrame >= tc2.TotalFrame);
            }
            else
                return false;
        }
        /// <summary>
        /// Return false if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc1"></param>
        /// <param name="tc2"></param>
        /// <returns></returns>
        public static bool operator <=(TimeCode tc1, TimeCode tc2)
        {
            if (tc1.Numerator == tc2.Numerator && tc1.Demoniater == tc2.Demoniater)
            {
                return (tc1.TotalFrame <= tc2.TotalFrame);
            }
            else
                return false;
        }
        /// <summary>
        /// Return false if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc1"></param>
        /// <param name="tc2"></param>
        /// <returns></returns>
        public static bool operator >(TimeCode tc1, TimeCode tc2)
        {
            if (tc1.Numerator == tc2.Numerator && tc1.Demoniater == tc2.Demoniater)
            {
                return (tc1.TotalFrame > tc2.TotalFrame);
            }
            else
                return false;
        }
        /// <summary>
        /// Return false if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc1"></param>
        /// <param name="tc2"></param>
        /// <returns></returns>
        public static bool operator <(TimeCode tc1, TimeCode tc2)
        {
            if (tc1.Numerator == tc2.Numerator && tc1.Demoniater == tc2.Demoniater)
            {
                return (tc1.TotalFrame < tc2.TotalFrame);
            }
            else
                return false;
        }
        /// <summary>
        /// Return false if not have same Numerator and Demoniator
        /// </summary>
        /// <param name="tc"></param>
        /// <returns></returns>
        public override bool Equals(object tc)
        {
            
            return this == (TimeCode)tc;
        }
        private void GetFrameRateFromFrameRate(FrameRate frmRate)
        {
            switch (frmRate)
            {
                case Station.FrameRate.NTC:
                    _Numerator = 24000;
                    _Demoniator = 1000;
                    break;
                case Station.FrameRate.PAL:
                    _Numerator = 25000;
                    _Demoniator = 1000;
                    break;
                case Station.FrameRate.NTSC:
                    _Numerator = 30000;
                    _Demoniator = 1001;
                    break;
            }
        }
        public string ToHDString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}.{3:00}", _h, _m, _s, _f);
        }
        public string ToClockString()
        {
            return string.Format("{0:00}:{1:00}:{2:00}", _h, _m, _s);
        }
        public override string ToString()
        {
            return (string.Format("{0:00}:{1:00}:{2:00}.{3:00}", _h, _m, _s, _f));
        }

        public static string ConvertMilisecToTimeCode(long milisec)
        {
            var tc = new TimeCode(milisec);
            return tc.ToClockString();
        }
    }
}
