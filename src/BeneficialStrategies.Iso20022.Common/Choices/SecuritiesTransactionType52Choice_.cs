// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType52Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType52Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType52Choice.Code),nameof(SecuritiesTransactionType52Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType52Choice.Proprietary),nameof(SecuritiesTransactionType52Choice.Proprietary))]
    [IsoId("_J4Cyy_fYEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 52 Choice")]
    public abstract partial record SecuritiesTransactionType52Choice_
    {
    }
}
