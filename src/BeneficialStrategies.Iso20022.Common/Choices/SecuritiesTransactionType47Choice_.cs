// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType47Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType47Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType47Choice.Code),nameof(SecuritiesTransactionType47Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType47Choice.Proprietary),nameof(SecuritiesTransactionType47Choice.Proprietary))]
    [IsoId("_qeGLEdYYEeiHVOfMzoKxnA")]
    [DisplayName("Securities Transaction Type 47 Choice")]
    public abstract partial record SecuritiesTransactionType47Choice_
    {
    }
}
