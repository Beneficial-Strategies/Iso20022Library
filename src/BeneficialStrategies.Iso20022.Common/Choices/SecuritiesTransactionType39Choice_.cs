// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType39Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType39Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType39Choice.Code),
        nameof(SecuritiesTransactionType39Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType39Choice.Proprietary),
        nameof(SecuritiesTransactionType39Choice.Proprietary)
    )]
    [IsoId("_VKmjf83zEee5nJBZsW8MFQ")]
    [DisplayName("Securities Transaction Type 39 Choice")]
    public abstract record SecuritiesTransactionType39Choice_ { }
}
