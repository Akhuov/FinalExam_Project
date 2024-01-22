using CitySays.Api.ImgSaveService;
using CitySays.Application;
using CitySays.Application.Services.Arts;
using CitySays.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAplication();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();/*options =>*/
//{
//options.SwaggerDoc("V1", new OpenApiInfo
//{
//    Version = "v1",
//    Title = "AuthDemo",
//    Description = "Auth Demo Description"
//});

//options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
//{
//    Scheme = "Bearer",
//    BearerFormat = "JWT",
//    Description = "Bearer Authentication",
//    Type = SecuritySchemeType.Http
//});

//options.AddSecurityRequirement(new OpenApiSecurityRequirement()
//{
//    {
//        new OpenApiSecurityScheme()
//        {
//            Reference = new OpenApiReference()
//            {
//                Id = "Bearer",
//                Type = ReferenceType.SecurityScheme
//            }
//        },
//        new List<string> ()
//    }

//});
//});

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(opttins =>
//    {
//        opttins.TokenValidationParameters = new TokenValidationParameters
//        {
//            // kimga chiqarilgan
//            ValidateIssuer = true,
//            // kim tomonidan berilgan
//            ValidateAudience = true,
//            // vaqti
//            ValidateLifetime = true,
//            // secret keyi
//            ValidateIssuerSigningKey = true,
//            ValidAudience = builder.Configuration["JWT:ValidAudience"],
//            ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"])),
//            ClockSkew = TimeSpan.Zero
//        };
//    });


builder.Services.AddScoped<ISavingService, SavingService>();

builder.Services.AddTransient<IArtService, ArtService>();

builder.Services.AddMemoryCache();


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
