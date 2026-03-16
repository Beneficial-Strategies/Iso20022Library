// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wxlXIK4IEemG7MmivSuE5g")]
[Description(@"Specifies a type of voting instructions.")]
[DerivedFrom(typeof(VoteInstructionV2Code))]
public enum VoteInstruction6Code
{
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_1fAIga4IEemG7MmivSuE5g")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionV2Code.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_1kgTka4IEemG7MmivSuE5g")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionV2Code.Against, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_2B9roa4IEemG7MmivSuE5g")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement = VoteInstructionV2Code.AgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// Encoded/decoded by serializers as &quot;BLNK&quot;.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_2HK7wa4IEemG7MmivSuE5g")]
    [Description(@"Vote is cast as empty but the vote is counted.")]
    Blank = VoteInstructionV2Code.Blank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_2PDFYq4IEemG7MmivSuE5g")]
    [Description(@"Rights holder gives authority to the chairman to vote on his behalf.")]
    Chairman = VoteInstructionV2Code.Chairman, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voting party is assigned discretionary right to vote for one resolution.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_2RbrAa4IEemG7MmivSuE5g")]
    [Description(@"Voting party is assigned discretionary right to vote for one resolution.")]
    Discretionary = VoteInstructionV2Code.Discretionary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_2T9aka4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionV2Code.For, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Do not vote.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_2W72Ea4IEemG7MmivSuE5g")]
    [Description(@"Do not vote.")]
    NoAction = VoteInstructionV2Code.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for one year for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;ONEY&quot;.
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_2bsaQa4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear = VoteInstructionV2Code.OneYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for three years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;THRY&quot;.
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_2i_VEa4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears = VoteInstructionV2Code.ThreeYears, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote in favour for two years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;TWOY&quot;.
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_2nv5Qa4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears = VoteInstructionV2Code.TwoYears, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_2s9JYa4IEemG7MmivSuE5g")]
    [Description(
        @"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market)."
    )]
    Withhold = VoteInstructionV2Code.Withhold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_22oCwq4IEemG7MmivSuE5g")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement = VoteInstructionV2Code.WithManagement, // same ordinal as derivation source for type conversions
}
