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
    [KnownType(typeof(PendingStatus51Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus51Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus51Choice.NoSpecifiedReason),nameof(PendingStatus51Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus51Choice.Reason),nameof(PendingStatus51Choice.Reason))]
    #endif
    [IsoId("_6QDsBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus51Choice_
    #else
    public abstract partial class PendingStatus51Choice_
    #endif
    {
    }
}
