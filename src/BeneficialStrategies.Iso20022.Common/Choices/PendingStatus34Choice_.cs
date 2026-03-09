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
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus34Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus34Choice.NoSpecifiedReason),nameof(PendingStatus34Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus34Choice.Reason),nameof(PendingStatus34Choice.Reason))]
    #endif
    [IsoId("_T9xmsVhbEeSewsfsZR0hxA")]
    [DisplayName("Pending Status 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus34Choice_
    #else
    public abstract partial class PendingStatus34Choice_
    #endif
    {
    }
}
