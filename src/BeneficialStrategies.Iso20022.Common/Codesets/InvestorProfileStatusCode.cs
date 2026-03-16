// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the investor profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1CAzICDOEeWPMvNwVtiMsA")]
[Description(@"Specifies the status of the investor profile.")]
[Derivations(typeof(InvestorProfileStatus1Code))]
public enum InvestorProfileStatusCode
{
    /// <summary>
    /// Status of the investor profile is in analysis.
    /// Encoded/decoded by serializers as &quot;ANLY&quot;.
    /// </summary>
    [EnumMember(Value = "ANLY")]
    [IsoId("_ibDNICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in analysis.")]
    InAnalysis,

    /// <summary>
    /// Status of the investor profile is pending approval.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_r8u-wCDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is pending approval.")]
    PendingApproval,

    /// <summary>
    /// Status of the investor profile is not approved.
    /// Encoded/decoded by serializers as &quot;NAPP&quot;.
    /// </summary>
    [EnumMember(Value = "NAPP")]
    [IsoId("_xjS-oCDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is not approved.")]
    NotApproved,

    /// <summary>
    /// Status of the investor profile is in admission.
    /// Encoded/decoded by serializers as &quot;ADMI&quot;.
    /// </summary>
    [EnumMember(Value = "ADMI")]
    [IsoId("_2_lBICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in admission.")]
    InAdmission,

    /// <summary>
    /// Status of the investor profile is in the process of being enabled.
    /// Encoded/decoded by serializers as &quot;ENBG&quot;.
    /// </summary>
    [EnumMember(Value = "ENBG")]
    [IsoId("_7Rx2ICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in the process of being enabled.")]
    Enabling,

    /// <summary>
    /// Status of the investor profile is enabled.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_-6UqICDQEeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is enabled.")]
    Enabled,

    /// <summary>
    /// Status of the investor profile is partially suspended.
    /// Encoded/decoded by serializers as &quot;PSUS&quot;.
    /// </summary>
    [EnumMember(Value = "PSUS")]
    [IsoId("_Fkk7oCDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is partially suspended.")]
    PartiallySuspended,

    /// <summary>
    /// Status of the investor profile is suspended.
    /// Encoded/decoded by serializers as &quot;SUPS&quot;.
    /// </summary>
    [EnumMember(Value = "SUPS")]
    [IsoId("_JiF6ECDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is suspended.")]
    Suspended,

    /// <summary>
    /// Status of the investor profile is in the process of being disabled.
    /// Encoded/decoded by serializers as &quot;DISG&quot;.
    /// </summary>
    [EnumMember(Value = "DISG")]
    [IsoId("_NgzLUCDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is in the process of being disabled.")]
    Disabling,

    /// <summary>
    /// Status of the investor profile is disabled.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_jjAeQCDREeWCLu74WLgP4w")]
    [Description(@"Status of the investor profile is disabled.")]
    Disabled,
}
