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
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.PendingPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice17Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.MonetaryValue),nameof(SecuritiesTransactionPrice17Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.Unit),nameof(SecuritiesTransactionPrice17Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.Percentage),nameof(SecuritiesTransactionPrice17Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.Yield),nameof(SecuritiesTransactionPrice17Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.Decimal),nameof(SecuritiesTransactionPrice17Choice.Decimal))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.PendingPrice),nameof(SecuritiesTransactionPrice17Choice.PendingPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice17Choice.Other),nameof(SecuritiesTransactionPrice17Choice.Other))]
    #endif
    [IsoId("_gRtSoZjcEeqkLZLH6DK3UQ")]
    [DisplayName("Securities Transaction Price 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice17Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice17Choice_
    #endif
    {
    }
}
