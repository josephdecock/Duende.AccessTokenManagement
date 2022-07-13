// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Duende.TokenManagement.OpenIdConnect;

/// <summary>
/// Configuration setting sourced from the OpenID Connect handler
/// </summary>
public class OpenIdConnectClientConfiguration
{
    /// <summary>
    /// The token endpoint address
    /// </summary>
    public string? TokenEndpoint { get; set; }

    /// <summary>
    /// The revocation endpoint address
    /// </summary>
    public string? RevocationEndpoint { get; set; }

    /// <summary>
    /// The client ID
    /// </summary>
    public string? ClientId { get; set; }
    
    /// <summary>
    /// The client secret
    /// </summary>
    public string? ClientSecret { get; set; }
}