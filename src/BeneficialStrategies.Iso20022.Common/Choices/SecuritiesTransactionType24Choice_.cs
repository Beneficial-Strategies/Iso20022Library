// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType24Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType24Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType24Choice.Code),
        nameof(SecuritiesTransactionType24Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType24Choice.Proprietary),
        nameof(SecuritiesTransactionType24Choice.Proprietary)
    )]
    [IsoId("_6SbDCZNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Transaction Type 24 Choice")]
    public abstract record SecuritiesTransactionType24Choice_ { }
}
