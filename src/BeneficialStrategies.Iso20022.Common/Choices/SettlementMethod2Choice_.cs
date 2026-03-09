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
    [KnownType(typeof(SettlementMethod2Choice.Credit))]
    [KnownType(typeof(SettlementMethod2Choice.Debit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementMethod2Choice.Credit),nameof(SettlementMethod2Choice.Credit))]
    [JsonDerivedType(typeof(SettlementMethod2Choice.Debit),nameof(SettlementMethod2Choice.Debit))]
    #endif
    [IsoId("_68jSJ248EeiU9cctagi5ow")]
    [DisplayName("Settlement Method 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementMethod2Choice_
    #else
    public abstract partial class SettlementMethod2Choice_
    #endif
    {
    }
}
