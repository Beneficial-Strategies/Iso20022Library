// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the scheme used for the identification of an account alias.
    /// </summary>
    [KnownType(typeof(ProxyAccountType1Choice.Code))]
    [KnownType(typeof(ProxyAccountType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProxyAccountType1Choice.Code), nameof(ProxyAccountType1Choice.Code))]
    [JsonDerivedType(
        typeof(ProxyAccountType1Choice.Proprietary),
        nameof(ProxyAccountType1Choice.Proprietary)
    )]
    [IsoId("_dyock3h3EeidzqjNEfehPg")]
    [DisplayName("Proxy Account Type 1 Choice")]
    public abstract record ProxyAccountType1Choice_ { }
}
