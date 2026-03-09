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
    /// Instruction has not been matched.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus22Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus22Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedStatus22Choice.NoSpecifiedReason),nameof(UnmatchedStatus22Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus22Choice.Reason),nameof(UnmatchedStatus22Choice.Reason))]
    #endif
    [IsoId("_TgpI4OCBEei2UYJ62ws-Fw")]
    [DisplayName("Unmatched Status 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus22Choice_
    #else
    public abstract partial class UnmatchedStatus22Choice_
    #endif
    {
    }
}
