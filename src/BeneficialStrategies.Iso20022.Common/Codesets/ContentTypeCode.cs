// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of protection for a protected data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWii2gEcEeCQm6a_G2yO_w_-608827804")]
[Description(@"Identification of the type of protection for a protected data.")]
[Derivations(typeof(ContentType1Code), typeof(ContentType2Code), typeof(ContentType3Code))]
public enum ContentTypeCode
{
    /// <summary>
    /// Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_TWii2wEcEeCQm6a_G2yO_w_-1529665547")]
    [Description(
        @"Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data)."
    )]
    PlainData,

    /// <summary>
    /// Digital signature - (ASN.1 Object Identifier: id-signedData).
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_TWii3AEcEeCQm6a_G2yO_w_-488041433")]
    [Description(@"Digital signature - (ASN.1 Object Identifier: id-signedData).")]
    SignedData,

    /// <summary>
    /// Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).
    /// Encoded/decoded by serializers as &quot;EVLP&quot;.
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_TWii3QEcEeCQm6a_G2yO_w_-1205844644")]
    [Description(
        @"Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData)."
    )]
    EnvelopedData,

    /// <summary>
    /// Message digest - (ASN.1 Object Identifier: id-digestedData).
    /// Encoded/decoded by serializers as &quot;DGST&quot;.
    /// </summary>
    [EnumMember(Value = "DGST")]
    [IsoId("_TWii3gEcEeCQm6a_G2yO_w_1140582150")]
    [Description(@"Message digest - (ASN.1 Object Identifier: id-digestedData).")]
    DigestedData,

    /// <summary>
    /// Encrypted data - (ASN.1 Object Identifier: id-encryptedData).
    /// Encoded/decoded by serializers as &quot;ECRP&quot;.
    /// </summary>
    [EnumMember(Value = "ECRP")]
    [IsoId("_TWii3wEcEeCQm6a_G2yO_w_-1129746596")]
    [Description(@"Encrypted data - (ASN.1 Object Identifier: id-encryptedData).")]
    EncryptedData,

    /// <summary>
    /// MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_TWii4AEcEeCQm6a_G2yO_w_332278242")]
    [Description(
        @"MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData)."
    )]
    AuthenticatedData,

    /// <summary>
    /// General data encryption that conforms to the ISO 13492 standard.
    /// Encoded/decoded by serializers as &quot;IFSE&quot;.
    /// </summary>
    [EnumMember(Value = "IFSE")]
    [IsoId("_wF7KkD6NEeq_lLaSkIVjTQ")]
    [Description(@"General data encryption that conforms to the ISO 13492 standard.")]
    ISOFinancialServicesDataEncryption,
}
