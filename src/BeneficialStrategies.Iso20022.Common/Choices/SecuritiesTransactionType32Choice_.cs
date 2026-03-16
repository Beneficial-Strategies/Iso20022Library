// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType32Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType32Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType32Choice.Code),
        nameof(SecuritiesTransactionType32Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType32Choice.Proprietary),
        nameof(SecuritiesTransactionType32Choice.Proprietary)
    )]
    [IsoId("_3yuuLYvXEea5B-LIompvYg")]
    [DisplayName("Securities Transaction Type 32 Choice")]
    public abstract record SecuritiesTransactionType32Choice_ { }
}
