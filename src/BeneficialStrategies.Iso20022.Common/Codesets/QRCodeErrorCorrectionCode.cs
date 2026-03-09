// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error Correction mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_55g6gNuaEeiB5uLfkg9ZJA")]
[Description(@"Error Correction mode of Quick Response Code.")]
[Derivations(typeof(QRCodeErrorCorrection1Code))]
public enum QRCodeErrorCorrectionCode
{
    /// <summary>
    /// Reed-Solomon error correction  7%
    /// Encoded/decoded by serializers as &quot;L007&quot;.
    /// </summary>
    [EnumMember(Value = "L007")]
    [IsoId("_-CY0YNuaEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction  7%")]
    ErrorCorrection7Percent,
    
    /// <summary>
    /// Reed-Solomon error correction 15%
    /// Encoded/decoded by serializers as &quot;M015&quot;.
    /// </summary>
    [EnumMember(Value = "M015")]
    [IsoId("_C9HB8NubEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 15%")]
    ErrorCorrection15Percent,
    
    /// <summary>
    /// Reed-Solomon error correction 25%
    /// Encoded/decoded by serializers as &quot;Q025&quot;.
    /// </summary>
    [EnumMember(Value = "Q025")]
    [IsoId("_F43BYNubEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 25%")]
    ErrorCorrection25Percent,
    
    /// <summary>
    /// Reed-Solomon error correction 30%
    /// Encoded/decoded by serializers as &quot;H030&quot;.
    /// </summary>
    [EnumMember(Value = "H030")]
    [IsoId("_IqPj4NubEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 30%")]
    ErrorCorrection30Percent,
    
}
