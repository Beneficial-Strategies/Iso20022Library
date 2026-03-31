// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus1Choice.Code))]
    [KnownType(typeof(SettlementStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus1Choice.Code), nameof(SettlementStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(SettlementStatus1Choice.Proprietary),
        nameof(SettlementStatus1Choice.Proprietary)
    )]
    [IsoId("_UYUpJ9p-Ed-ak6NoX_4Aeg_-484323016")]
    [DisplayName("Settlement Status 1 Choice")]
    public abstract record SettlementStatus1Choice_ { }
}
