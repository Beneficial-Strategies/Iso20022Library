// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [KnownType(typeof(TransactionCollateralData15Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionCollateralData15Choice.BuySellBack))]
    [KnownType(typeof(TransactionCollateralData15Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionCollateralData15Choice.MarginLending))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.RepurchaseTrade),nameof(TransactionCollateralData15Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.BuySellBack),nameof(TransactionCollateralData15Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.SecuritiesLending),nameof(TransactionCollateralData15Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.MarginLending),nameof(TransactionCollateralData15Choice.MarginLending))]
    [IsoId("_fH7CbwAFEeqefbt-QjTNnA")]
    [DisplayName("Transaction Collateral Data 15 Choice")]
    public abstract partial record TransactionCollateralData15Choice_
    {
    }
}
