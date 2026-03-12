// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a securities transaction type.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType31Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType31Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType31Choice.Code),nameof(SecuritiesTransactionType31Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType31Choice.Proprietary),nameof(SecuritiesTransactionType31Choice.Proprietary))]
    [IsoId("_SALlkeLcEeWFtOV72FbX9w")]
    [DisplayName("Securities Transaction Type 31 Choice")]
    public abstract partial record SecuritiesTransactionType31Choice_
    {
    }
}
