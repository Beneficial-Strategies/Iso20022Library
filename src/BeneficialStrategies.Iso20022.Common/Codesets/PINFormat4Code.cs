// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of an ATM PIN block before encryption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XsWNgIocEeSirOZJBRz_nA")]
[Description(@"Format of an ATM PIN block before encryption.")]
[DerivedFrom(typeof(PINFormatCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PINFormat4Code>))]
#endif
public enum PINFormat4Code
{
    /// <summary>
    /// ANSI 0 PIN block format.
    /// Encoded/decoded by serializers as &quot;ANSI&quot;.
    /// </summary>
    [EnumMember(Value = "ANSI")]
    [IsoId("_cX59sYocEeSirOZJBRz_nA")]
    [Description(@"ANSI 0 PIN block format.")]
    ANSI0 = PINFormatCode.ANSI0, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Italian Bancomat PIN block format.
    /// Encoded/decoded by serializers as &quot;BNCM&quot;.
    /// </summary>
    [EnumMember(Value = "BNCM")]
    [IsoId("_cdXsgYocEeSirOZJBRz_nA")]
    [Description(@"Italian Bancomat PIN block format.")]
    Bancomat = PINFormatCode.Bancomat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Banksys PIN block format.
    /// Encoded/decoded by serializers as &quot;BKSY&quot;.
    /// </summary>
    [EnumMember(Value = "BKSY")]
    [IsoId("_ch9RkYocEeSirOZJBRz_nA")]
    [Description(@"Banksys PIN block format.")]
    Banksys = PINFormatCode.Banksys, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Diebold PIN block format.
    /// Encoded/decoded by serializers as &quot;DBLD&quot;.
    /// </summary>
    [EnumMember(Value = "DBLD")]
    [IsoId("_cm6qEYocEeSirOZJBRz_nA")]
    [Description(@"Diebold PIN block format.")]
    Diebold = PINFormatCode.Diebold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Diebold CO PIN block format.
    /// Encoded/decoded by serializers as &quot;DBLC&quot;.
    /// </summary>
    [EnumMember(Value = "DBLC")]
    [IsoId("_csVVkYocEeSirOZJBRz_nA")]
    [Description(@"Diebold CO PIN block format.")]
    DieboldCO = PINFormatCode.DieboldCO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ECI2 PIN block format.
    /// Encoded/decoded by serializers as &quot;ECI2&quot;.
    /// </summary>
    [EnumMember(Value = "ECI2")]
    [IsoId("_cxdtMYocEeSirOZJBRz_nA")]
    [Description(@"ECI2 PIN block format.")]
    ECI2 = PINFormatCode.ECI2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ECI3 PIN block format.
    /// Encoded/decoded by serializers as &quot;ECI3&quot;.
    /// </summary>
    [EnumMember(Value = "ECI3")]
    [IsoId("_c2nS8YocEeSirOZJBRz_nA")]
    [Description(@"ECI3 PIN block format.")]
    ECI3 = PINFormatCode.ECI3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EMV ISO2 PIN block format encrypted with the EMV RSA cryptographic key for the PIN.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_c7vqkYocEeSirOZJBRz_nA")]
    [Description(
        @"EMV ISO2 PIN block format encrypted with the EMV RSA cryptographic key for the PIN."
    )]
    EMVRSA = PINFormatCode.EMVRSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// IBM 3624 PIN block format.
    /// Encoded/decoded by serializers as &quot;IBM3&quot;.
    /// </summary>
    [EnumMember(Value = "IBM3")]
    [IsoId("_dA53YYocEeSirOZJBRz_nA")]
    [Description(@"IBM 3624 PIN block format.")]
    IBM3624 = PINFormatCode.IBM3624, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN diversified with the card account number, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO0&quot;.
    /// </summary>
    [EnumMember(Value = "ISO0")]
    [IsoId("_dHp_oYocEeSirOZJBRz_nA")]
    [Description(
        @"PIN diversified with the card account number, conforming to the standard ISO 9564-2."
    )]
    ISO0 = PINFormatCode.ISO0, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN completed with random padding characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO1&quot;.
    /// </summary>
    [EnumMember(Value = "ISO1")]
    [IsoId("_dNsWMYocEeSirOZJBRz_nA")]
    [Description(
        @"PIN completed with random padding characters, conforming to the standard ISO 9564-2."
    )]
    ISO1 = PINFormatCode.ISO1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN without diversification characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO2&quot;.
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_dSkPIYocEeSirOZJBRz_nA")]
    [Description(@"PIN without diversification characters, conforming to the standard ISO 9564-2.")]
    ISO2 = PINFormatCode.ISO2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as &quot;ISO3&quot;.
    /// </summary>
    [EnumMember(Value = "ISO3")]
    [IsoId("_dYIEkYocEeSirOZJBRz_nA")]
    [Description(
        @"PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2."
    )]
    ISO3 = PINFormatCode.ISO3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO4&quot;.
    /// </summary>
    [EnumMember(Value = "ISO4")]
    [IsoId("_ddshEYocEeSirOZJBRz_nA")]
    [Description(@"PIN format used with AES encryption, conforming to the new ISO SC2 format.")]
    ISO4 = PINFormatCode.ISO4, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Alternative PIN format used with AES encryption, conforming to the new ISO SC2 format.
    /// Encoded/decoded by serializers as &quot;ISO5&quot;.
    /// </summary>
    [EnumMember(Value = "ISO5")]
    [IsoId("_djMFEYocEeSirOZJBRz_nA")]
    [Description(
        @"Alternative PIN format used with AES encryption, conforming to the new ISO SC2 format."
    )]
    ISO5 = PINFormatCode.ISO5, // same ordinal as derivation source for type conversions

    /// <summary>
    /// VISA2 PIN block format.
    /// Encoded/decoded by serializers as &quot;VIS2&quot;.
    /// </summary>
    [EnumMember(Value = "VIS2")]
    [IsoId("_dqC7AYocEeSirOZJBRz_nA")]
    [Description(@"VISA2 PIN block format.")]
    VISA2 = PINFormatCode.VISA2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// VISA3 PIN block format.
    /// Encoded/decoded by serializers as &quot;VIS3&quot;.
    /// </summary>
    [EnumMember(Value = "VIS3")]
    [IsoId("_dvrB4YocEeSirOZJBRz_nA")]
    [Description(@"VISA3 PIN block format.")]
    VISA3 = PINFormatCode.VISA3, // same ordinal as derivation source for type conversions
}
