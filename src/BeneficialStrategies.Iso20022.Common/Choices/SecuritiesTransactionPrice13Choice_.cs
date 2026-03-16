// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice13Choice.BasisPointSpread))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice13Choice.MonetaryValue),
        nameof(SecuritiesTransactionPrice13Choice.MonetaryValue)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice13Choice.Percentage),
        nameof(SecuritiesTransactionPrice13Choice.Percentage)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice13Choice.Decimal),
        nameof(SecuritiesTransactionPrice13Choice.Decimal)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice13Choice.BasisPointSpread),
        nameof(SecuritiesTransactionPrice13Choice.BasisPointSpread)
    )]
    [IsoId("_k-0NsQFMEeqUa4noT3P56A")]
    [DisplayName("Securities Transaction Price 13 Choice")]
    public abstract record SecuritiesTransactionPrice13Choice_ { }
}
