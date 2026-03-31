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
[IsoId("_z_QlkdkIEeiojJsa6FYyew")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardDataReading6Code>))]
#endif
public enum CardDataReading6Code
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as &quot;TAGC&quot;.
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_0I634dkIEeiojJsa6FYyew")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag = CardDataReadingCode.Tag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_0I6349kIEeiojJsa6FYyew")]
    [Description(
        @"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event."
    )]
    Physical = CardDataReadingCode.Physical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_0I635dkIEeiojJsa6FYyew")]
    [Description(@"Bar code.")]
    BarCode = CardDataReadingCode.BarCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_0I6359kIEeiojJsa6FYyew")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_0I636dkIEeiojJsa6FYyew")]
    [Description(
        @"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816."
    )]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as &quot;DFLE&quot;.
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_0I6369kIEeiojJsa6FYyew")]
    [Description(@"Account data on file.")]
    AccountData = CardDataReadingCode.AccountData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_0I637dkIEeiojJsa6FYyew")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_0I6379kIEeiojJsa6FYyew")]
    [Description(
        @"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa)."
    )]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_0I638dkIEeiojJsa6FYyew")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Synchronous ICC - (Integrated Circuit Card) with contact.
    /// Encoded/decoded by serializers as &quot;SICC&quot;.
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("_1QCQ8dkIEeiojJsa6FYyew")]
    [Description(@"Synchronous ICC - (Integrated Circuit Card) with contact.")]
    SynchronousIntegratedCircuitCard = CardDataReadingCode.SynchronousIntegratedCircuitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_1eTWcdkIEeiojJsa6FYyew")]
    [Description(@"Unknown card reading capability.")]
    Unknown = CardDataReadingCode.Unknown, // same ordinal as derivation source for type conversions
}
