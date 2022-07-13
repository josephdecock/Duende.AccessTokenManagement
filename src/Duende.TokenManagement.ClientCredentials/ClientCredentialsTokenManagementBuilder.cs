using System;
using Duende.TokenManagement.ClientCredentials;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Builder for client credential clients
/// </summary>
public class ClientCredentialsTokenManagementBuilder
{
    private readonly IServiceCollection _services;

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="services"></param>
    public ClientCredentialsTokenManagementBuilder(IServiceCollection services)
    {
        _services = services;
    }

    /// <summary>
    /// Adds a client credentials client to the token management system
    /// </summary>
    /// <param name="name"></param>
    /// <param name="configureOptions"></param>
    /// <returns></returns>
    public ClientCredentialsTokenManagementBuilder AddClient(string name, Action<ClientCredentialsClient> configureOptions)
    {
        _services.Configure(name, configureOptions);
        return this;
    }
}