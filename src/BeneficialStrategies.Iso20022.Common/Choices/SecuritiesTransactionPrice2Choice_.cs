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
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice2Choice.BasisPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.MonetaryValue),nameof(SecuritiesTransactionPrice2Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.Percentage),nameof(SecuritiesTransactionPrice2Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.Yield),nameof(SecuritiesTransactionPrice2Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice2Choice.BasisPoints),nameof(SecuritiesTransactionPrice2Choice.BasisPoints))]
    #endif
    [IsoId("_xZe0tiZJEeWbypuCUIOnzw")]
    [DisplayName("Securities Transaction Price 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice2Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice2Choice_
    #endif
    {
    }
}
