// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u2wKkQxtEeqdx6buGpCCQw")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading8Code
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as &quot;TAGC&quot;.
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_vBrBIQxtEeqdx6buGpCCQw")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag = CardDataReadingCode.Tag, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_vBrBIwxtEeqdx6buGpCCQw")]
    [Description(@"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.")]
    Physical = CardDataReadingCode.Physical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_vBrBJQxtEeqdx6buGpCCQw")]
    [Description(@"Bar code.")]
    BarCode = CardDataReadingCode.BarCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_vBrBJwxtEeqdx6buGpCCQw")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_vBrBKQxtEeqdx6buGpCCQw")]
    [Description(@"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.")]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as &quot;DFLE&quot;.
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_vBrBKwxtEeqdx6buGpCCQw")]
    [Description(@"Account data on file.")]
    AccountData = CardDataReadingCode.AccountData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_vBrBLQxtEeqdx6buGpCCQw")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_vBrBLwxtEeqdx6buGpCCQw")]
    [Description(@"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).")]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_vBrBMQxtEeqdx6buGpCCQw")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Synchronous ICC - (Integrated Circuit Card) with contact.
    /// Encoded/decoded by serializers as &quot;SICC&quot;.
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("_vBrBMwxtEeqdx6buGpCCQw")]
    [Description(@"Synchronous ICC - (Integrated Circuit Card) with contact.")]
    SynchronousIntegratedCircuitCard = CardDataReadingCode.SynchronousIntegratedCircuitCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_vBrBNQxtEeqdx6buGpCCQw")]
    [Description(@"Unknown card reading capability.")]
    Unknown = CardDataReadingCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quick response code.
    /// Encoded/decoded by serializers as &quot;QRCD&quot;.
    /// </summary>
    [EnumMember(Value = "QRCD")]
    [IsoId("_1ZVGwQxtEeqdx6buGpCCQw")]
    [Description(@"Quick response code.")]
    QRCode = CardDataReadingCode.QRCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.)
    /// Encoded/decoded by serializers as &quot;OPTC&quot;.
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_y8Nm4BEJEeq7iqRI5vDgAQ")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.)")]
    OpticalCode = CardDataReadingCode.OpticalCode, // same ordinal as derivation source for type conversions
    
}
