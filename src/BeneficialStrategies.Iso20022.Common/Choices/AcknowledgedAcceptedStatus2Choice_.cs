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
    [KnownType(typeof(AcknowledgedAcceptedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus2Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus2Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus2Choice.Reason),nameof(AcknowledgedAcceptedStatus2Choice.Reason))]
    #endif
    [IsoId("_UWYvcNp-Ed-ak6NoX_4Aeg_1912312217")]
    [DisplayName("Acknowledged Accepted Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgedAcceptedStatus2Choice_
    #else
    public abstract partial class AcknowledgedAcceptedStatus2Choice_
    #endif
    {
    }
}
