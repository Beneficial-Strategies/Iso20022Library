// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the legal constraint on the Power of Attorney.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHo8Y9p-Ed-ak6NoX_4Aeg_-563663528")]
[Description(@"Indicates the legal constraint on the Power of Attorney.")]
[DerivedFrom(typeof(PowerOfAttorneyLegalisationCode))]
public enum PowerOfAttorneyLegalisation1Code
{
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a notary.
    /// Encoded/decoded by serializers as &quot;NOTA&quot;.
    /// </summary>
    [EnumMember(Value = "NOTA")]
    [IsoId("_aHo8ZNp-Ed-ak6NoX_4Aeg_-267216404")]
    [Description(@"Indicates that the power of attorney must be legalised by a notary.")]
    Notary = PowerOfAttorneyLegalisationCode.Notary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the power of attorney must be legalised by a local authority.
    /// Encoded/decoded by serializers as &quot;LOCA&quot;.
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aHo8Zdp-Ed-ak6NoX_4Aeg_-254286026")]
    [Description(@"Indicates that the power of attorney must be legalised by a local authority.")]
    LocalAuthority = PowerOfAttorneyLegalisationCode.LocalAuthority, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the power of attorney must be legalised by a legal officer.
    /// Encoded/decoded by serializers as &quot;APOS&quot;.
    /// </summary>
    [EnumMember(Value = "APOS")]
    [IsoId("_aHo8Ztp-Ed-ak6NoX_4Aeg_-239508247")]
    [Description(@"Indicates that the power of attorney must be legalised by a legal officer.")]
    Apostilled = PowerOfAttorneyLegalisationCode.Apostilled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the power of attorney must be legalised by a consular officer.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_aHytYNp-Ed-ak6NoX_4Aeg_-224734417")]
    [Description(@"Indicates that the power of attorney must be legalised by a consular officer.")]
    Consularized = PowerOfAttorneyLegalisationCode.Consularized, // same ordinal as derivation source for type conversions
}
