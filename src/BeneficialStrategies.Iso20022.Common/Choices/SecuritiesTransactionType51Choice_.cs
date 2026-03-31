// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType51Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType51Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType51Choice.Code),
        nameof(SecuritiesTransactionType51Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType51Choice.Proprietary),
        nameof(SecuritiesTransactionType51Choice.Proprietary)
    )]
    [IsoId("_5-eRf_fXEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 51 Choice")]
    public abstract record SecuritiesTransactionType51Choice_ { }
}
