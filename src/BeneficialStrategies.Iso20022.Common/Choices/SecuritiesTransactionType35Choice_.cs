// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType35Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType35Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType35Choice.Code),nameof(SecuritiesTransactionType35Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType35Choice.Proprietary),nameof(SecuritiesTransactionType35Choice.Proprietary))]
    [IsoId("_D5OqYZwyEeazcsnODTksnQ")]
    [DisplayName("Securities Transaction Type 35 Choice")]
    public abstract partial record SecuritiesTransactionType35Choice_
    {
    }
}
