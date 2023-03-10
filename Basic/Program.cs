// Threads
//double exp1 = 0;
//var t = new Thread(() => { exp1 = Math.Exp(40); });
//t.Start();
//t.
//t.Join();

//Console.WriteLine(exp1);

// Thread Pool
//double exp1 = 0;
//var mres = new ManualResetEventSlim(false);
//ThreadPool.QueueUserWorkItem<ManualResetEventSlim>((_mres) =>
//{
//    exp1 = Math.Exp(40);
//    mres.Set();
//}, mres, false);
//// ...
//mres.Wait();
//Console.WriteLine("Task Started");
//var task = Task.Run(() => Math.Exp(40));
//var taskResult = task.Result;
//Console.WriteLine(taskResult);


//using TaskVsThread;

//Body body = null!;
//CarBuildingWithTask carBuildingWithTask =new CarBuildingWithTask();
//var bodyThread = new Thread(() => {body= CarBuildingWithTask.BuildBody(100, 5, 2); });
//bodyThread.Start();

using Basic;

TaskRun taskRun = new TaskRun();
//var task1 = Task.Run(() => taskRun.DoWork(1, 5000));
//var task2 = Task.Run(() => taskRun.DoWork(2, 2000));
//var task3 = Task.Run(() => taskRun.DoWork(3, 3000));
//Task.WaitAll(task1, task2, task3);
//Console.WriteLine("Completed All tasks");

var task1 = Task.Factory.StartNew(() => taskRun.DoWork(1, 5000));
var task2 = Task.Factory.StartNew(() => taskRun.DoWork(2, 2000));
var task3 = Task.Factory.StartNew(() => taskRun.DoWork(3, 3000));
Task.WaitAll(task1, task2, task3);
Console.WriteLine("Completed All Factory tasks");