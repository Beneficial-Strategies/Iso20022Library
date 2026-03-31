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
[IsoId("_gQ7oMWizEeS87LmvcA55sg")]
[Description(@"Identification of the type of a Cryptographic Message Syntax (CMS) data structure.")]
[DerivedFrom(typeof(ContentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ContentType2Code>))]
#endif
public enum ContentType2Code
{
    /// <summary>
    /// Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_gd_z0WizEeS87LmvcA55sg")]
    [Description(
        @"Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data)."
    )]
    PlainData = ContentTypeCode.PlainData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Digital signature - (ASN.1 Object Identifier: id-signedData).
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_gd_z02izEeS87LmvcA55sg")]
    [Description(@"Digital signature - (ASN.1 Object Identifier: id-signedData).")]
    SignedData = ContentTypeCode.SignedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).
    /// Encoded/decoded by serializers as &quot;EVLP&quot;.
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_gd_z1WizEeS87LmvcA55sg")]
    [Description(
        @"Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData)."
    )]
    EnvelopedData = ContentTypeCode.EnvelopedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message digest - (ASN.1 Object Identifier: id-digestedData).
    /// Encoded/decoded by serializers as &quot;DGST&quot;.
    /// </summary>
    [EnumMember(Value = "DGST")]
    [IsoId("_gd_z12izEeS87LmvcA55sg")]
    [Description(@"Message digest - (ASN.1 Object Identifier: id-digestedData).")]
    DigestedData = ContentTypeCode.DigestedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_gd_z22izEeS87LmvcA55sg")]
    [Description(
        @"MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData)."
    )]
    AuthenticatedData = ContentTypeCode.AuthenticatedData, // same ordinal as derivation source for type conversions
}
