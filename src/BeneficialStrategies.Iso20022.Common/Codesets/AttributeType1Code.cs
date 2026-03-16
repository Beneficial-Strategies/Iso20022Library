// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of attribute of a distinguished name (DN).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSEShwEcEeCQm6a_G2yO_w_1647054539")]
[Description(@"Type of attribute of a distinguished name (DN).")]
[DerivedFrom(typeof(AttributeTypeCode))]
public enum AttributeType1Code
{
    /// <summary>
    /// Common name of the attribute (ASN.1 Object Identifier: id-at-commonName).
    /// Encoded/decoded by serializers as &quot;CNAT&quot;.
    /// </summary>
    [EnumMember(Value = "CNAT")]
    [IsoId("_TSESiAEcEeCQm6a_G2yO_w_399531534")]
    [Description(@"Common name of the attribute (ASN.1 Object Identifier: id-at-commonName).")]
    CommonName = AttributeTypeCode.CommonName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Locality of the attribute (ASN.1 Object Identifier: id-at-localityName).
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_TSESiQEcEeCQm6a_G2yO_w_807359888")]
    [Description(@"Locality of the attribute (ASN.1 Object Identifier: id-at-localityName).")]
    Locality = AttributeTypeCode.Locality, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Organization name of the attribute (ASN.1 Object Identifier: id-at-organizationName).
    /// Encoded/decoded by serializers as &quot;OATT&quot;.
    /// </summary>
    [EnumMember(Value = "OATT")]
    [IsoId("_TSESigEcEeCQm6a_G2yO_w_-1550382235")]
    [Description(
        @"Organization name of the attribute (ASN.1 Object Identifier: id-at-organizationName)."
    )]
    OrganisationName = AttributeTypeCode.OrganisationName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Organization unit name of the attribute (ASN.1 Object Identifier: id-at-organizationalUnitName).
    /// Encoded/decoded by serializers as &quot;OUAT&quot;.
    /// </summary>
    [EnumMember(Value = "OUAT")]
    [IsoId("_TSESiwEcEeCQm6a_G2yO_w_-2013772510")]
    [Description(
        @"Organization unit name of the attribute (ASN.1 Object Identifier: id-at-organizationalUnitName)."
    )]
    OrganisationUnitName = AttributeTypeCode.OrganisationUnitName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Country name of the attribute (ASN.1 Object Identifier: id-at-countryName).
    /// Encoded/decoded by serializers as &quot;CATT&quot;.
    /// </summary>
    [EnumMember(Value = "CATT")]
    [IsoId("_TSESjAEcEeCQm6a_G2yO_w_189442098")]
    [Description(@"Country name of the attribute (ASN.1 Object Identifier: id-at-countryName).")]
    CountryName = AttributeTypeCode.CountryName, // same ordinal as derivation source for type conversions
}
