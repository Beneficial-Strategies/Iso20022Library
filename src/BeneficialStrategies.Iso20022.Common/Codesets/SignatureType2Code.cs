// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kjV1YF-dEeavlvCtut5bgg")]
[Description(@"Type of signature.")]
[DerivedFrom(typeof(SignatureTypeV2Code))]
public enum SignatureType2Code
{
    /// <summary>
    /// Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// Encoded/decoded by serializers as &quot;DIGI&quot;.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_r15dAV-dEeavlvCtut5bgg")]
    [Description(@"Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.")]
    Digital = SignatureTypeV2Code.Digital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Copy of a physical or original signature in an electronic format.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_sBDkIV-dEeavlvCtut5bgg")]
    [Description(@"Copy of a physical or original signature in an electronic format.")]
    Electronic = SignatureTypeV2Code.Electronic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No signature.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_sEVhoV-dEeavlvCtut5bgg")]
    [Description(@"No signature.")]
    None = SignatureTypeV2Code.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Written signature. May also be known as a physical or wet signature.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_sJGF0V-dEeavlvCtut5bgg")]
    [Description(@"Written signature. May also be known as a physical or wet signature.")]
    Original = SignatureTypeV2Code.Original, // same ordinal as derivation source for type conversions
    
}
