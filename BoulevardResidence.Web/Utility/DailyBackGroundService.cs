//using BoulevardResidence.Domain.Data;
//using BoulevardResidence.Domain.Entity.DailyBackGround;
//using BoulevardResidence.Service.Interfaces;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace BoulevardResidence.Web.Utility
//{
//    public class DailyBackgroundService : IHostedService, IDisposable
//    {
//        private Timer _timer;
//        private readonly IServiceProvider _serviceProvider;
//        private Random random = new Random();
//        public DailyBackgroundService(IServiceProvider serviceProvider)
//        {
//            _serviceProvider = serviceProvider;
//        }

//        public Task StartAsync(CancellationToken cancellationToken)
//        {
//            var interval = TimeSpan.FromSeconds(15); // Set the interval to 15 seconds

//            _timer = new Timer(DoWork, null, TimeSpan.Zero, interval); // Start immediately and repeat every 15 seconds

//            return Task.CompletedTask;
//        }

//        private void DoWork(object state)
//        {
//            using (var scope = _serviceProvider.CreateScope())
//            {
//                var service = scope.ServiceProvider.GetRequiredService<IBackService>();
//                int newId = random.Next();

//                // Perform your work using the scoped service
//                var result = "Günlük görev çalıştı - " + DateTime.Now;

//                var dailyTaskResult = new DailyTaskResult
//                {
//              Id=newId,
//                    Result = result
//                };
//                service.Create(dailyTaskResult);
//            }
//        }

//        public Task StopAsync(CancellationToken cancellationToken)
//        {
//            _timer?.Change(Timeout.Infinite, 0);
//            return Task.CompletedTask;
//        }

//        public void Dispose()
//        {
//            _timer?.Dispose();
//            GC.SuppressFinalize(this);
//        }
//    }
//}
