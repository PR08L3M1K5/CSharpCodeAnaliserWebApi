using Microsoft.EntityFrameworkCore;

namespace CSharpCodeAnaliserWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<PostgresDatabase>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddOptions();

            builder.Services.AddControllers();

            builder.Services.AddCors(options=>options.AddPolicy("AllowAccess_To_API",
                policy=> policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()));

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseCors("AllowAccess_To_API");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}