// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card reading capabilities of the terminal performing the transaction.
/// It correspond to the ISO 8583, field number 22-2 for the version 93, and 27-1 for the version 2003.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xeX4AHrwEeSz_of_1TY14A")]
[Description(
    @"Card reading capabilities of the terminal performing the transaction.|It correspond to the ISO 8583, field number 22-2 for the version 93, and 27-1 for the version 2003."
)]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading2Code
{
    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as &quot;DFLE&quot;.
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_0UmeQXrwEeSz_of_1TY14A")]
    [Description(@"Account data on file.")]
    AccountData = CardDataReadingCode.AccountData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_0bctIXrwEeSz_of_1TY14A")]
    [Description(@"Bar code.")]
    BarCode = CardDataReadingCode.BarCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_0hRBQXrwEeSz_of_1TY14A")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_1XISQXrwEeSz_of_1TY14A")]
    [Description(
        @"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa)."
    )]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_1jy1QXrwEeSz_of_1TY14A")]
    [Description(
        @"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816."
    )]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_1wX4sXrwEeSz_of_1TY14A")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_197zkXrwEeSz_of_1TY14A")]
    [Description(
        @"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event."
    )]
    Physical = CardDataReadingCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_2EMMkXrwEeSz_of_1TY14A")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as &quot;TAGC&quot;.
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_2J2vsXrwEeSz_of_1TY14A")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag = CardDataReadingCode.Tag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_2Wju8XrwEeSz_of_1TY14A")]
    [Description(@"Unknown card reading capability.")]
    Unknown = CardDataReadingCode.Unknown, // same ordinal as derivation source for type conversions
}
