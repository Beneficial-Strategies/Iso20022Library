// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party in charge of assigning an identification to a company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_z_dukFyoEeeve7Je9cXtkQ")]
[Description(@"Party in charge of assigning an identification to a company.")]
[Derivations(typeof(CompanyAssigner2Code))]
public enum CompanyAssignerCode
{
    /// <summary>
    /// Associated Canadian Car Rental Operators
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("__paNMFyoEeeve7Je9cXtkQ")]
    [Description(@"Associated Canadian Car Rental Operators")]
    ACCRO,

    /// <summary>
    /// American Car Rental Association.
    /// Encoded/decoded by serializers as &quot;ACRA&quot;.
    /// </summary>
    [EnumMember(Value = "ACRA")]
    [IsoId("_G_hfIFypEeeve7Je9cXtkQ")]
    [Description(@"American Car Rental Association.")]
    ACRA,

    /// <summary>
    /// Any relevant association in charge of assigning an identification to a company.
    /// Encoded/decoded by serializers as &quot;ASSO&quot;.
    /// </summary>
    [EnumMember(Value = "ASSO")]
    [IsoId("_PcAjQFypEeeve7Je9cXtkQ")]
    [Description(
        @"Any relevant association in charge of assigning an identification to a company."
    )]
    Association,

    /// <summary>
    /// Identification assigned by the company itself.
    /// Encoded/decoded by serializers as &quot;CPNY&quot;.
    /// </summary>
    [EnumMember(Value = "CPNY")]
    [IsoId("_a15MoFypEeeve7Je9cXtkQ")]
    [Description(@"Identification assigned by the company itself.")]
    Company,

    /// <summary>
    /// Identification assigned by a travel agency.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_g5JvkFypEeeve7Je9cXtkQ")]
    [Description(@"Identification assigned by a travel agency.")]
    TravelAgency,

    /// <summary>
    /// Legal authority assigning an identification to a company (for example, a local, regional or national authority).
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_nDQhYFypEeeve7Je9cXtkQ")]
    [Description(
        @"Legal authority assigning an identification to a company (for example, a local, regional or national authority)."
    )]
    Authority,

    /// <summary>
    /// European Car and Truck Rental Association
    /// Encoded/decoded by serializers as &quot;ECAT&quot;.
    /// </summary>
    [EnumMember(Value = "ECAT")]
    [IsoId("_wI9hoFypEeeve7Je9cXtkQ")]
    [Description(@"European Car and Truck Rental Association")]
    ECATRA,

    /// <summary>
    /// Legal Entity Identifier.
    /// Encoded/decoded by serializers as &quot;LEII&quot;.
    /// </summary>
    [EnumMember(Value = "LEII")]
    [IsoId("_3xh1gFypEeeve7Je9cXtkQ")]
    [Description(@"Legal Entity Identifier.")]
    LEI,

    /// <summary>
    /// Other company assigner entity defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_uZGCMGMaEeexSYCBvAp_qA")]
    [Description(@"Other company assigner entity defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other company assigner entity defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_1gm3cGMaEeexSYCBvAp_qA")]
    [Description(@"Other company assigner entity defined at private level.")]
    OtherPrivate,
}
