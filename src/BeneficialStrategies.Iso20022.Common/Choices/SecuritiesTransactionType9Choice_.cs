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
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType9Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesTransactionType9Choice.Code),nameof(SecuritiesTransactionType9Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesTransactionType9Choice.Proprietary),nameof(SecuritiesTransactionType9Choice.Proprietary))]
    #endif
    [IsoId("_aJKrQfvlEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType9Choice_
    #else
    public abstract partial class SecuritiesTransactionType9Choice_
    #endif
    {
    }
}
