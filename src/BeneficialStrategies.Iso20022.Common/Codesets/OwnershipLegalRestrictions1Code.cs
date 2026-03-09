// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory restrictions applicable to a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxJH9Np-Ed-ak6NoX_4Aeg_1692772034")]
[Description(@"Specifies the regulatory restrictions applicable to a financial instrument.")]
[DerivedFrom(typeof(OwnershipLegalRestrictionsCode))]
public enum OwnershipLegalRestrictions1Code
{
    /// <summary>
    /// Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.
    /// Encoded/decoded by serializers as &quot;A144&quot;.
    /// </summary>
    [EnumMember(Value = "A144")]
    [IsoId("_ZxJH9dp-Ed-ak6NoX_4Aeg_1752799563")]
    [Description(@"Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.")]
    USLegal144A = OwnershipLegalRestrictionsCode.USLegal144A, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ownership or transfer of a security that is not subject to restrictions.
    /// Encoded/decoded by serializers as &quot;NRST&quot;.
    /// </summary>
    [EnumMember(Value = "NRST")]
    [IsoId("_ZxJH9tp-Ed-ak6NoX_4Aeg_1767574892")]
    [Description(@"Ownership or transfer of a security that is not subject to restrictions.")]
    NoRestrictions = OwnershipLegalRestrictionsCode.NoRestrictions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_ZxJH99p-Ed-ak6NoX_4Aeg_1780503706")]
    [Description(@"Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.")]
    Restrictions = OwnershipLegalRestrictionsCode.Restrictions, // same ordinal as derivation source for type conversions
    
}
