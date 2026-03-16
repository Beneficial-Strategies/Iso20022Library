// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the investor profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t6X6sCDREeWCLu74WLgP4w")]
[Description(@"Specifies the status of the investor profile.")]
[DerivedFrom(typeof(InvestorProfileStatusCode))]
public enum InvestorProfileStatus1Code
{
    /// <summary>
    /// Status of the investor profile is disabled.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_vl8EoSDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is disabled.")]
    Disabled = InvestorProfileStatusCode.Disabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is in the process of being disabled.
    /// Encoded/decoded by serializers as &quot;DISG&quot;.
    /// </summary>
    [EnumMember(Value = "DISG")]
    [IsoId("_vt9_QSDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in the process of being disabled.")]
    Disabling = InvestorProfileStatusCode.Disabling, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is enabled.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_v2cl0SDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is enabled.")]
    Enabled = InvestorProfileStatusCode.Enabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is in the process of being enabled.
    /// Encoded/decoded by serializers as &quot;ENBG&quot;.
    /// </summary>
    [EnumMember(Value = "ENBG")]
    [IsoId("_v-yCcSDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in the process of being enabled.")]
    Enabling = InvestorProfileStatusCode.Enabling, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is in admission.
    /// Encoded/decoded by serializers as &quot;ADMI&quot;.
    /// </summary>
    [EnumMember(Value = "ADMI")]
    [IsoId("_wBms8SDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in admission.")]
    InAdmission = InvestorProfileStatusCode.InAdmission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is in analysis.
    /// Encoded/decoded by serializers as &quot;ANLY&quot;.
    /// </summary>
    [EnumMember(Value = "ANLY")]
    [IsoId("_wJ8JkSDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in analysis.")]
    InAnalysis = InvestorProfileStatusCode.InAnalysis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is not approved.
    /// Encoded/decoded by serializers as &quot;NAPP&quot;.
    /// </summary>
    [EnumMember(Value = "NAPP")]
    [IsoId("_wTBNESDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is not approved.")]
    NotApproved = InvestorProfileStatusCode.NotApproved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is partially suspended.
    /// Encoded/decoded by serializers as &quot;PSUS&quot;.
    /// </summary>
    [EnumMember(Value = "PSUS")]
    [IsoId("_wV13kSDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is partially suspended.")]
    PartiallySuspended = InvestorProfileStatusCode.PartiallySuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is pending approval.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_wd3yMSDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is pending approval.")]
    PendingApproval = InvestorProfileStatusCode.PendingApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the investor profile is suspended.
    /// Encoded/decoded by serializers as &quot;SUPS&quot;.
    /// </summary>
    [EnumMember(Value = "SUPS")]
    [IsoId("_wl6T4SDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is suspended.")]
    Suspended = InvestorProfileStatusCode.Suspended, // same ordinal as derivation source for type conversions
}
