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
    /// Specifies the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.PendingPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice19Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.MonetaryValue),nameof(SecuritiesTransactionPrice19Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Unit),nameof(SecuritiesTransactionPrice19Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Percentage),nameof(SecuritiesTransactionPrice19Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Yield),nameof(SecuritiesTransactionPrice19Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Decimal),nameof(SecuritiesTransactionPrice19Choice.Decimal))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.PendingPrice),nameof(SecuritiesTransactionPrice19Choice.PendingPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice19Choice.Other),nameof(SecuritiesTransactionPrice19Choice.Other))]
    #endif
    [IsoId("_P98b4MgqEeuGrNSsxk3B0A")]
    [DisplayName("Securities Transaction Price 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice19Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice19Choice_
    #endif
    {
    }
}
