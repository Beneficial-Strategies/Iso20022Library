// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of bonds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5al_gc4lEeSc85GUbgBycw")]
[Description(@"Specifies the type of bonds.")]
[Derivations(typeof(BondType1Code))]
public enum BondTypeCode
{
    /// <summary>
    /// Bond of type sovereign bond.
    /// Encoded/decoded by serializers as &quot;EUSB&quot;.
    /// </summary>
    [EnumMember(Value = "EUSB")]
    [IsoId("_BKKTQM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type sovereign bond.|")]
    SovereignBond,

    /// <summary>
    /// Bond of type non-european sovereign bond.
    /// Encoded/decoded by serializers as &quot;NESB&quot;.
    /// </summary>
    [EnumMember(Value = "NESB")]
    [IsoId("_BX_68M4mEeSc85GUbgBycw")]
    [Description(@"Bond of type non-european sovereign bond.")]
    NonEuropeanSovereignBond,

    /// <summary>
    /// Bond of type other public bond.
    /// Encoded/decoded by serializers as &quot;OEPB&quot;.
    /// </summary>
    [EnumMember(Value = "OEPB")]
    [IsoId("_BcTzMM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type other public bond.")]
    OtherPublicBond,

    /// <summary>
    /// Bond of type convertible bond.
    /// Encoded/decoded by serializers as &quot;CVTB&quot;.
    /// </summary>
    [EnumMember(Value = "CVTB")]
    [IsoId("_Bfb_sM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type convertible bond.")]
    ConvertibleBond,

    /// <summary>
    /// Bond of type covered Bond.
    /// Encoded/decoded by serializers as &quot;CVDB&quot;.
    /// </summary>
    [EnumMember(Value = "CVDB")]
    [IsoId("_BhhDUM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type covered Bond.")]
    CoveredBond,

    /// <summary>
    /// Bond of type corporate Bond.
    /// Encoded/decoded by serializers as &quot;CRPB&quot;.
    /// </summary>
    [EnumMember(Value = "CRPB")]
    [IsoId("_BkWU4M4mEeSc85GUbgBycw")]
    [Description(@"Bond of type corporate Bond.|")]
    CorporateBond,

    /// <summary>
    /// Bond of type other non-european public bond.
    /// Encoded/decoded by serializers as &quot;ONEP&quot;.
    /// </summary>
    [EnumMember(Value = "ONEP")]
    [IsoId("_s22aMAkBEeWGouz230Xp5Q")]
    [Description(@"Bond of type other non-european public bond.")]
    OtherNonEuropeanPublicBond,

    /// <summary>
    /// Other bond type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ss_CcED6EeW1yage4PQ__A")]
    [Description(@"Other bond type.")]
    Other,
}
