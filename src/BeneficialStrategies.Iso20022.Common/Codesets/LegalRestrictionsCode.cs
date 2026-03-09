// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory restrictions applicable to a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad_m49p-Ed-ak6NoX_4Aeg_-636020179")]
[Description(@"Specifies the regulatory restrictions applicable to a security.")]
[Derivations(typeof(LegalRestrictions2Code),typeof(LegalRestrictions1Code))]
public enum LegalRestrictionsCode
{
    /// <summary>
    /// Investors outside this jurisdiction can purchase this security, for example, a Reg S security can only be held by an investor outside the US.
    /// Encoded/decoded by serializers as &quot;JURO&quot;.
    /// </summary>
    [EnumMember(Value = "JURO")]
    [IsoId("_ad_m5Np-Ed-ak6NoX_4Aeg_279190604")]
    [Description(@"Investors outside this jurisdiction can purchase this security, for example, a Reg S security can only be held by an investor outside the US.")]
    JurisdictionOwnership,
    
    /// <summary>
    /// Only investors qualified by the issuer in this jurisdiction may purchase this security.
    /// Encoded/decoded by serializers as &quot;PPLA&quot;.
    /// </summary>
    [EnumMember(Value = "PPLA")]
    [IsoId("_ad_m5dp-Ed-ak6NoX_4Aeg_280114072")]
    [Description(@"Only investors qualified by the issuer in this jurisdiction may purchase this security.")]
    PrivatePlacements,
    
    /// <summary>
    /// Only investors qualified by the regulator in this jurisdiction may purchase this security.
    /// Encoded/decoded by serializers as &quot;ACRI&quot;.
    /// </summary>
    [EnumMember(Value = "ACRI")]
    [IsoId("_ad_m5tp-Ed-ak6NoX_4Aeg_281037100")]
    [Description(@"Only investors qualified by the regulator in this jurisdiction may purchase this security.")]
    AccreditedInvestor,
    
    /// <summary>
    /// Issuer defines whether the security may be purchased with borrowed money (US and Japan).
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_ad_m59p-Ed-ak6NoX_4Aeg_281959788")]
    [Description(@"Issuer defines whether the security may be purchased with borrowed money (US and Japan).")]
    Margin,
    
    /// <summary>
    /// Privileges, for example, voting rights, of holding the security may be restricted by the issuer.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_ad_m6Np-Ed-ak6NoX_4Aeg_290270931")]
    [Description(@"Privileges, for example, voting rights, of holding the security may be restricted by the issuer.")]
    Privilege,
    
    /// <summary>
    /// Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.
    /// Encoded/decoded by serializers as &quot;USLE&quot;.
    /// </summary>
    [EnumMember(Value = "USLE")]
    [IsoId("_ad_m4Np-Ed-ak6NoX_4Aeg_-481845170")]
    [Description(@"Ownership or transfer of an unregistered security issued, pursuant to US legal restrictions 144A.")]
    USLegal144A,
    
    /// <summary>
    /// Ownership or transfer of a security that is not subject to restrictions.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_ad_m4dp-Ed-ak6NoX_4Aeg_-234340490")]
    [Description(@"Ownership or transfer of a security that is not subject to restrictions.")]
    NoRestrictions,
    
    /// <summary>
    /// Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ad_m4tp-Ed-ak6NoX_4Aeg_-807581200")]
    [Description(@"Ownership or transfer of a security that is subject to restrictions, and not pursuant to 144A.")]
    Restrictions,
    
}
