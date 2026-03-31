// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType12Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType12Choice.Code),
        nameof(SecuritiesTransactionType12Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType12Choice.Proprietary),
        nameof(SecuritiesTransactionType12Choice.Proprietary)
    )]
    [IsoId("_8B67jf8qEeCQ-IWv9MUPeQ")]
    [DisplayName("Securities Transaction Type 12 Choice")]
    public abstract record SecuritiesTransactionType12Choice_ { }
}
