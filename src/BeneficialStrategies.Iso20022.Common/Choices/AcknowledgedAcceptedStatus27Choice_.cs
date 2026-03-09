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
    [KnownType(typeof(AcknowledgedAcceptedStatus27Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus27Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus27Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus27Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus27Choice.Reason),nameof(AcknowledgedAcceptedStatus27Choice.Reason))]
    #endif
    [IsoId("_6BK6w5NLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledged Accepted Status 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgedAcceptedStatus27Choice_
    #else
    public abstract partial class AcknowledgedAcceptedStatus27Choice_
    #endif
    {
    }
}
