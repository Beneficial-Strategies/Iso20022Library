// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of entitlement calculation method.
    /// </summary>
    [KnownType(typeof(Entitlement1Choice.EntitlementRatio))]
    [KnownType(typeof(Entitlement1Choice.EntitlementDescription))]
    [JsonDerivedType(
        typeof(Entitlement1Choice.EntitlementRatio),
        nameof(Entitlement1Choice.EntitlementRatio)
    )]
    [JsonDerivedType(
        typeof(Entitlement1Choice.EntitlementDescription),
        nameof(Entitlement1Choice.EntitlementDescription)
    )]
    [IsoId("_RDroltp-Ed-ak6NoX_4Aeg_278431032")]
    [DisplayName("Entitlement 1 Choice")]
    public abstract record Entitlement1Choice_ { }
}
