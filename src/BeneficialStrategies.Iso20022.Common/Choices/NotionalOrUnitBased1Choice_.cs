// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the financial instrument unit basis.
    /// </summary>
    [KnownType(typeof(NotionalOrUnitBased1Choice.Code))]
    [KnownType(typeof(NotionalOrUnitBased1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(NotionalOrUnitBased1Choice.Code),
        nameof(NotionalOrUnitBased1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(NotionalOrUnitBased1Choice.Proprietary),
        nameof(NotionalOrUnitBased1Choice.Proprietary)
    )]
    [IsoId("_jltcEJ9VEeqxTNfi5y7ywQ")]
    [DisplayName("Notional Or Unit Based 1 Choice")]
    public abstract record NotionalOrUnitBased1Choice_ { }
}
