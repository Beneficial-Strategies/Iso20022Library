// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proxy allowance.
    /// </summary>
    [KnownType(typeof(Proxy4Choice.Proxy))]
    [KnownType(typeof(Proxy4Choice.ProxyNotAllowed))]
    [JsonDerivedType(typeof(Proxy4Choice.Proxy), nameof(Proxy4Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy4Choice.ProxyNotAllowed), nameof(Proxy4Choice.ProxyNotAllowed))]
    [IsoId("_euVP0fM7EeqRfth943bvEA")]
    [DisplayName("Proxy 4 Choice")]
    public abstract record Proxy4Choice_ { }
}
