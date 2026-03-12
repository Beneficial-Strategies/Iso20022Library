// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType21Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType21Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType21Choice.Code),nameof(SecuritiesTransactionType21Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType21Choice.Proprietary),nameof(SecuritiesTransactionType21Choice.Proprietary))]
    [IsoId("_8qa_UTtDEeWRTLSN0i0tng")]
    [DisplayName("Securities Transaction Type 21 Choice")]
    public abstract partial record SecuritiesTransactionType21Choice_
    {
    }
}
