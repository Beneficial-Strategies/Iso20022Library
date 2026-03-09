// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of the tracker alert notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FJ4ewPrxEemIKt9hrQ9pJw")]
[Description(@"Indicates the status of the tracker alert notification.")]
[Derivations(typeof(TrackerAlertStatus1Code))]
public enum TrackerAlertStatusCode
{
    /// <summary>
    /// Tracker notification is a warning.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_T3e7ofrxEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is a warning.")]
    Warning,
    
    /// <summary>
    /// Tracker notification is related to an invalid update.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_hnu_cfrxEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is related to an invalid update.")]
    Invalid,
    
    /// <summary>
    /// Tracker notification is related to a rejected cancellation request.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_ss0dgfrxEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is related to a rejected cancellation request.")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// Tracker notification is related to a rejected investigation.
    /// Encoded/decoded by serializers as &quot;RJIN&quot;.
    /// </summary>
    [EnumMember(Value = "RJIN")]
    [IsoId("_-XERsPrxEemIKt9hrQ9pJw")]
    [Description(@"Tracker notification is related to a rejected investigation.")]
    RejectedInvestigation,
    
}
