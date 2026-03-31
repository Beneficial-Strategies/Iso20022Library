// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType10Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType10Choice.Code),
        nameof(SecuritiesTransactionType10Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType10Choice.Proprietary),
        nameof(SecuritiesTransactionType10Choice.Proprietary)
    )]
    [IsoId("_PlajS_vmEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type 10 Choice")]
    public abstract record SecuritiesTransactionType10Choice_ { }
}
