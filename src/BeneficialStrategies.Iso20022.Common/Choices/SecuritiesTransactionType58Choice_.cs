// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType58Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType58Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType58Choice.Code),
        nameof(SecuritiesTransactionType58Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType58Choice.Proprietary),
        nameof(SecuritiesTransactionType58Choice.Proprietary)
    )]
    [IsoId("_sanUB_fZEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 58 Choice")]
    public abstract record SecuritiesTransactionType58Choice_ { }
}
