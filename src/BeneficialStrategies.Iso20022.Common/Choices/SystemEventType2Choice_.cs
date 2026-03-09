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
    [KnownType(typeof(SystemEventType2Choice.Code))]
    [KnownType(typeof(SystemEventType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemEventType2Choice.Code),nameof(SystemEventType2Choice.Code))]
    [JsonDerivedType(typeof(SystemEventType2Choice.Proprietary),nameof(SystemEventType2Choice.Proprietary))]
    #endif
    [IsoId("_717nF6MgEeCJ6YNENx4h-w_-1478283975")]
    [DisplayName("System Event Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemEventType2Choice_
    #else
    public abstract partial class SystemEventType2Choice_
    #endif
    {
    }
}
