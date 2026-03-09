// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory restrictions applicable to a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad1159p-Ed-ak6NoX_4Aeg_-752434714")]
[Description(@"Specifies the regulatory restrictions applicable to a security.")]
[DerivedFrom(typeof(LegalRestrictionsCode))]
public enum LegalRestrictions1Code
{
    /// <summary>
    /// Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.
    /// Encoded/decoded by serializers as &quot;USLE&quot;.
    /// </summary>
    [EnumMember(Value = "USLE")]
    [IsoId("_ad_m4Np-Ed-ak6NoX_4Aeg_-481845169")]
    [Description(@"Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.")]
    USLegal144A = LegalRestrictionsCode.USLegal144A, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ownership or transfer of a security that is not subject to restrictions.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_ad_m4dp-Ed-ak6NoX_4Aeg_-234340489")]
    [Description(@"Ownership or transfer of a security that is not subject to restrictions.")]
    NoRestrictions = LegalRestrictionsCode.NoRestrictions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ad_m4tp-Ed-ak6NoX_4Aeg_-8075812")]
    [Description(@"Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.")]
    Restrictions = LegalRestrictionsCode.Restrictions, // same ordinal as derivation source for type conversions
    
}
