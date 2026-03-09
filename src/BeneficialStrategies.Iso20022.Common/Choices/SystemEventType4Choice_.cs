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
    /// Specifies the type of system event.
    /// </summary>
    [KnownType(typeof(SystemEventType4Choice.Code))]
    [KnownType(typeof(SystemEventType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemEventType4Choice.Code),nameof(SystemEventType4Choice.Code))]
    [JsonDerivedType(typeof(SystemEventType4Choice.Proprietary),nameof(SystemEventType4Choice.Proprietary))]
    #endif
    [IsoId("_d7AQEXhkEeidzqjNEfehPg")]
    [DisplayName("System Event Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemEventType4Choice_
    #else
    public abstract partial class SystemEventType4Choice_
    #endif
    {
    }
}
