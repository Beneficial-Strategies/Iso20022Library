// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [KnownType(typeof(TransactionCollateralData15Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionCollateralData15Choice.BuySellBack))]
    [KnownType(typeof(TransactionCollateralData15Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionCollateralData15Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.RepurchaseTrade),nameof(TransactionCollateralData15Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.BuySellBack),nameof(TransactionCollateralData15Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.SecuritiesLending),nameof(TransactionCollateralData15Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionCollateralData15Choice.MarginLending),nameof(TransactionCollateralData15Choice.MarginLending))]
    #endif
    [IsoId("_fH7CbwAFEeqefbt-QjTNnA")]
    [DisplayName("Transaction Collateral Data 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionCollateralData15Choice_
    #else
    public abstract partial class TransactionCollateralData15Choice_
    #endif
    {
    }
}
