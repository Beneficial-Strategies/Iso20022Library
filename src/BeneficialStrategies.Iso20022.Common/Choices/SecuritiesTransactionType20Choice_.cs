// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType20Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType20Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType20Choice.Code),nameof(SecuritiesTransactionType20Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType20Choice.Proprietary),nameof(SecuritiesTransactionType20Choice.Proprietary))]
    [IsoId("_ZBbRYTqlEeWyoP0PbocV1Q")]
    [DisplayName("Securities Transaction Type 20 Choice")]
    public abstract partial record SecuritiesTransactionType20Choice_
    {
    }
}
