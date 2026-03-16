// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate16Choice.Date))]
    [KnownType(typeof(SettlementDate16Choice.Code))]
    [JsonDerivedType(typeof(SettlementDate16Choice.Date), nameof(SettlementDate16Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate16Choice.Code), nameof(SettlementDate16Choice.Code))]
    [IsoId("_GhdJYZBhEeakHoV5BVecAQ")]
    [DisplayName("Settlement Date 16 Choice")]
    public abstract record SettlementDate16Choice_ { }
}
