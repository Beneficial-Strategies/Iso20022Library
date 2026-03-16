// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HCtegF-cEeavlvCtut5bgg")]
[Description(@"Type of signature.")]
[Derivations(typeof(SignatureType2Code))]
public enum SignatureTypeV2Code
{
    /// <summary>
    /// Written signature. May also be known as a physical or wet signature.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_Pkt70F-cEeavlvCtut5bgg")]
    [Description(@"Written signature. May also be known as a physical or wet signature.")]
    Original,

    /// <summary>
    /// Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// Encoded/decoded by serializers as &quot;DIGI&quot;.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_PrkKsF-cEeavlvCtut5bgg")]
    [Description(
        @"Technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message."
    )]
    Digital,

    /// <summary>
    /// Copy of a physical or original signature in an electronic format.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_PyQokF-cEeavlvCtut5bgg")]
    [Description(@"Copy of a physical or original signature in an electronic format.")]
    Electronic,

    /// <summary>
    /// No signature.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_P4gagF-cEeavlvCtut5bgg")]
    [Description(@"No signature.")]
    None,
}
