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
    [KnownType(typeof(TransactionCollateralData14Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionCollateralData14Choice.BuySellBack))]
    [KnownType(typeof(TransactionCollateralData14Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionCollateralData14Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.RepurchaseTrade),nameof(TransactionCollateralData14Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.BuySellBack),nameof(TransactionCollateralData14Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.SecuritiesLending),nameof(TransactionCollateralData14Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionCollateralData14Choice.MarginLending),nameof(TransactionCollateralData14Choice.MarginLending))]
    #endif
    [IsoId("_ksszMf_9Eemefbt-QjTNnA")]
    [DisplayName("Transaction Collateral Data 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionCollateralData14Choice_
    #else
    public abstract partial class TransactionCollateralData14Choice_
    #endif
    {
    }
}
