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
    /// Status of a system and the period of time during which the status is valid.
    /// </summary>
    [KnownType(typeof(SystemStatus2Choice.Code))]
    [KnownType(typeof(SystemStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemStatus2Choice.Code),nameof(SystemStatus2Choice.Code))]
    [JsonDerivedType(typeof(SystemStatus2Choice.Proprietary),nameof(SystemStatus2Choice.Proprietary))]
    #endif
    [IsoId("_yUPGYRbpEeOy-PlRuFSUzQ")]
    [DisplayName("System Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemStatus2Choice_
    #else
    public abstract partial class SystemStatus2Choice_
    #endif
    {
    }
}
