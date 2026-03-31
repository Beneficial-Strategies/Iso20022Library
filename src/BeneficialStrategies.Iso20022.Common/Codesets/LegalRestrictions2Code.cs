// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory restrictions applicable to a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_haryvWliEeGaMcKyqKNRfQ_-1818058448")]
[Description(@"Specifies the regulatory restrictions applicable to a security.")]
[DerivedFrom(typeof(LegalRestrictionsCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LegalRestrictions2Code>))]
#endif
public enum LegalRestrictions2Code
{
    /// <summary>
    /// Investors outside this jurisdiction can purchase this security, for example, a Reg S security can only be held by an investor outside the US.
    /// Encoded/decoded by serializers as &quot;JURO&quot;.
    /// </summary>
    [EnumMember(Value = "JURO")]
    [IsoId("_haryvmliEeGaMcKyqKNRfQ_-1957716437")]
    [Description(
        @"Investors outside this jurisdiction can purchase this security, for example, a Reg S security can only be held by an investor outside the US."
    )]
    JurisdictionOwnership = LegalRestrictionsCode.JurisdictionOwnership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Only investors qualified by the issuer in this jurisdiction may purchase this security.
    /// Encoded/decoded by serializers as &quot;PPLA&quot;.
    /// </summary>
    [EnumMember(Value = "PPLA")]
    [IsoId("_haryv2liEeGaMcKyqKNRfQ_-599905481")]
    [Description(
        @"Only investors qualified by the issuer in this jurisdiction may purchase this security."
    )]
    PrivatePlacements = LegalRestrictionsCode.PrivatePlacements, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Only investors qualified by the regulator in this jurisdiction may purchase this security.
    /// Encoded/decoded by serializers as &quot;ACRI&quot;.
    /// </summary>
    [EnumMember(Value = "ACRI")]
    [IsoId("_harywGliEeGaMcKyqKNRfQ_867243282")]
    [Description(
        @"Only investors qualified by the regulator in this jurisdiction may purchase this security."
    )]
    AccreditedInvestor = LegalRestrictionsCode.AccreditedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer defines whether the security may be purchased with borrowed money (US and Japan).
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_harywWliEeGaMcKyqKNRfQ_1851192826")]
    [Description(
        @"Issuer defines whether the security may be purchased with borrowed money (US and Japan)."
    )]
    Margin = LegalRestrictionsCode.Margin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Privileges, for example, voting rights, of holding the security may be restricted by the issuer.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_harywmliEeGaMcKyqKNRfQ_-976625707")]
    [Description(
        @"Privileges, for example, voting rights, of holding the security may be restricted by the issuer."
    )]
    Privilege = LegalRestrictionsCode.Privilege, // same ordinal as derivation source for type conversions
}
