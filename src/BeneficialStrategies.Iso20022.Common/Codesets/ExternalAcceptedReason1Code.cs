// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an accepted status.|
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fNkVgFjqEeOnqqBHs8Gasw")]
[Description(
    @"Specifies the reason for an accepted status.||The list of valid codes is an external code list published separately. |External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalAcceptedReasonCode))]
public enum ExternalAcceptedReason1Code
{
    /// <summary>
    /// Received after the servicer&apos;s deadline. Processed on best effort basis
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_uVGJS_RYEeuLhpyIdtJzwg")]
    [Description(@"Received after the servicer's deadline. Processed on best effort basis")]
    AccountServicerDeadlineMissed = ExternalAcceptedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually
    /// Encoded/decoded by serializers as &quot;NSTP&quot;.
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_uVP6QvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction was not straight through processing and had to be processed manually"
    )]
    NotStraightThroughProcessing = ExternalAcceptedReasonCode.NotStraightThroughProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but does not comply with the market practice rule published for the concerned market or process
    /// Encoded/decoded by serializers as &quot;SMPG&quot;.
    /// </summary>
    [EnumMember(Value = "SMPG")]
    [IsoId("_uVP6RfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Instruction is accepted but does not comply with the market practice rule published for the concerned market or process"
    )]
    MarketPracticeRuleDiscrepency = ExternalAcceptedReasonCode.MarketPracticeRuleDiscrepency, // same ordinal as derivation source for type conversions
}
