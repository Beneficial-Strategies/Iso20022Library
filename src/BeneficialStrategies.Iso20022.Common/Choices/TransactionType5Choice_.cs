// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the order type.
    /// </summary>
    [KnownType(typeof(TransactionType5Choice.Code))]
    [KnownType(typeof(TransactionType5Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionType5Choice.Code), nameof(TransactionType5Choice.Code))]
    [JsonDerivedType(
        typeof(TransactionType5Choice.Proprietary),
        nameof(TransactionType5Choice.Proprietary)
    )]
    [IsoId("_x6jKoVsJEea4y99eritluQ")]
    [DisplayName("Transaction Type 5 Choice")]
    public abstract record TransactionType5Choice_ { }
}
