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
[IsoId("_Hv_IASd9EfCJ9IDAfAjwLA")]
[Description(@"Identifies the mode used to present a QR Code for a transaction.")]
[DerivedFrom(typeof(QRCodePresentmentModeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<QRCodePresentmentMode2Code>))]
public enum QRCodePresentmentMode2Code
{
    /// <summary>
    /// The consumer presented a QR Code at the point of service for the transaction.
    /// Encoded/decoded by serializers as &quot;CPMD&quot;.
    /// </summary>
    [EnumMember(Value = "CPMD")]
    [IsoId("_HyYUsSd9EfCJ9IDAfAjwLA")]
    [Description(@"The consumer presented a QR Code at the point of service for the transaction.")]
    ConsumerPresented = QRCodePresentmentModeCode.ConsumerPresented, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The acceptor presented a QR Code to the consumer for the transaction.
    /// Encoded/decoded by serializers as &quot;MPMD&quot;.
    /// </summary>
    [EnumMember(Value = "MPMD")]
    [IsoId("_HyYUtyd9EfCJ9IDAfAjwLA")]
    [Description(@"The acceptor presented a QR Code to the consumer for the transaction.")]
    MerchantPresented = QRCodePresentmentModeCode.MerchantPresented, // same ordinal as derivation source for type conversions
}
