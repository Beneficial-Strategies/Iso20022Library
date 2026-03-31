// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate1Choice.Date))]
    [KnownType(typeof(SettlementDate1Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate1Choice.Date), nameof(SettlementDate1Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate1Choice.DateCode),
        nameof(SettlementDate1Choice.DateCode)
    )]
    [IsoId("_QvRe09p-Ed-ak6NoX_4Aeg_-872242536")]
    [DisplayName("Settlement Date 1 Choice")]
    public abstract record SettlementDate1Choice_ { }
}
