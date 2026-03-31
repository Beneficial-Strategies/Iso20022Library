// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Capabilities of the ATM terminal performing the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CRJTMIn7EeShMpas3885ww")]
[Description(@"Capabilities of the ATM terminal performing the transaction.")]
[DerivedFrom(typeof(CardDataReadingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardDataReading4Code>))]
#endif
public enum CardDataReading4Code
{
    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_KJE4wYn7EeShMpas3885ww")]
    [Description(
        @"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa)."
    )]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_KP7HoYn7EeShMpas3885ww")]
    [Description(
        @"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816."
    )]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_KX-QYYn7EeShMpas3885ww")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_LaEmkYn7EeShMpas3885ww")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions
}
