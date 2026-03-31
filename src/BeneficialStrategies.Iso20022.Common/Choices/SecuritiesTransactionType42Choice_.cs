// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType42Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType42Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType42Choice.Code),
        nameof(SecuritiesTransactionType42Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType42Choice.Proprietary),
        nameof(SecuritiesTransactionType42Choice.Proprietary)
    )]
    [IsoId("_KuGT0830Eee5nJBZsW8MFQ")]
    [DisplayName("Securities Transaction Type 42 Choice")]
    public abstract record SecuritiesTransactionType42Choice_ { }
}
