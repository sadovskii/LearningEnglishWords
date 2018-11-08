using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.BLL.Services;
using ExerciseForLearningWords.DAL.EF;
using ExerciseForLearningWords.DAL.Repo;
using ExerciseForLearningWords.DAL.Repo.Implementations;
using ExerciseForLearningWords.DAL.Repo.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExerciseForLearningWords
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;  
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // получаем строку подключения из файла конфигурации
            string connection = Configuration.GetConnectionString("DefaultConnection");
            // добавляем контекст MobileContext в качестве сервиса в приложение
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            services.AddMvc();
            services.AddScoped(typeof(IWordsAndTranslationPairRepository), typeof(WordsAndTranslationPairRepository));
            services.AddScoped(typeof(IWordsListRepository), typeof(WordsListRepository));
            services.AddTransient<ICreatorListsService, CreatorListService>();
            services.AddTransient<IExerciseForLearningService, ExerciseForLearningService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=CreatorLists}/{action=Creator}/{id?}");
            });
        }
    }
}
