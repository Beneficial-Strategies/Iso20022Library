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
    /// Suspended status reason.
    /// </summary>
    [KnownType(typeof(SuspendedStatusReasonChoice.Reason))]
    [KnownType(typeof(SuspendedStatusReasonChoice.Proprietary))]
    [KnownType(typeof(SuspendedStatusReasonChoice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SuspendedStatusReasonChoice.Reason),nameof(SuspendedStatusReasonChoice.Reason))]
    [JsonDerivedType(typeof(SuspendedStatusReasonChoice.Proprietary),nameof(SuspendedStatusReasonChoice.Proprietary))]
    [JsonDerivedType(typeof(SuspendedStatusReasonChoice.NoSpecifiedReason),nameof(SuspendedStatusReasonChoice.NoSpecifiedReason))]
    #endif
    [IsoId("_RfGZSdp-Ed-ak6NoX_4Aeg_1537280901")]
    [DisplayName("Suspended Status Reason Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SuspendedStatusReasonChoice_
    #else
    public abstract partial class SuspendedStatusReasonChoice_
    #endif
    {
    }
}
