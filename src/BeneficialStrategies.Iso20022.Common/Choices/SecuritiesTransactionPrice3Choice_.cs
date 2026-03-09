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
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.Unit))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice3Choice.PendingPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.MonetaryValue),nameof(SecuritiesTransactionPrice3Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.Unit),nameof(SecuritiesTransactionPrice3Choice.Unit))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.Percentage),nameof(SecuritiesTransactionPrice3Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.Yield),nameof(SecuritiesTransactionPrice3Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice3Choice.PendingPrice),nameof(SecuritiesTransactionPrice3Choice.PendingPrice))]
    #endif
    [IsoId("_rS83x0DWEeWOL-OsSq2h6w")]
    [DisplayName("Securities Transaction Price 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice3Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice3Choice_
    #endif
    {
    }
}
