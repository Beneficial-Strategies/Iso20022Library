// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BhhR0P4vEeClUvPNHKL9Zw")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason27Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_BhhR1v4vEeClUvPNHKL9Zw")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_BhhR2v4vEeClUvPNHKL9Zw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_BhhR3v4vEeClUvPNHKL9Zw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_BhhR4v4vEeClUvPNHKL9Zw")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_BhhR5v4vEeClUvPNHKL9Zw")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV2Code.NotFoundRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BhhR6v4vEeClUvPNHKL9Zw")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_BhhR7v4vEeClUvPNHKL9Zw")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as &quot;INVM&quot;.
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_xwRr_v8FEeCCq-oUcJbFqw")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest = RejectionReasonV2Code.InvalidModificationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as &quot;INVL&quot;.
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_yNLqbv8FEeCCq-oUcJbFqw")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink = RejectionReasonV2Code.InvalidLink, // same ordinal as derivation source for type conversions
}
