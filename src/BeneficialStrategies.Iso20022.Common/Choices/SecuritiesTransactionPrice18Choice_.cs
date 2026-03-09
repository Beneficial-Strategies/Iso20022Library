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
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice18Choice.BasisPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice18Choice.MonetaryValue),nameof(SecuritiesTransactionPrice18Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice18Choice.Percentage),nameof(SecuritiesTransactionPrice18Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice18Choice.Decimal),nameof(SecuritiesTransactionPrice18Choice.Decimal))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice18Choice.BasisPoints),nameof(SecuritiesTransactionPrice18Choice.BasisPoints))]
    #endif
    [IsoId("_XQwXoMgpEeuGrNSsxk3B0A")]
    [DisplayName("Securities Transaction Price 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice18Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice18Choice_
    #endif
    {
    }
}
