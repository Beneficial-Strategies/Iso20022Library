// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of proxy allowance.
    /// </summary>
    [KnownType(typeof(Proxy1Choice.Proxy))]
    [KnownType(typeof(Proxy1Choice.ProxyNotAllowed))]
    [JsonDerivedType(typeof(Proxy1Choice.Proxy),nameof(Proxy1Choice.Proxy))]
    [JsonDerivedType(typeof(Proxy1Choice.ProxyNotAllowed),nameof(Proxy1Choice.ProxyNotAllowed))]
    [IsoId("_RD1ZkNp-Ed-ak6NoX_4Aeg_754984045")]
    [DisplayName("Proxy 1 Choice")]
    public abstract partial record Proxy1Choice_
    {
    }
}
