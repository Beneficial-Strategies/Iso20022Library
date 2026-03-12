// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType22Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType22Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType22Choice.Code),nameof(SecuritiesTransactionType22Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType22Choice.Proprietary),nameof(SecuritiesTransactionType22Choice.Proprietary))]
    [IsoId("_6IdOg5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Transaction Type 22 Choice")]
    public abstract partial record SecuritiesTransactionType22Choice_
    {
    }
}
