// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ucc-cF69EeSjaerr_EM7AQ")]
[Description(@"Specifies the possible types of voting instructions.")]
[DerivedFrom(typeof(VoteInstructionCode))]
public enum VoteInstruction3Code
{
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_8Cq8gV69EeSjaerr_EM7AQ")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionCode.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_8IxkgV69EeSjaerr_EM7AQ")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionCode.Against, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_8Pw9UV69EeSjaerr_EM7AQ")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement = VoteInstructionCode.AgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voting party is assigned discretionary right to vote for one resolution.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_-kjDYV69EeSjaerr_EM7AQ")]
    [Description(@"Voting party is assigned discretionary right to vote for one resolution.")]
    Discretionary = VoteInstructionCode.Discretionary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_-sSDEV69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionCode.For, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_-y1XAV69EeSjaerr_EM7AQ")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction = VoteInstructionCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("__8LksV69EeSjaerr_EM7AQ")]
    [Description(
        @"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market)."
    )]
    Withhold = VoteInstructionCode.Withhold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_ABrvwV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement = VoteInstructionCode.WithManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for one year for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;ONEY&quot;.
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_AP0SYV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear = VoteInstructionCode.OneYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for three years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;THRY&quot;.
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_AVVEgV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears = VoteInstructionCode.ThreeYears, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for two years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;TWOY&quot;.
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_AbR7gV6-EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears = VoteInstructionCode.TwoYears, // same ordinal as derivation source for type conversions
}
