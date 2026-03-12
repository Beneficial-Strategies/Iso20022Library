// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType55Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType55Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType55Choice.Code),nameof(SecuritiesTransactionType55Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType55Choice.Proprietary),nameof(SecuritiesTransactionType55Choice.Proprietary))]
    [IsoId("_qIKqe_fYEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 55 Choice")]
    public abstract partial record SecuritiesTransactionType55Choice_
    {
    }
}
