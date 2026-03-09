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
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting6Choice.Code))]
    [KnownType(typeof(Reporting6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reporting6Choice.Code),nameof(Reporting6Choice.Code))]
    [JsonDerivedType(typeof(Reporting6Choice.Proprietary),nameof(Reporting6Choice.Proprietary))]
    #endif
    [IsoId("_o9glQTtCEeWRTLSN0i0tng")]
    [DisplayName("Reporting 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reporting6Choice_
    #else
    public abstract partial class Reporting6Choice_
    #endif
    {
    }
}
