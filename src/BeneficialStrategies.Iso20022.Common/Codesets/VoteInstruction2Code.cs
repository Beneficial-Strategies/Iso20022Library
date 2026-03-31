// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9IRE9p-Ed-ak6NoX_4Aeg_325588560")]
[Description(@"Identifies the possible types of voting instructions.")]
[DerivedFrom(typeof(VoteInstructionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<VoteInstruction2Code>))]
#endif
public enum VoteInstruction2Code
{
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_Y9IRFNp-Ed-ak6NoX_4Aeg_410553327")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionCode.For, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_Y9IRFdp-Ed-ak6NoX_4Aeg_410553405")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionCode.Against, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_Y9IRFtp-Ed-ak6NoX_4Aeg_410553440")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionCode.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_Y9IRF9p-Ed-ak6NoX_4Aeg_410553465")]
    [Description(
        @"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market)."
    )]
    Withhold = VoteInstructionCode.Withhold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_Y9IRGNp-Ed-ak6NoX_4Aeg_410553500")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement = VoteInstructionCode.WithManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_Y9IRGdp-Ed-ak6NoX_4Aeg_410553777")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement = VoteInstructionCode.AgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_Y9SCENp-Ed-ak6NoX_4Aeg_779135354")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction = VoteInstructionCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voting party is assigned discretionary right to vote for one resolution.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_Y9SCEdp-Ed-ak6NoX_4Aeg_1003228809")]
    [Description(@"Voting party is assigned discretionary right to vote for one resolution.")]
    Discretionary = VoteInstructionCode.Discretionary, // same ordinal as derivation source for type conversions
}
