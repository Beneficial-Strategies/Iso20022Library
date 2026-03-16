// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKGWEtp-Ed-ak6NoX_4Aeg_274745711")]
[Description(@"Specifies the status of the security.")]
[Derivations(typeof(SecurityStatus1Code), typeof(SecurityStatus2Code))]
public enum SecurityStatusCode
{
    /// <summary>
    /// The status is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZKGWE9p-Ed-ak6NoX_4Aeg_875031399")]
    [Description(@"The status is active.")]
    Active,

    /// <summary>
    /// The status is inactive.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_ZKGWFNp-Ed-ak6NoX_4Aeg_924902935")]
    [Description(@"The status is inactive.")]
    Inactive,

    /// <summary>
    /// The status is when issued.
    /// Encoded/decoded by serializers as &quot;WISS&quot;.
    /// </summary>
    [EnumMember(Value = "WISS")]
    [IsoId("_ZKGWFdp-Ed-ak6NoX_4Aeg_1162247833")]
    [Description(@"The status is when issued.")]
    WhenIssued,

    /// <summary>
    /// The status is when distributed.
    /// Encoded/decoded by serializers as &quot;WDIS&quot;.
    /// </summary>
    [EnumMember(Value = "WDIS")]
    [IsoId("_ZKGWFtp-Ed-ak6NoX_4Aeg_1205652804")]
    [Description(@"The status is when distributed.")]
    WhenDistributed,

    /// <summary>
    /// The status is issued.
    /// Encoded/decoded by serializers as &quot;ISUD&quot;.
    /// </summary>
    [EnumMember(Value = "ISUD")]
    [IsoId("_ZKGWF9p-Ed-ak6NoX_4Aeg_1232436292")]
    [Description(@"The status is issued.")]
    Issued,

    /// <summary>
    /// The status is suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ZKGWGNp-Ed-ak6NoX_4Aeg_1249981812")]
    [Description(@"The status is suspended.")]
    Suspended,

    /// <summary>
    /// The status is in default.
    /// Encoded/decoded by serializers as &quot;IDEF&quot;.
    /// </summary>
    [EnumMember(Value = "IDEF")]
    [IsoId("_ZKPgANp-Ed-ak6NoX_4Aeg_1275841256")]
    [Description(@"The status is in default.")]
    InDefault,

    /// <summary>
    /// Annoucement by the regulator that the security has become worthless.
    /// Encoded/decoded by serializers as &quot;WRTH&quot;.
    /// </summary>
    [EnumMember(Value = "WRTH")]
    [IsoId("_ZKPgAdp-Ed-ak6NoX_4Aeg_1295235874")]
    [Description(@"Annoucement by the regulator that the security has become worthless.")]
    Worthless,
}
