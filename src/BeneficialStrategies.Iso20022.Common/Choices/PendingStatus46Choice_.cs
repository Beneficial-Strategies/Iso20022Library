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
    [KnownType(typeof(PendingStatus46Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus46Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus46Choice.NoSpecifiedReason),nameof(PendingStatus46Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus46Choice.Reason),nameof(PendingStatus46Choice.Reason))]
    #endif
    [IsoId("_6BE0fZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus46Choice_
    #else
    public abstract partial class PendingStatus46Choice_
    #endif
    {
    }
}
