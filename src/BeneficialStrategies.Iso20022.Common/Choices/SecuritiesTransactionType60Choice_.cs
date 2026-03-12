// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType60Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType60Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType60Choice.Code),nameof(SecuritiesTransactionType60Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType60Choice.Proprietary),nameof(SecuritiesTransactionType60Choice.Proprietary))]
    [IsoId("_a7-VeSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Securities Transaction Type 60 Choice")]
    public abstract partial record SecuritiesTransactionType60Choice_
    {
    }
}
