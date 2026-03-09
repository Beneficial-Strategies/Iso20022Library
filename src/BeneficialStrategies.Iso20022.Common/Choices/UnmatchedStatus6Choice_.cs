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
    [KnownType(typeof(UnmatchedStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus6Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedStatus6Choice.NoSpecifiedReason),nameof(UnmatchedStatus6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus6Choice.Reason),nameof(UnmatchedStatus6Choice.Reason))]
    #endif
    [IsoId("_EhheBf7ZEeCtrO5qCU90cA")]
    [DisplayName("Unmatched Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus6Choice_
    #else
    public abstract partial class UnmatchedStatus6Choice_
    #endif
    {
    }
}
