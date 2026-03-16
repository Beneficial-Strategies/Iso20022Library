// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType19Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType19Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType19Choice.Code),
        nameof(SecuritiesTransactionType19Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionType19Choice.Proprietary),
        nameof(SecuritiesTransactionType19Choice.Proprietary)
    )]
    [IsoId("_hIz28TqfEeWyoP0PbocV1Q")]
    [DisplayName("Securities Transaction Type 19 Choice")]
    public abstract record SecuritiesTransactionType19Choice_ { }
}
