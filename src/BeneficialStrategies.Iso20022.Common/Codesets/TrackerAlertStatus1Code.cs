// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of the tracker alert notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FVgqgPryEemIKt9hrQ9pJw")]
[Description(@"Indicates the status of the tracker alert notification.")]
[DerivedFrom(typeof(TrackerAlertStatusCode))]
public enum TrackerAlertStatus1Code
{
    /// <summary>
    /// Tracker notification is related to an invalid update.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_QEn4kfryEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is related to an invalid update.")]
    Invalid = TrackerAlertStatusCode.Invalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracker notification is related to a rejected cancellation request.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_QK5fsfryEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is related to a rejected cancellation request.")]
    RejectedCancellationRequest = TrackerAlertStatusCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracker notification is related to a rejected investigation.
    /// Encoded/decoded by serializers as &quot;RJIN&quot;.
    /// </summary>
    [EnumMember(Value = "RJIN")]
    [IsoId("_QQH98fryEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is related to a rejected investigation.")]
    RejectedInvestigation = TrackerAlertStatusCode.RejectedInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracker notification is a warning.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_QV510fryEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is a warning.")]
    Warning = TrackerAlertStatusCode.Warning, // same ordinal as derivation source for type conversions
    
}
