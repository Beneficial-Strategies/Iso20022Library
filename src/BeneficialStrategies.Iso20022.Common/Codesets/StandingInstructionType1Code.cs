// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPw5NNp-Ed-ak6NoX_4Aeg_-471538083")]
[Description(@"Specifies the type of standing instruction.")]
[DerivedFrom(typeof(StandingInstructionTypeCode))]
public enum StandingInstructionType1Code
{
    /// <summary>
    /// Standing instruction for a cash distribution.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZPw5Ndp-Ed-ak6NoX_4Aeg_-438291265")]
    [Description(@"Standing instruction for a cash distribution.")]
    CashDistribution = StandingInstructionTypeCode.CashDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing instruction for the payment modality, gross or net.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_ZPw5Ntp-Ed-ak6NoX_4Aeg_-200022240")]
    [Description(@"Standing instruction for the payment modality, gross or net.")]
    GrossNet = StandingInstructionTypeCode.GrossNet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing instruction for a securities distribution.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZPw5N9p-Ed-ak6NoX_4Aeg_1211066353")]
    [Description(@"Standing instruction for a securities distribution.")]
    SecuritiesDistribution = StandingInstructionTypeCode.SecuritiesDistribution, // same ordinal as derivation source for type conversions
}
