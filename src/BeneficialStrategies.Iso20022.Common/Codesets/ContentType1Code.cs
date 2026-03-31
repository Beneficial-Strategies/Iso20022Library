// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of a Cryptographic Message Syntax (CMS) data structure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSz5bQEcEeCQm6a_G2yO_w_780953916")]
[Description(@"Identification of the type of a Cryptographic Message Syntax (CMS) data structure.")]
[DerivedFrom(typeof(ContentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ContentType1Code>))]
#endif
public enum ContentType1Code
{
    /// <summary>
    /// Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_TSz5bgEcEeCQm6a_G2yO_w_-2039421472")]
    [Description(
        @"Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data)."
    )]
    PlainData = ContentTypeCode.PlainData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Digital signature - (ASN.1 Object Identifier: id-signedData).
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_TSz5bwEcEeCQm6a_G2yO_w_1372312537")]
    [Description(@"Digital signature - (ASN.1 Object Identifier: id-signedData).")]
    SignedData = ContentTypeCode.SignedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).
    /// Encoded/decoded by serializers as &quot;EVLP&quot;.
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_TSz5cAEcEeCQm6a_G2yO_w_-119772177")]
    [Description(
        @"Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData)."
    )]
    EnvelopedData = ContentTypeCode.EnvelopedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message digest - (ASN.1 Object Identifier: id-digestedData).
    /// Encoded/decoded by serializers as &quot;DGST&quot;.
    /// </summary>
    [EnumMember(Value = "DGST")]
    [IsoId("_TSz5cQEcEeCQm6a_G2yO_w_-983336409")]
    [Description(@"Message digest - (ASN.1 Object Identifier: id-digestedData).")]
    DigestedData = ContentTypeCode.DigestedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encrypted data - (ASN.1 Object Identifier: id-encryptedData).
    /// Encoded/decoded by serializers as &quot;ECRP&quot;.
    /// </summary>
    [EnumMember(Value = "ECRP")]
    [IsoId("_TSz5cgEcEeCQm6a_G2yO_w_953888764")]
    [Description(@"Encrypted data - (ASN.1 Object Identifier: id-encryptedData).")]
    EncryptedData = ContentTypeCode.EncryptedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_TS9qYAEcEeCQm6a_G2yO_w_-994435186")]
    [Description(
        @"MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData)."
    )]
    AuthenticatedData = ContentTypeCode.AuthenticatedData, // same ordinal as derivation source for type conversions
}
