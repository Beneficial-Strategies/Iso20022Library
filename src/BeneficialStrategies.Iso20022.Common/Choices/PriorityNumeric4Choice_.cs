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
    /// Choice of format for the priority.
    /// </summary>
    [KnownType(typeof(PriorityNumeric4Choice.Numeric))]
    [KnownType(typeof(PriorityNumeric4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriorityNumeric4Choice.Numeric),nameof(PriorityNumeric4Choice.Numeric))]
    [JsonDerivedType(typeof(PriorityNumeric4Choice.Proprietary),nameof(PriorityNumeric4Choice.Proprietary))]
    #endif
    [IsoId("_rhERsTtDEeWRTLSN0i0tng")]
    [DisplayName("Priority Numeric 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriorityNumeric4Choice_
    #else
    public abstract partial class PriorityNumeric4Choice_
    #endif
    {
    }
}
