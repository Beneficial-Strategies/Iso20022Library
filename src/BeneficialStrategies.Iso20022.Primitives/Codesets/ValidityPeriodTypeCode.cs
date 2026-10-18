// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type used for the validity period of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iF36MGscEe25qph5Y8_eYQ")]
[Description(@"Specifies the type used for the validity period of the order.")]
[Derivations(typeof(ValidityPeriodType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ValidityPeriodTypeCode>))]
public enum ValidityPeriodTypeCode
{
    /// <summary>
    /// Order expiring at the end of the trading day on which it was entered in the order book.
    /// Encoded/decoded by serializers as &quot;DAVY&quot;.
    /// </summary>
    [EnumMember(Value = "DAVY")]
    [IsoId("_nfnmEGscEe25qph5Y8_eYQ")]
    [Description(@"Order expiring at the end of the trading day on which it was entered in the order book.")]
    GoodForDay,

    /// <summary>
    /// Orde executed upon its entering into the order book provided that it can be fully filled (e.g. in the event the order can only be partially executed, then it is automatically rejected and cannot therefore be executed).
    /// Encoded/decoded by serializers as &quot;FOKV&quot;.
    /// </summary>
    [EnumMember(Value = "FOKV")]
    [IsoId("_ANhqQGsdEe25qph5Y8_eYQ")]
    [Description(@"Orde executed upon its entering into the order book provided that it can be fully filled (e.g. in the event the order can only be partially executed, then it is automatically rejected and cannot therefore be executed).")]
    FillOrKill,

    /// <summary>
    /// Order being active only from the beginning of a pre-determined date.
    /// Encoded/decoded by serializers as &quot;GADV&quot;.
    /// </summary>
    [EnumMember(Value = "GADV")]
    [IsoId("_2dbCIGscEe25qph5Y8_eYQ")]
    [Description(@"Order being active only from the beginning of a pre-determined date.")]
    GoodAfterDate,

    /// <summary>
    /// Order being active only from a pre-determined time on a pre-determined date.
    /// Encoded/decoded by serializers as &quot;GASV&quot;.
    /// </summary>
    [EnumMember(Value = "GASV")]
    [IsoId("_4XjzkGscEe25qph5Y8_eYQ")]
    [Description(@"Order being active only from a pre-determined time on a pre-determined date.")]
    GoodAfterSpecifiedDateTime,

    /// <summary>
    /// Order being active only after a pre-determined time within the current trading session.
    /// Encoded/decoded by serializers as &quot;GATV&quot;.
    /// </summary>
    [EnumMember(Value = "GATV")]
    [IsoId("_zeQiUGscEe25qph5Y8_eYQ")]
    [Description(@"Order being active only after a pre-determined time within the current trading session.")]
    GoodAfterTime,

    /// <summary>
    /// Order remaining active in the order book and be executable until it is actually cancelled
    /// Encoded/decoded by serializers as &quot;GTCV&quot;.
    /// </summary>
    [EnumMember(Value = "GTCV")]
    [IsoId("_qLWzkGscEe25qph5Y8_eYQ")]
    [Description(@"Order remaining active in the order book and be executable until it is actually cancelled")]
    GoodTillCancelled,

    /// <summary>
    /// Order expiring at the end of a specified date.
    /// Encoded/decoded by serializers as &quot;GTDV&quot;.
    /// </summary>
    [EnumMember(Value = "GTDV")]
    [IsoId("_vDNTUGscEe25qph5Y8_eYQ")]
    [Description(@"Order expiring at the end of a specified date.")]
    GoodTillDate,

    /// <summary>
    /// Order expiring at a specified date and time.
    /// Encoded/decoded by serializers as &quot;GTSV&quot;.
    /// </summary>
    [EnumMember(Value = "GTSV")]
    [IsoId("_wZUKoGscEe25qph5Y8_eYQ")]
    [Description(@"Order expiring at a specified date and time.")]
    GoodTillSpecifiedDateTime,

    /// <summary>
    /// Order expiring at the latest at a pre-determined time within the current trading session.
    /// Encoded/decoded by serializers as &quot;GTTV&quot;.
    /// </summary>
    [EnumMember(Value = "GTTV")]
    [IsoId("_tGhkMGscEe25qph5Y8_eYQ")]
    [Description(@"Order expiring at the latest at a pre-determined time within the current trading session.")]
    GoodTillTime,

    /// <summary>
    /// Order executed upon its entering into the order book (for the quantity that can be executed) and which does not remain in the order book for the remaining quantity (if any) that has not been executed.
    /// Encoded/decoded by serializers as &quot;IOCV&quot;.
    /// </summary>
    [EnumMember(Value = "IOCV")]
    [IsoId("_8a2C0GscEe25qph5Y8_eYQ")]
    [Description(@"Order executed upon its entering into the order book (for the quantity that can be executed) and which does not remain in the order book for the remaining quantity (if any) that has not been executed.")]
    ImmediateOrCancel,
}
