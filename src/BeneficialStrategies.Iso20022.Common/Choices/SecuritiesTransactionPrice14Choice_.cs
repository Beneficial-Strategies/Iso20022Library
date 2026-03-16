// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice14Choice.Rate))]
    [KnownType(typeof(SecuritiesTransactionPrice14Choice.Decimal))]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice14Choice.Rate),
        nameof(SecuritiesTransactionPrice14Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(SecuritiesTransactionPrice14Choice.Decimal),
        nameof(SecuritiesTransactionPrice14Choice.Decimal)
    )]
    [IsoId("_MwrRwQVJEequL9Y8-ASIxA")]
    [DisplayName("Securities Transaction Price 14 Choice")]
    public abstract record SecuritiesTransactionPrice14Choice_ { }
}
