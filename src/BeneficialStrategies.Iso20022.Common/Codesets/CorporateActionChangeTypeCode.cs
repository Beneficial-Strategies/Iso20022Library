// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of changes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDF4Bdp-Ed-ak6NoX_4Aeg_-1435625775")]
[Description(@"Specifies the type of changes.")]
[Derivations(typeof(CorporateActionChangeType2Code), typeof(CorporateActionChangeType1Code))]
public enum CorporateActionChangeTypeCode
{
    /// <summary>
    /// Change from bearer into registered form.
    /// Encoded/decoded by serializers as &quot;BERE&quot;.
    /// </summary>
    [EnumMember(Value = "BERE")]
    [IsoId("_bDF4Btp-Ed-ak6NoX_4Aeg_-1431930828")]
    [Description(@"Change from bearer into registered form.")]
    BearToRegistered,

    /// <summary>
    /// Change of all instruments into certificates.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bDF4B9p-Ed-ak6NoX_4Aeg_-1173344854")]
    [Description(@"Change of all instruments into certificates.")]
    Certificates,

    /// <summary>
    /// Change from dematerialised into physical form.
    /// Encoded/decoded by serializers as &quot;DEPH&quot;.
    /// </summary>
    [EnumMember(Value = "DEPH")]
    [IsoId("_bDF4CNp-Ed-ak6NoX_4Aeg_-1131785090")]
    [Description(@"Change from dematerialised into physical form.")]
    DematerialisedToPhysical,

    /// <summary>
    /// Change from global permanent to physical form.
    /// Encoded/decoded by serializers as &quot;GPPH&quot;.
    /// </summary>
    [EnumMember(Value = "GPPH")]
    [IsoId("_bDPpANp-Ed-ak6NoX_4Aeg_-1066217301")]
    [Description(@"Change from global permanent to physical form.")]
    GlobalPermanentToPhysical,

    /// <summary>
    /// Change from global temporary to global permanent form.
    /// Encoded/decoded by serializers as &quot;GTGP&quot;.
    /// </summary>
    [EnumMember(Value = "GTGP")]
    [IsoId("_bDPpAdp-Ed-ak6NoX_4Aeg_-706965969")]
    [Description(@"Change from global temporary to global permanent form.")]
    GlobalTemporaryToGlobalPermanent,

    /// <summary>
    /// Change from global temporary to physical form.
    /// Encoded/decoded by serializers as &quot;GTPH&quot;.
    /// </summary>
    [EnumMember(Value = "GTPH")]
    [IsoId("_bDPpAtp-Ed-ak6NoX_4Aeg_-645090885")]
    [Description(@"Change from global temporary to physical form.")]
    GlobalTemporaryToPhysical,

    /// <summary>
    /// The issuing company changes its name. CA event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as &quot;NAME&quot;.
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bDPpA9p-Ed-ak6NoX_4Aeg_-587831749")]
    [Description(
        @"The issuing company changes its name. CA event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar."
    )]
    Name,

    /// <summary>
    /// Change from physical into dematerialised form.
    /// Encoded/decoded by serializers as &quot;PHDE&quot;.
    /// </summary>
    [EnumMember(Value = "PHDE")]
    [IsoId("_bDPpBNp-Ed-ak6NoX_4Aeg_-575825829")]
    [Description(@"Change from physical into dematerialised form.")]
    PhysicalToDematerialised,

    /// <summary>
    /// Change from registered into bearer form.
    /// Encoded/decoded by serializers as &quot;REBE&quot;.
    /// </summary>
    [EnumMember(Value = "REBE")]
    [IsoId("_bDPpBdp-Ed-ak6NoX_4Aeg_-505638656")]
    [Description(@"Change from registered into bearer form.")]
    RegisteredToBearer,

    /// <summary>
    /// Change in the terms of the security.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_bDPpBtp-Ed-ak6NoX_4Aeg_-284917712")]
    [Description(@"Change in the terms of the security.")]
    Terms,

    /// <summary>
    /// Process of changing the accounting method of a security, for example, mutual fund, from units to a quantity with decimals.
    /// Encoded/decoded by serializers as &quot;DECI&quot;.
    /// </summary>
    [EnumMember(Value = "DECI")]
    [IsoId("_bDPpB9p-Ed-ak6NoX_4Aeg_-1694567219")]
    [Description(
        @"Process of changing the accounting method of a security, for example, mutual fund, from units to a quantity with decimals."
    )]
    Decimalisation,
}
