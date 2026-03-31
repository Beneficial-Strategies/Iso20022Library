// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType48Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType48Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType48Choice.Code),
        nameof(SecuritiesTransactionType48Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType48Choice.Proprietary),
        nameof(SecuritiesTransactionType48Choice.Proprietary)
    )]
    [IsoId("_vIV8EddqEeispNOuywCdbA")]
    [DisplayName("Securities Transaction Type 48 Choice")]
    public abstract record SecuritiesTransactionType48Choice_ { }
}
