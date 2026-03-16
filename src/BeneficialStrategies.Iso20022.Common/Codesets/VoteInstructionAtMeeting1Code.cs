// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible types of voting instructions for resolutions proposed at the meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9SCEtp-Ed-ak6NoX_4Aeg_1245010903")]
[Description(
    @"Identifies the possible types of voting instructions for resolutions proposed at the meeting."
)]
[DerivedFrom(typeof(VoteInstructionCode))]
public enum VoteInstructionAtMeeting1Code
{
    /// <summary>
    /// Specifies that the rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_Y9SCE9p-Ed-ak6NoX_4Aeg_1321663953")]
    [Description(
        @"Specifies that the rights holder gives authority to the chairman to vote on his behalf."
    )]
    Chairman = VoteInstructionCode.Chairman, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_Y9SCFNp-Ed-ak6NoX_4Aeg_1335514985")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionCode.Against, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_Y9SCFdp-Ed-ak6NoX_4Aeg_-763128771")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionCode.For, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_Y9SCFtp-Ed-ak6NoX_4Aeg_-757587664")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionCode.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_Y9SCF9p-Ed-ak6NoX_4Aeg_-491614947")]
    [Description(
        @"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market)."
    )]
    Withhold = VoteInstructionCode.Withhold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_Y9SCGNp-Ed-ak6NoX_4Aeg_-488842589")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement = VoteInstructionCode.WithManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_Y9SCGdp-Ed-ak6NoX_4Aeg_-477763253")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement = VoteInstructionCode.AgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_Y9bzENp-Ed-ak6NoX_4Aeg_-473145659")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction = VoteInstructionCode.NoAction, // same ordinal as derivation source for type conversions
}
