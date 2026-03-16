// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proxy allowance.
    /// </summary>
    [KnownType(typeof(Proxy2Choice.Proxy))]
    [KnownType(typeof(Proxy2Choice.ProxyNotAllowed))]
    [JsonDerivedType(typeof(Proxy2Choice.Proxy), nameof(Proxy2Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy2Choice.ProxyNotAllowed), nameof(Proxy2Choice.ProxyNotAllowed))]
    [IsoId("_7DISd1tgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy 2 Choice")]
    public abstract record Proxy2Choice_ { }
}
