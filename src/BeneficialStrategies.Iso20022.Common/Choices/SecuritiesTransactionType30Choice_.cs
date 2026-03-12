// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType30Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType30Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType30Choice.Code),nameof(SecuritiesTransactionType30Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType30Choice.Proprietary),nameof(SecuritiesTransactionType30Choice.Proprietary))]
    [IsoId("_8VKXgZNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Transaction Type 30 Choice")]
    public abstract partial record SecuritiesTransactionType30Choice_
    {
    }
}
