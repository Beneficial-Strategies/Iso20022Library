// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of voting instruction that can be part of a recommendation to vote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Q1QEK4ZEemG7MmivSuE5g")]
[Description(@"Specifies a type of voting instruction that can be part of a recommendation to vote.")]
[DerivedFrom(typeof(VoteInstructionV2Code))]
public enum VoteInstruction5Code
{
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_aWN4Ia4aEemG7MmivSuE5g")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionV2Code.Abstain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_ahq6Mq4aEemG7MmivSuE5g")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionV2Code.Against, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_bHm40q4aEemG7MmivSuE5g")]
    [Description(@"Rights holder gives authority to the chairman to vote on his behalf.")]
    Chairman = VoteInstructionV2Code.Chairman, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_b0PVUq4aEemG7MmivSuE5g")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionV2Code.For, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Do not vote.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_cTe2Eq4aEemG7MmivSuE5g")]
    [Description(@"Do not vote.")]
    NoAction = VoteInstructionV2Code.NoAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_dLkUoq4aEemG7MmivSuE5g")]
    [Description(@"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).")]
    Withhold = VoteInstructionV2Code.Withhold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour for one year for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;ONEY&quot;.
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_d198gq4aEemG7MmivSuE5g")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear = VoteInstructionV2Code.OneYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour for three years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;THRY&quot;.
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_eAYcwq4aEemG7MmivSuE5g")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears = VoteInstructionV2Code.ThreeYears, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote in favour for two years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;TWOY&quot;.
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_eE2GAa4aEemG7MmivSuE5g")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears = VoteInstructionV2Code.TwoYears, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// Encoded/decoded by serializers as &quot;BLNK&quot;.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_fApm8q4aEemG7MmivSuE5g")]
    [Description(@"Vote is cast as empty but the vote is counted.")]
    Blank = VoteInstructionV2Code.Blank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No recommendation provided for the vote instruction type.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_5gPEIa4aEemG7MmivSuE5g")]
    [Description(@"No recommendation provided for the vote instruction type.")]
    NoRecommendation = VoteInstructionV2Code.NoRecommendation, // same ordinal as derivation source for type conversions
    
}
