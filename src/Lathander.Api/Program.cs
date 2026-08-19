using Lathander.IoC;

namespace Lathander.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddControllers()
            .AddXmlSerializerFormatters();

        builder.Services.AddOpenApi();

        builder.Services.AddLathander(builder.Configuration);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
            app.MapOpenApi();

        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}
