// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType36Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType36Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType36Choice.Code),
        nameof(SecuritiesTransactionType36Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType36Choice.Proprietary),
        nameof(SecuritiesTransactionType36Choice.Proprietary)
    )]
    [IsoId("_1egQwaUoEee4_75LDmHZiQ")]
    [DisplayName("Securities Transaction Type 36 Choice")]
    public abstract record SecuritiesTransactionType36Choice_ { }
}
