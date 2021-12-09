namespace gql_hotchocolate_skd50
{
  using FluentValidation;

  using gql_hotchocolate_skd50.Controllers;

  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.Extensions.Configuration;
  using Microsoft.Extensions.DependencyInjection;

  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseRouting();
      app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddValidatorsFromAssemblyContaining<Program>();
      
      services.AddGraphQLServer()
        .AddQueryType<Query>().AddMutationType<Mutation>()
        .AddAuthorization()
        .AddFairyBread();
    }
  }
}