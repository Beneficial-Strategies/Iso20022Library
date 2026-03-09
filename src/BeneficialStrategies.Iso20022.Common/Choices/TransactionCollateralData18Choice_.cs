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
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [KnownType(typeof(TransactionCollateralData18Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionCollateralData18Choice.BuySellBack))]
    [KnownType(typeof(TransactionCollateralData18Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionCollateralData18Choice.MarginLending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.RepurchaseTrade),nameof(TransactionCollateralData18Choice.RepurchaseTrade))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.BuySellBack),nameof(TransactionCollateralData18Choice.BuySellBack))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.SecuritiesLending),nameof(TransactionCollateralData18Choice.SecuritiesLending))]
    [JsonDerivedType(typeof(TransactionCollateralData18Choice.MarginLending),nameof(TransactionCollateralData18Choice.MarginLending))]
    #endif
    [IsoId("_C5KZIcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Transaction Collateral Data 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionCollateralData18Choice_
    #else
    public abstract partial class TransactionCollateralData18Choice_
    #endif
    {
    }
}
