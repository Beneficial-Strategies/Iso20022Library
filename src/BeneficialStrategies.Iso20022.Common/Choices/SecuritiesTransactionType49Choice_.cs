// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType49Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType49Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType49Choice.Code),
        nameof(SecuritiesTransactionType49Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType49Choice.Proprietary),
        nameof(SecuritiesTransactionType49Choice.Proprietary)
    )]
    [IsoId("_ZdqQwffXEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 49 Choice")]
    public abstract record SecuritiesTransactionType49Choice_ { }
}
