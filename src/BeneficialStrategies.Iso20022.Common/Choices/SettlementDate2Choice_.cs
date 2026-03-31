// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate2Choice.Date))]
    [KnownType(typeof(SettlementDate2Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate2Choice.Date), nameof(SettlementDate2Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate2Choice.DateCode),
        nameof(SettlementDate2Choice.DateCode)
    )]
    [IsoId("_QurB59p-Ed-ak6NoX_4Aeg_419726603")]
    [DisplayName("Settlement Date 2 Choice")]
    public abstract record SettlementDate2Choice_ { }
}
