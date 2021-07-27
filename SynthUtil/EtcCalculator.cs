using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthUtil
{
    //Calculates ETC time for processes
    /* EXAMPLE USAGE
    TODO: Initialize items List
    var i = 0;
    var timer = new EtcCalculator(items.Count - 1);
    foreach (var item in items)
    {
    // TODO: Process item
    i++;
    Console.WriteLine($"ETC = {timer.GetEtc(i)}");
    }
    */
    public class EtcCalculator
    {
        private readonly DateTime _startTime;
        private readonly int _imax; // upper bound of the zero-based array being processed

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxIndex">upper bound of the zero-based array being processed</param>
        public EtcCalculator(int maxIndex)
        {
            _imax = maxIndex;
            _startTime = DateTime.Now;
        }

        public DateTime GetEtc(int iterationsDone)
        {
            var iterationsTotal = _imax + 1;
            var msElapsed = DateTime.Now.Subtract(_startTime).TotalMilliseconds;
            var unitTime = msElapsed / (double)iterationsDone;
            var etc = DateTime.Now.AddMilliseconds(unitTime * (iterationsTotal - iterationsDone));
            return etc;
        }
    }
}
