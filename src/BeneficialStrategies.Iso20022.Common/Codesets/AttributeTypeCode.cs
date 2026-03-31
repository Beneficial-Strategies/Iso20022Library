// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of attribute of a distinguished name (DN).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVyU5gEcEeCQm6a_G2yO_w_-64929302")]
[Description(@"Type of attribute of a distinguished name (DN).")]
[Derivations(typeof(AttributeType1Code), typeof(AttributeType2Code))]
public enum AttributeTypeCode
{
    /// <summary>
    /// Common name of the attribute (ASN.1 Object Identifier: id-at-commonName).
    /// Encoded/decoded by serializers as &quot;CNAT&quot;.
    /// </summary>
    [EnumMember(Value = "CNAT")]
    [IsoId("_TVyU5wEcEeCQm6a_G2yO_w_1569239356")]
    [Description(@"Common name of the attribute (ASN.1 Object Identifier: id-at-commonName).")]
    CommonName,

    /// <summary>
    /// Locality of the attribute (ASN.1 Object Identifier: id-at-localityName).
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_TVyU6AEcEeCQm6a_G2yO_w_672048478")]
    [Description(@"Locality of the attribute (ASN.1 Object Identifier: id-at-localityName).")]
    Locality,

    /// <summary>
    /// Organization name of the attribute (ASN.1 Object Identifier: id-at-organizationName).
    /// Encoded/decoded by serializers as &quot;OATT&quot;.
    /// </summary>
    [EnumMember(Value = "OATT")]
    [IsoId("_TVyU6QEcEeCQm6a_G2yO_w_-706634465")]
    [Description(
        @"Organization name of the attribute (ASN.1 Object Identifier: id-at-organizationName)."
    )]
    OrganisationName,

    /// <summary>
    /// Organization unit name of the attribute (ASN.1 Object Identifier: id-at-organizationalUnitName).
    /// Encoded/decoded by serializers as &quot;OUAT&quot;.
    /// </summary>
    [EnumMember(Value = "OUAT")]
    [IsoId("_TVyU6gEcEeCQm6a_G2yO_w_1301568158")]
    [Description(
        @"Organization unit name of the attribute (ASN.1 Object Identifier: id-at-organizationalUnitName)."
    )]
    OrganisationUnitName,

    /// <summary>
    /// Country name of the attribute (ASN.1 Object Identifier: id-at-countryName).
    /// Encoded/decoded by serializers as &quot;CATT&quot;.
    /// </summary>
    [EnumMember(Value = "CATT")]
    [IsoId("_TVyU6wEcEeCQm6a_G2yO_w_-856607476")]
    [Description(@"Country name of the attribute (ASN.1 Object Identifier: id-at-countryName).")]
    CountryName,

    /// <summary>
    /// Email address of the certificate subject.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_n4c38I4TEeW6h7rGyYlyTg")]
    [Description(@"Email address of the certificate subject.")]
    EmailAddress,

    /// <summary>
    /// Password by which an entity may request certificate revocation.
    /// Encoded/decoded by serializers as &quot;CHLG&quot;.
    /// </summary>
    [EnumMember(Value = "CHLG")]
    [IsoId("_q2GU0I4TEeW6h7rGyYlyTg")]
    [Description(@"Password by which an entity may request certificate revocation.")]
    ChallengePassword,
}
