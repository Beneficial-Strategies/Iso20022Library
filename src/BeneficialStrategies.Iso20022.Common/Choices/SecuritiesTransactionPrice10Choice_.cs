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
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.PendingPrice))]
    [KnownType(typeof(SecuritiesTransactionPrice10Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice10Choice.MonetaryValue),nameof(SecuritiesTransactionPrice10Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice10Choice.Unit),nameof(SecuritiesTransactionPrice10Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice10Choice.Percentage),nameof(SecuritiesTransactionPrice10Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice10Choice.Yield),nameof(SecuritiesTransactionPrice10Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice10Choice.PendingPrice),nameof(SecuritiesTransactionPrice10Choice.PendingPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice10Choice.Other),nameof(SecuritiesTransactionPrice10Choice.Other))]
    #endif
    [IsoId("_QhQ_wf9iEea3W_f2lS_aiw")]
    [DisplayName("Securities Transaction Price 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice10Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice10Choice_
    #endif
    {
    }
}
