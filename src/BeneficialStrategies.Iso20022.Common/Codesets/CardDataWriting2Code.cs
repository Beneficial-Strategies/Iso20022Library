// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card writing capabilities of the terminal performing the transaction. ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9
/// </summary>
[DataContract]
[Serializable]
[IsoId("_edIn0RQVEfC1ZfCQz0xB3g")]
[Description(@"Card writing capabilities of the terminal performing the transaction. ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9")]
[DerivedFrom(typeof(CardDataReadingCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardDataWriting2Code>))]
public enum CardDataWriting2Code
{
    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as &quot;ICPY&quot;.
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_ekUN4RQVEfC1ZfCQz0xB3g")]
    [Description(@"ICC contactless proximity")]
    ICCProximity = CardDataReadingCode.ICCProximity,

    /// <summary>
    /// Magnetic stripe is read, only partial data is available.
    /// Encoded/decoded by serializers as &quot;MGSP&quot;.
    /// </summary>
    [EnumMember(Value = "MGSP")]
    [IsoId("_ekUN4xQVEfC1ZfCQz0xB3g")]
    [Description(@"Magnetic stripe is read, only partial data is available.")]
    MagneticStripePartial = CardDataReadingCode.MagneticStripePartial,

    /// <summary>
    /// Integrated circuit card read; only partial data is available.
    /// Encoded/decoded by serializers as &quot;ICCP&quot;.
    /// </summary>
    [EnumMember(Value = "ICCP")]
    [IsoId("_ekUN5RQVEfC1ZfCQz0xB3g")]
    [Description(@"Integrated circuit card read; only partial data is available.")]
    ICCContactPartial = CardDataReadingCode.ICCContactPartial,

    /// <summary>
    /// Magstripe image contactless proximity
    /// Encoded/decoded by serializers as &quot;MSIP&quot;.
    /// </summary>
    [EnumMember(Value = "MSIP")]
    [IsoId("_ekUN5xQVEfC1ZfCQz0xB3g")]
    [Description(@"Magstripe image contactless proximity")]
    MSIProximity = CardDataReadingCode.MSIProximity,

    /// <summary>
    /// Unspecified capability.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_ekUN6xQVEfC1ZfCQz0xB3g")]
    [Description(@"Unspecified capability.")]
    Unspecified = CardDataReadingCode.Unspecified,

    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_BGFHoXFyEfC68Y4jZPNEug")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe,

    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as &quot;ICCY&quot;.
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_EaPnEXFyEfC68Y4jZPNEug")]
    [Description(@"ICC contact capability")]
    ICCContact = CardDataReadingCode.ICCContact,
}
