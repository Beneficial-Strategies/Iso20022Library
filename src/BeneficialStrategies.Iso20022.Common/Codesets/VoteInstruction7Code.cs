// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JCPdYfNoEeqRfth943bvEA")]
[Description(@"Specifies a type of voting instructions.")]
[DerivedFrom(typeof(VoteInstructionV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<VoteInstruction7Code>))]
#endif
public enum VoteInstruction7Code
{
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_JWnx8fNoEeqRfth943bvEA")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionV2Code.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_JWnx8_NoEeqRfth943bvEA")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionV2Code.Against, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_JWnx9fNoEeqRfth943bvEA")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement = VoteInstructionV2Code.AgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// Encoded/decoded by serializers as &quot;BLNK&quot;.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_JWnx9_NoEeqRfth943bvEA")]
    [Description(@"Vote is cast as empty but the vote is counted.")]
    Blank = VoteInstructionV2Code.Blank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_JWnx_fNoEeqRfth943bvEA")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionV2Code.For, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Do not vote.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_JWnx__NoEeqRfth943bvEA")]
    [Description(@"Do not vote.")]
    NoAction = VoteInstructionV2Code.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for one year for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;ONEY&quot;.
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_JWnyAfNoEeqRfth943bvEA")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear = VoteInstructionV2Code.OneYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for three years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;THRY&quot;.
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_JWnyA_NoEeqRfth943bvEA")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears = VoteInstructionV2Code.ThreeYears, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for two years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;TWOY&quot;.
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_JWnyBfNoEeqRfth943bvEA")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears = VoteInstructionV2Code.TwoYears, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_JWnyB_NoEeqRfth943bvEA")]
    [Description(
        @"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market)."
    )]
    Withhold = VoteInstructionV2Code.Withhold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_JWnyCfNoEeqRfth943bvEA")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement = VoteInstructionV2Code.WithManagement, // same ordinal as derivation source for type conversions
}
