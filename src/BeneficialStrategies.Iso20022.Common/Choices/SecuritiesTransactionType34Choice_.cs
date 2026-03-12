// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType34Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType34Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesTransactionType34Choice.Code),nameof(SecuritiesTransactionType34Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType34Choice.Proprietary),nameof(SecuritiesTransactionType34Choice.Proprietary))]
    [IsoId("_zmv34ZwxEeazcsnODTksnQ")]
    [DisplayName("Securities Transaction Type 34 Choice")]
    public abstract partial record SecuritiesTransactionType34Choice_
    {
    }
}
