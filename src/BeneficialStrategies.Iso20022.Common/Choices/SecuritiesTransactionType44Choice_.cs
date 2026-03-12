// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType44Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType44Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType44Choice.Code),nameof(SecuritiesTransactionType44Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType44Choice.Proprietary),nameof(SecuritiesTransactionType44Choice.Proprietary))]
    [IsoId("_VHZGkdEmEeiO-eodGv5iKQ")]
    [DisplayName("Securities Transaction Type 44 Choice")]
    public abstract partial record SecuritiesTransactionType44Choice_
    {
    }
}
