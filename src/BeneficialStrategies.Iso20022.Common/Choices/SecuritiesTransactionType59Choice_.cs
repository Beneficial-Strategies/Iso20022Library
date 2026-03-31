// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType59Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType59Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType59Choice.Code),
        nameof(SecuritiesTransactionType59Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType59Choice.Proprietary),
        nameof(SecuritiesTransactionType59Choice.Proprietary)
    )]
    [IsoId("_mJ53ywleEeuQ1MenzX1l-g")]
    [DisplayName("Securities Transaction Type 59 Choice")]
    public abstract record SecuritiesTransactionType59Choice_ { }
}
