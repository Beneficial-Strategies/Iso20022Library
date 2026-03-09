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
    /// Settlement details to determine whether payment is a credit or debit.
    /// </summary>
    [KnownType(typeof(SettlementMethod4Choice.Credit))]
    [KnownType(typeof(SettlementMethod4Choice.Debit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementMethod4Choice.Credit),nameof(SettlementMethod4Choice.Credit))]
    [JsonDerivedType(typeof(SettlementMethod4Choice.Debit),nameof(SettlementMethod4Choice.Debit))]
    #endif
    [IsoId("_dWm-h9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Method 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementMethod4Choice_
    #else
    public abstract partial class SettlementMethod4Choice_
    #endif
    {
    }
}
