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
    [KnownType(typeof(UnmatchedStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus19Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnmatchedStatus19Choice.NoSpecifiedReason),nameof(UnmatchedStatus19Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus19Choice.Reason),nameof(UnmatchedStatus19Choice.Reason))]
    #endif
    [IsoId("_6BH39ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Status 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus19Choice_
    #else
    public abstract partial class UnmatchedStatus19Choice_
    #endif
    {
    }
}
