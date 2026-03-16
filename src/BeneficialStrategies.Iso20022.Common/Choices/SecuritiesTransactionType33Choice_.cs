// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType33Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType33Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType33Choice.Code),
        nameof(SecuritiesTransactionType33Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType33Choice.Proprietary),
        nameof(SecuritiesTransactionType33Choice.Proprietary)
    )]
    [IsoId("_pvgCz4ymEea-QrbCUXny2w")]
    [DisplayName("Securities Transaction Type 33 Choice")]
    public abstract record SecuritiesTransactionType33Choice_ { }
}
