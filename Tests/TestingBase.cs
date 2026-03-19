using Neovolve.Logging.Xunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using FinancialModelingPrep;
using Xunit.Abstractions;

namespace Tests;

public abstract class TestingBase
{
    protected IServiceCollection Services { get; private set; }
    protected IServiceProvider ServiceProvider { get; private set; }

    private static readonly IConfigurationRoot ConfigurationRoot;

    private static readonly FinancialModelingPrepOptions testingOptions;

    static TestingBase()
    {
        var config = new ConfigurationBuilder();
        config.AddEnvironmentVariables("FMP_TESTS_");
        ConfigurationRoot = config.Build();

        testingOptions = CreateTestingOptions();
    }

    public TestingBase(ITestOutputHelper testOutput)
    {
        Services = new ServiceCollection();

        Services.AddSingleton(ConfigurationRoot);

        Services.AddLogging(builder =>
        {
            builder.ClearProviders();
            builder.AddXunit(testOutput, CreateLoggingConfig());
            builder.SetMinimumLevel(LogLevel.Debug);
        });

        Services.AddFinancialModelingPrepApiClient(testingOptions);

        Build();
    }

    private static FinancialModelingPrepOptions CreateTestingOptions()
    {
        var apiKeySection = ConfigurationRoot.GetSection("API_KEY");

            var apiKey = apiKeySection.Value ?? "demo";

        return new FinancialModelingPrepOptions
        {
            ApiKey = apiKey,
            MaxAPICallsPerMinute = 150,
            MaxRequestPerSecond = 5,
        };
    }

    private static LoggingConfig CreateLoggingConfig()
    {
        var config = new LoggingConfig();

        config.SensitiveValues.Add(testingOptions.ApiKey);

        return config;
    }

    protected void Build()
    {
        ServiceProvider = Services.BuildServiceProvider();
    }
}