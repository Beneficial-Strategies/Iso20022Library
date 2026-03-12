// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate3Choice.Date))]
    [KnownType(typeof(SettlementDate3Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate3Choice.Date),nameof(SettlementDate3Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate3Choice.DateCode),nameof(SettlementDate3Choice.DateCode))]
    [IsoId("_Qsl-Rtp-Ed-ak6NoX_4Aeg_228808861")]
    [DisplayName("Settlement Date 3 Choice")]
    public abstract partial record SettlementDate3Choice_
    {
    }
}
