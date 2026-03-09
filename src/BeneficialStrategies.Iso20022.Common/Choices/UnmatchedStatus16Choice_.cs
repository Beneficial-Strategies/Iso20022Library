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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus16Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedStatus16Choice.NoSpecifiedReason),nameof(UnmatchedStatus16Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus16Choice.Reason),nameof(UnmatchedStatus16Choice.Reason))]
    #endif
    [IsoId("_Hq3ssTqOEeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Status 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus16Choice_
    #else
    public abstract partial class UnmatchedStatus16Choice_
    #endif
    {
    }
}
