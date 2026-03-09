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
    [KnownType(typeof(GeneratedStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus8Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GeneratedStatus8Choice.NoSpecifiedReason),nameof(GeneratedStatus8Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus8Choice.Reason),nameof(GeneratedStatus8Choice.Reason))]
    #endif
    [IsoId("_8VJvzZNLEeWGlc8L7oPDIg")]
    [DisplayName("Generated Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneratedStatus8Choice_
    #else
    public abstract partial class GeneratedStatus8Choice_
    #endif
    {
    }
}
