// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Text.Json.Serialization;

namespace Duende.AccessTokenManagement;

/// <summary>
/// Provides source-generation-backed serialization. Needed for AOT-compiled applications. Requires C# 9.0 or later.
/// </summary>
[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(ClientCredentialsToken))]
internal partial class ClientCredentialsTokenContext : JsonSerializerContext
{
}
