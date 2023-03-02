// Threads
//double exp1 = 0;
//var t = new Thread(() => { exp1 = Math.Exp(40); });
//t.Start();
//t.
//t.Join();

//Console.WriteLine(exp1);

// Thread Pool
double exp1 = 0;
var mres = new ManualResetEventSlim(false);
ThreadPool.QueueUserWorkItem<ManualResetEventSlim>((_mres) =>
{
    exp1 = Math.Exp(40);
    mres.Set();
}, mres, false);
// ...
mres.Wait();