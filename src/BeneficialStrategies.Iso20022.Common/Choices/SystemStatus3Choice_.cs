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
    [KnownType(typeof(SystemStatus3Choice.Code))]
    [KnownType(typeof(SystemStatus3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemStatus3Choice.Code),nameof(SystemStatus3Choice.Code))]
    [JsonDerivedType(typeof(SystemStatus3Choice.Proprietary),nameof(SystemStatus3Choice.Proprietary))]
    #endif
    [IsoId("_1Y_TsYpbEeiaB-4Hjqs8aw")]
    [DisplayName("System Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemStatus3Choice_
    #else
    public abstract partial class SystemStatus3Choice_
    #endif
    {
    }
}
