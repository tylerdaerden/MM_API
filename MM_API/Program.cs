using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using MM_Models.Api.Repositories;
using MM_Models.Api.Services;
using System.Data.Common;
using System.Text;

namespace MM_API
{
#nullable disable
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfiguration configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IAuthRepository, AuthService>();
            builder.Services.AddScoped<IAddRepository, AddService>();
            string databaseadress = Environment.GetEnvironmentVariable("MM_Database");
            builder.Services.AddTransient<DbConnection>(sp => new SqlConnection(configuration.GetConnectionString("MM_Database").Replace("DB_HOST", databaseadress ?? "TOURPCDANY\\DATAVIZ")));
            //pour la VDI
            //("DB_HOST", databaseadress ?? "FORMA - VDI303\\TFTIC")));

            //builder.Configuration.GetConnectionString("default").Replace("MixMashter.Database", databaseadress);

            #region token

            //builder.Services.AddScoped<ITokenRepository, TokenService>();
            builder.Services.AddAuthorization();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };
            });


            #endregion
            //builder.Services.AddScoped<IContactRepository, ContactService>();

            var app = builder.Build();
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