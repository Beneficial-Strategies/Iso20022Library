// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party in charge of assigning an identification to a company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jzqUkGMaEeexSYCBvAp_qA")]
[Description(@"Party in charge of assigning an identification to a company.")]
[DerivedFrom(typeof(CompanyAssignerCode))]
public enum CompanyAssigner2Code
{
    /// <summary>
    /// Any relevant association in charge of assigning an identification to a company.
    /// Encoded/decoded by serializers as &quot;ASSO&quot;.
    /// </summary>
    [EnumMember(Value = "ASSO")]
    [IsoId("_qVBv0WMaEeexSYCBvAp_qA")]
    [Description(
        @"Any relevant association in charge of assigning an identification to a company."
    )]
    Association = CompanyAssignerCode.Association, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal authority assigning an identification to a company (for example, a local, regional or national authority).
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_qeFlMWMaEeexSYCBvAp_qA")]
    [Description(
        @"Legal authority assigning an identification to a company (for example, a local, regional or national authority)."
    )]
    Authority = CompanyAssignerCode.Authority, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification assigned by the company itself.
    /// Encoded/decoded by serializers as &quot;CPNY&quot;.
    /// </summary>
    [EnumMember(Value = "CPNY")]
    [IsoId("_qrDqMWMaEeexSYCBvAp_qA")]
    [Description(@"Identification assigned by the company itself.")]
    Company = CompanyAssignerCode.Company, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal Entity Identifier.
    /// Encoded/decoded by serializers as &quot;LEII&quot;.
    /// </summary>
    [EnumMember(Value = "LEII")]
    [IsoId("_q6aU0WMaEeexSYCBvAp_qA")]
    [Description(@"Legal Entity Identifier.")]
    LEI = CompanyAssignerCode.LEI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification assigned by a travel agency.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_rC_pEWMaEeexSYCBvAp_qA")]
    [Description(@"Identification assigned by a travel agency.")]
    TravelAgency = CompanyAssignerCode.TravelAgency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other company assigner entity defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_9vdIMWMaEeexSYCBvAp_qA")]
    [Description(@"Other company assigner entity defined at private level.")]
    OtherPrivate = CompanyAssignerCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other company assigner entity defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_97L3EWMaEeexSYCBvAp_qA")]
    [Description(@"Other company assigner entity defined at national level.")]
    OtherNational = CompanyAssignerCode.OtherNational, // same ordinal as derivation source for type conversions
}
