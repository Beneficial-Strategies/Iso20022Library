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
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.Decimal))]
    [KnownType(typeof(SecuritiesTransactionPrice20Choice.BasisPointSpread))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionPrice20Choice.MonetaryValue),nameof(SecuritiesTransactionPrice20Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice20Choice.Percentage),nameof(SecuritiesTransactionPrice20Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice20Choice.Decimal),nameof(SecuritiesTransactionPrice20Choice.Decimal))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice20Choice.BasisPointSpread),nameof(SecuritiesTransactionPrice20Choice.BasisPointSpread))]
    #endif
    [IsoId("_IXsu0U2vEe2Ci6HlmBLbDw")]
    [DisplayName("Securities Transaction Price 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice20Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice20Choice_
    #endif
    {
    }
}
