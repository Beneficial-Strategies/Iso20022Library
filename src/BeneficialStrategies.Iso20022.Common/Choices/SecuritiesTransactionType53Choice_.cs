// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType53Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType53Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType53Choice.Code),
        nameof(SecuritiesTransactionType53Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType53Choice.Proprietary),
        nameof(SecuritiesTransactionType53Choice.Proprietary)
    )]
    [IsoId("_VALdo_fYEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 53 Choice")]
    public abstract record SecuritiesTransactionType53Choice_ { }
}
