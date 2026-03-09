// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the submitted data set must be matched or pre-matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aYn-uNp-Ed-ak6NoX_4Aeg_-1349456912")]
[Description(@"Specifies whether the submitted data set must be matched or pre-matched.")]
[DerivedFrom(typeof(InstructionTypeCode))]
public enum InstructionType3Code
{
    /// <summary>
    /// Instruction to match a data set.
    /// Encoded/decoded by serializers as &quot;MTCH&quot;.
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_aYxvsNp-Ed-ak6NoX_4Aeg_-1294968773")]
    [Description(@"Instruction to match a data set.")]
    Match = InstructionTypeCode.Match, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction to pre-match a data set.
    /// Encoded/decoded by serializers as &quot;PMTC&quot;.
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_aYxvsdp-Ed-ak6NoX_4Aeg_-1294968370")]
    [Description(@"Instruction to pre-match a data set.")]
    PreMatch = InstructionTypeCode.PreMatch, // same ordinal as derivation source for type conversions
    
}
