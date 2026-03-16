// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the rate is fixed or variable or a forfeit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZJetNp-Ed-ak6NoX_4Aeg_528600131")]
[Description(@"Specifies whether the rate is fixed or variable or a forfeit.")]
[DerivedFrom(typeof(InterestRateTypeCode))]
public enum RateType1Code
{
    /// <summary>
    /// Rate is fixed.
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_ZZJetdp-Ed-ak6NoX_4Aeg_570159113")]
    [Description(@"Rate is fixed.")]
    Fixed = InterestRateTypeCode.Fixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No specific repurchase rate applies to the transaction Repo, only a forfeit.
    /// Encoded/decoded by serializers as &quot;FORF&quot;.
    /// </summary>
    [EnumMember(Value = "FORF")]
    [IsoId("_ZZJettp-Ed-ak6NoX_4Aeg_570159130")]
    [Description(@"No specific repurchase rate applies to the transaction Repo, only a forfeit.")]
    Forfeit = InterestRateTypeCode.Forfeit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is variable.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_ZZJet9p-Ed-ak6NoX_4Aeg_570159131")]
    [Description(@"Rate is variable.")]
    Variable = InterestRateTypeCode.Variable, // same ordinal as derivation source for type conversions
}
