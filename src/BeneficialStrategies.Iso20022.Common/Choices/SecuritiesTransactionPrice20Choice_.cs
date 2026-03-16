// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.BasisPointSpread))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice20Choice.MonetaryValue),
        nameof(SecuritiesTransactionPrice20Choice.MonetaryValue)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice20Choice.Percentage),
        nameof(SecuritiesTransactionPrice20Choice.Percentage)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice20Choice.Decimal),
        nameof(SecuritiesTransactionPrice20Choice.Decimal)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice20Choice.BasisPointSpread),
        nameof(SecuritiesTransactionPrice20Choice.BasisPointSpread)
    )]
    [IsoId("_IXsu0U2vEe2Ci6HlmBLbDw")]
    [DisplayName("Securities Transaction Price 20 Choice")]
    public abstract record SecuritiesTransactionPrice20Choice_ { }
}
