// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [KnownType(typeof(TransactionCollateralData18Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionCollateralData18Choice.BuySellBack))]
    [KnownType(typeof(TransactionCollateralData18Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionCollateralData18Choice.MarginLending))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.RepurchaseTrade),nameof(TransactionCollateralData18Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.BuySellBack),nameof(TransactionCollateralData18Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.SecuritiesLending),nameof(TransactionCollateralData18Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.MarginLending),nameof(TransactionCollateralData18Choice.MarginLending))]
    [IsoId("_C5KZIcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Transaction Collateral Data 18 Choice")]
    public abstract partial record TransactionCollateralData18Choice_
    {
    }
}
