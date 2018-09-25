﻿using System.Diagnostics;
using System.Reflection;
using System.Threading;
//ready
namespace TracerLibrary
{
     public class Tracer : ITracer
    {
          private TraceResult traceResult;

          public Tracer()
          {
               traceResult = new TraceResult();
          }

          public void StartTrace()
          {
               MethodBase itemMethdod = new StackTrace().GetFrame(1).GetMethod();
               traceResult.StartTrace(Thread.CurrentThread.ManagedThreadId, itemMethdod);
          }

          public void StopTrace()
          {
               traceResult.StopTrace(Thread.CurrentThread.ManagedThreadId); 
          }

          public TraceResult GetTraceResult()
          {
               return traceResult;
          }
    }
}
