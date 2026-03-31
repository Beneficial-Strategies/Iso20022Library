// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for pending status.
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u_gjQVj1EeOnqqBHs8Gasw")]
[Description(
    @"Specifies the reason for pending status.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalPendingProcessingReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalPendingProcessingReasonCode>))]
#endif
public enum ExternalPendingProcessingReasonCode
{
    /// <summary>
    /// Received after the servicer&apos;s deadline. Processed on best effort basis
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_uVP6RvRYEeuLhpyIdtJzwg")]
    [Description(@"Received after the servicer's deadline. Processed on best effort basis")]
    ServicerDeadlineMissed,

    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_uVZEMPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake"
    )]
    NaturalDisaster,

    /// <summary>
    /// Special follow-up is taking place
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("_uVZEM_RYEeuLhpyIdtJzwg")]
    [Description(@"Special follow-up is taking place")]
    Escalation,

    /// <summary>
    /// Pending reason being investigated
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_uVZENvRYEeuLhpyIdtJzwg")]
    [Description(@"Pending reason being investigated")]
    StatusReasonInvestigation,

    /// <summary>
    /// Longer processing timeframe for this type of SSI
    /// Encoded/decoded by serializers as &quot;LPRO&quot;.
    /// </summary>
    [EnumMember(Value = "LPRO")]
    [IsoId("_uVZEOfRYEeuLhpyIdtJzwg")]
    [Description(@"Longer processing timeframe for this type of SSI")]
    LongerProcessing,

    /// <summary>
    /// Information, for example, currency is missing
    /// Encoded/decoded by serializers as &quot;MINF&quot;.
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_uVi1MPRYEeuLhpyIdtJzwg")]
    [Description(@"Information, for example, currency is missing")]
    MissingInformation,

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("_uVi1M_RYEeuLhpyIdtJzwg")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable")]
    NewIssues,

    /// <summary>
    /// Next process is launched. No processing pending problems to be reported
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_uVi1NvRYEeuLhpyIdtJzwg")]
    [Description(@"Next process is launched. No processing pending problems to be reported")]
    NextProcess,

    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually
    /// Encoded/decoded by serializers as &quot;NSTP&quot;.
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_uVi1OfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction was not straight through processing and had to be processed manually"
    )]
    NotStraightThroughProcessing,

    /// <summary>
    /// Transaction was put on hold/frozen by the system
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("_uVsmMPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction was put on hold/frozen by the system")]
    SystemOnHold,
}
