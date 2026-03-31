// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSXNcQEcEeCQm6a_G2yO_w_2087394966")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardDataReading1Code>))]
#endif
public enum CardDataReading1Code
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as &quot;TAGC&quot;.
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_TSXNcgEcEeCQm6a_G2yO_w_1877381084")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag = CardDataReadingCode.Tag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_TSXNcwEcEeCQm6a_G2yO_w_-764781715")]
    [Description(
        @"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event."
    )]
    Physical = CardDataReadingCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_TSXNdAEcEeCQm6a_G2yO_w_1172443458")]
    [Description(@"Bar code.")]
    BarCode = CardDataReadingCode.BarCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_TSXNdQEcEeCQm6a_G2yO_w_-439664208")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_TSXNdgEcEeCQm6a_G2yO_w_-1892344504")]
    [Description(
        @"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816."
    )]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as &quot;DFLE&quot;.
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_TSXNdwEcEeCQm6a_G2yO_w_44880669")]
    [Description(@"Account data on file.")]
    AccountData = CardDataReadingCode.AccountData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_TSXNeAEcEeCQm6a_G2yO_w_1689489202")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_TSXNeQEcEeCQm6a_G2yO_w_-154379787")]
    [Description(
        @"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa)."
    )]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions
}
