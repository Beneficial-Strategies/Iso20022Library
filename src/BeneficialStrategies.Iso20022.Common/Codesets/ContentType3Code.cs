// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of protection for a protected data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DOog0D6OEeq_lLaSkIVjTQ")]
[Description(@"Identification of the type of protection for a protected data.")]
[DerivedFrom(typeof(ContentTypeCode))]
public enum ContentType3Code
{
    /// <summary>
    /// Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).
    /// Encoded/decoded by serializers as &quot;EVLP&quot;.
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_W7MyET6OEeq_lLaSkIVjTQ")]
    [Description(
        @"Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData)."
    )]
    EnvelopedData = ContentTypeCode.EnvelopedData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// General data encryption that conforms to the ISO 13492 standard.
    /// Encoded/decoded by serializers as &quot;IFSE&quot;.
    /// </summary>
    [EnumMember(Value = "IFSE")]
    [IsoId("_Zi3X4T6OEeq_lLaSkIVjTQ")]
    [Description(@"General data encryption that conforms to the ISO 13492 standard.")]
    ISOFinancialServicesDataEncryption = ContentTypeCode.ISOFinancialServicesDataEncryption, // same ordinal as derivation source for type conversions
}
