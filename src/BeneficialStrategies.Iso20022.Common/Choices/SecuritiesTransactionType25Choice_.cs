// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType25Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType25Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType25Choice.Code),nameof(SecuritiesTransactionType25Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType25Choice.Proprietary),nameof(SecuritiesTransactionType25Choice.Proprietary))]
    [IsoId("_6dqpg5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Transaction Type 25 Choice")]
    public abstract partial record SecuritiesTransactionType25Choice_
    {
    }
}
