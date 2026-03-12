// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [KnownType(typeof(TransactionCollateralData14Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionCollateralData14Choice.BuySellBack))]
    [KnownType(typeof(TransactionCollateralData14Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionCollateralData14Choice.MarginLending))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.RepurchaseTrade),nameof(TransactionCollateralData14Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.BuySellBack),nameof(TransactionCollateralData14Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.SecuritiesLending),nameof(TransactionCollateralData14Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.MarginLending),nameof(TransactionCollateralData14Choice.MarginLending))]
    [IsoId("_ksszMf_9Eemefbt-QjTNnA")]
    [DisplayName("Transaction Collateral Data 14 Choice")]
    public abstract partial record TransactionCollateralData14Choice_
    {
    }
}
