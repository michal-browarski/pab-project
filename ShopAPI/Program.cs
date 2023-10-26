
using Microsoft.EntityFrameworkCore;
using ShopAPI.DB.Context;

namespace ShopAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddDbContext<ShopContext>(opt =>
				opt.UseInMemoryDatabase("InMemoryContext"));

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			using (var scope = app.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				var context = services.GetRequiredService<ShopContext>();
				context.Database.EnsureCreated(); // This will create the database and apply migrations if necessary
			}

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}