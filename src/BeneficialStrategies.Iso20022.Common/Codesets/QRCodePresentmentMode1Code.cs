// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the mode used to present a QR Code for a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9c9dgMV3Eeua2vd9tJAtHg")]
[Description(@"Identifies the mode used to present a QR Code for a transaction.")]
[DerivedFrom(typeof(QRCodePresentmentModeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<QRCodePresentmentMode1Code>))]
#endif
public enum QRCodePresentmentMode1Code
{
    /// <summary>
    /// The consumer presented a QR Code at the point of service for the transaction.
    /// Encoded/decoded by serializers as &quot;CPMD&quot;.
    /// </summary>
    [EnumMember(Value = "CPMD")]
    [IsoId("_CPnUMcV4Eeua2vd9tJAtHg")]
    [Description(@"The consumer presented a QR Code at the point of service for the transaction.")]
    ConsumerPresented = QRCodePresentmentModeCode.ConsumerPresented, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other nationally defined method for QR Code presentment for the transaction.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_CwAEccV4Eeua2vd9tJAtHg")]
    [Description(@"Other nationally defined method for QR Code presentment for the transaction.")]
    OtherNational = QRCodePresentmentModeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other QR Code presentment mode defined by bilateral agreement.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_DGIFccV4Eeua2vd9tJAtHg")]
    [Description(@"Other QR Code presentment mode defined by bilateral agreement.")]
    OtherPrivate = QRCodePresentmentModeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The acceptor presented a QR Code to the consumer for the transaction.
    /// Encoded/decoded by serializers as &quot;MPMD&quot;.
    /// </summary>
    [EnumMember(Value = "MPMD")]
    [IsoId("_DGuiYcV4Eeua2vd9tJAtHg")]
    [Description(@"The acceptor presented a QR Code to the consumer for the transaction.")]
    MerchantPresented = QRCodePresentmentModeCode.MerchantPresented, // same ordinal as derivation source for type conversions
}
