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
    [KnownType(typeof(SystemEventType3Choice.Code))]
    [KnownType(typeof(SystemEventType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemEventType3Choice.Code),nameof(SystemEventType3Choice.Code))]
    [JsonDerivedType(typeof(SystemEventType3Choice.Proprietary),nameof(SystemEventType3Choice.Proprietary))]
    #endif
    [IsoId("_wCNH48lcEeW3r6pl_9_bpw")]
    [DisplayName("System Event Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemEventType3Choice_
    #else
    public abstract partial class SystemEventType3Choice_
    #endif
    {
    }
}
