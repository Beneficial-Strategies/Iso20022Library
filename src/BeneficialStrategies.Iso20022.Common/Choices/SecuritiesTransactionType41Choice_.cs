// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType41Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType41Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType41Choice.Code),
        nameof(SecuritiesTransactionType41Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType41Choice.Proprietary),
        nameof(SecuritiesTransactionType41Choice.Proprietary)
    )]
    [IsoId("_vXQeJc3zEee5nJBZsW8MFQ")]
    [DisplayName("Securities Transaction Type 41 Choice")]
    public abstract record SecuritiesTransactionType41Choice_ { }
}
