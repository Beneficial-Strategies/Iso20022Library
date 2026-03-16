// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error Correction mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LwMBINubEeiB5uLfkg9ZJA")]
[Description(@"Error Correction mode of Quick Response Code.")]
[DerivedFrom(typeof(QRCodeErrorCorrectionCode))]
public enum QRCodeErrorCorrection1Code
{
    /// <summary>
    /// Reed-Solomon error correction 15%
    /// Encoded/decoded by serializers as &quot;M015&quot;.
    /// </summary>
    [EnumMember(Value = "M015")]
    [IsoId("_EgtQwdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 15%")]
    ErrorCorrection15Percent = QRCodeErrorCorrectionCode.ErrorCorrection15Percent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reed-Solomon error correction 25%
    /// Encoded/decoded by serializers as &quot;Q025&quot;.
    /// </summary>
    [EnumMember(Value = "Q025")]
    [IsoId("_Ek7pcdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 25%")]
    ErrorCorrection25Percent = QRCodeErrorCorrectionCode.ErrorCorrection25Percent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reed-Solomon error correction 30%
    /// Encoded/decoded by serializers as &quot;H030&quot;.
    /// </summary>
    [EnumMember(Value = "H030")]
    [IsoId("_Eo48YdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 30%")]
    ErrorCorrection30Percent = QRCodeErrorCorrectionCode.ErrorCorrection30Percent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reed-Solomon error correction  7%
    /// Encoded/decoded by serializers as &quot;L007&quot;.
    /// </summary>
    [EnumMember(Value = "L007")]
    [IsoId("_Es55sdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction  7%")]
    ErrorCorrection7Percent = QRCodeErrorCorrectionCode.ErrorCorrection7Percent, // same ordinal as derivation source for type conversions
}
