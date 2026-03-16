// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType38Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType38Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType38Choice.Code),
        nameof(SecuritiesTransactionType38Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType38Choice.Proprietary),
        nameof(SecuritiesTransactionType38Choice.Proprietary)
    )]
    [IsoId("_EAO4X6UtEee4_75LDmHZiQ")]
    [DisplayName("Securities Transaction Type 38 Choice")]
    public abstract record SecuritiesTransactionType38Choice_ { }
}
