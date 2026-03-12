// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType18Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType18Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType18Choice.Code),nameof(SecuritiesTransactionType18Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType18Choice.Proprietary),nameof(SecuritiesTransactionType18Choice.Proprietary))]
    [IsoId("_1UD5YTqDEeWVrPy0StzzSg")]
    [DisplayName("Securities Transaction Type 18 Choice")]
    public abstract partial record SecuritiesTransactionType18Choice_
    {
    }
}
