// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the mode used to present a QR Code for a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JsWoAMV3Eeua2vd9tJAtHg")]
[Description(@"Identifies the mode used to present a QR Code for a transaction.")]
[Derivations(typeof(QRCodePresentmentMode1Code))]
public enum QRCodePresentmentModeCode
{
    /// <summary>
    /// The consumer presented a QR Code at the point of service for the transaction.
    /// Encoded/decoded by serializers as &quot;CPMD&quot;.
    /// </summary>
    [EnumMember(Value = "CPMD")]
    [IsoId("_Y7sgAMV3Eeua2vd9tJAtHg")]
    [Description(@"The consumer presented a QR Code at the point of service for the transaction.")]
    ConsumerPresented,

    /// <summary>
    /// The acceptor presented a QR Code to the consumer for the transaction.
    /// Encoded/decoded by serializers as &quot;MPMD&quot;.
    /// </summary>
    [EnumMember(Value = "MPMD")]
    [IsoId("_fYdIEMV3Eeua2vd9tJAtHg")]
    [Description(@"The acceptor presented a QR Code to the consumer for the transaction.")]
    MerchantPresented,

    /// <summary>
    /// Other nationally defined method for QR Code presentment for the transaction.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_uyBTEMV3Eeua2vd9tJAtHg")]
    [Description(@"Other nationally defined method for QR Code presentment for the transaction.")]
    OtherNational,

    /// <summary>
    /// Other QR Code presentment mode defined by bilateral agreement.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_1ojtEMV3Eeua2vd9tJAtHg")]
    [Description(@"Other QR Code presentment mode defined by bilateral agreement.")]
    OtherPrivate,
}
