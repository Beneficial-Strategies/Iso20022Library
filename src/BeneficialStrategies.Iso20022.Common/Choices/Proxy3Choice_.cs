// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proxy allowance.
    /// </summary>
    [KnownType(typeof(Proxy3Choice.Proxy))]
    [KnownType(typeof(Proxy3Choice.ProxyNotAllowed))]
    [JsonDerivedType(typeof(Proxy3Choice.Proxy), nameof(Proxy3Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy3Choice.ProxyNotAllowed), nameof(Proxy3Choice.ProxyNotAllowed))]
    [IsoId("_j7B_sa09EemDtrWpq90Ckg")]
    [DisplayName("Proxy 3 Choice")]
    public abstract record Proxy3Choice_ { }
}
