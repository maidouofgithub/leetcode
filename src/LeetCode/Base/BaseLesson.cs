﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public abstract class BaseLesson : ILesson
    {
        public static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        protected abstract int Index { get; set; }
        protected abstract string Title { get; set; }
        protected abstract string Desc { get; set; }
        protected abstract string Url { get; set; } 

        public abstract void Action();
        public void BaseAction()
        {
            Console.WriteLine($"===={nameof(Index)}:{this.Index}====");
            Console.WriteLine($"===={nameof(Title)}:{this.Title}====");
            Console.WriteLine($"===={nameof(Desc)}:{this.Desc}====");
            Console.WriteLine($"===={nameof(Url)}:{this.Url}===="); 
        }

        public void ShowParam(Dictionary<string,object> param)
        {
            foreach (var item in param)
            {
                var type = item.Value.GetType();
                switch (type)
                {  
                }
                log.Trace($"*****{(item.Key)}:{item.Value}****");
            }  
        }
    }
     
}
