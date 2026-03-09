// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y8_HJNp-Ed-ak6NoX_4Aeg_1903524744")]
[Description(@"Identifies the possible types of voting instructions.")]
[DerivedFrom(typeof(VoteInstructionCode))]
public enum VoteInstruction1Code
{
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_Y8_HJdp-Ed-ak6NoX_4Aeg_959674352")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For = VoteInstructionCode.For, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_Y8_HJtp-Ed-ak6NoX_4Aeg_959674370")]
    [Description(@"Vote against a meeting resolution.")]
    Against = VoteInstructionCode.Against, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_Y9IRENp-Ed-ak6NoX_4Aeg_959674395")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain = VoteInstructionCode.Abstain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_Y9IREdp-Ed-ak6NoX_4Aeg_959674412")]
    [Description(@"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).")]
    Withhold = VoteInstructionCode.Withhold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_Y9IREtp-Ed-ak6NoX_4Aeg_1574523341")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction = VoteInstructionCode.NoAction, // same ordinal as derivation source for type conversions
    
}
