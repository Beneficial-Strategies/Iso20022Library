// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proxy allowance.
    /// </summary>
    [KnownType(typeof(Proxy5Choice.Proxy))]
    [KnownType(typeof(Proxy5Choice.ProxyNotAllowed))]
    [JsonDerivedType(typeof(Proxy5Choice.Proxy),nameof(Proxy5Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy5Choice.ProxyNotAllowed),nameof(Proxy5Choice.ProxyNotAllowed))]
    [IsoId("_h93sIRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy 5 Choice")]
    public abstract partial record Proxy5Choice_
    {
    }
}
