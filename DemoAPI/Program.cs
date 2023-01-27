using DemoAPI.Demo;
using System.Runtime.CompilerServices;

namespace DemoAPI {
	public class Program {
		public static void Main(string[] args) {
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			RegisterServices(builder);

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment()) {
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}

		/// <summary>
		/// Register the non boilerplate services here
		/// </summary>
		private static void RegisterServices(WebApplicationBuilder builder) {
			// Demo
			builder.Services.AddTransient<IDemoRepository, DemoRepository>();
			builder.Services.AddTransient<IDemoService, DemoService>();
		}
	}
}