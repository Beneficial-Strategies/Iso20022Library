// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j7nYMY0REeWRYffwL7E13A")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading5Code
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as &quot;TAGC&quot;.
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_kGMQgY0REeWRYffwL7E13A")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag = CardDataReadingCode.Tag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_kGMQg40REeWRYffwL7E13A")]
    [Description(
        @"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event."
    )]
    Physical = CardDataReadingCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_kGMQhY0REeWRYffwL7E13A")]
    [Description(@"Bar code.")]
    BarCode = CardDataReadingCode.BarCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_kGMQh40REeWRYffwL7E13A")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_kGMQiY0REeWRYffwL7E13A")]
    [Description(
        @"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816."
    )]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as &quot;DFLE&quot;.
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_kGMQi40REeWRYffwL7E13A")]
    [Description(@"Account data on file.")]
    AccountData = CardDataReadingCode.AccountData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_kGMQjY0REeWRYffwL7E13A")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_kGMQj40REeWRYffwL7E13A")]
    [Description(
        @"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa)."
    )]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_n7UH8Y0REeWRYffwL7E13A")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions
}
