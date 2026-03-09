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
    /// Choice of generated status.
    /// </summary>
    [KnownType(typeof(GeneratedStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus7Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GeneratedStatus7Choice.NoSpecifiedReason),nameof(GeneratedStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus7Choice.Reason),nameof(GeneratedStatus7Choice.Reason))]
    #endif
    [IsoId("_O8oP2TqeEeWyoP0PbocV1Q")]
    [DisplayName("Generated Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneratedStatus7Choice_
    #else
    public abstract partial class GeneratedStatus7Choice_
    #endif
    {
    }
}
