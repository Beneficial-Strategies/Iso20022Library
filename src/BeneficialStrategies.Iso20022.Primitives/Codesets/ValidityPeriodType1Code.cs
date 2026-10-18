// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code defining the conditions under which an order becomes active or is removed from an orderbook.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HUYzoGvrEe2Re-GccwOX8g")]
[Description(@"Code defining the conditions under which an order becomes active or is removed from an orderbook.")]
[DerivedFrom(typeof(ValidityPeriodTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ValidityPeriodType1Code>))]
public enum ValidityPeriodType1Code
{
    /// <summary>
    /// Order expiring at the end of the trading day on which it was entered in the order book.
    /// Encoded/decoded by serializers as &quot;DAVY&quot;.
    /// </summary>
    [EnumMember(Value = "DAVY")]
    [IsoId("__HHawWvrEe2Re-GccwOX8g")]
    [Description(@"Order expiring at the end of the trading day on which it was entered in the order book.")]
    GoodForDay = ValidityPeriodTypeCode.GoodForDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Orde executed upon its entering into the order book provided that it can be fully filled (e.g. in the event the order can only be partially executed, then it is automatically rejected and cannot therefore be executed).
    /// Encoded/decoded by serializers as &quot;FOKV&quot;.
    /// </summary>
    [EnumMember(Value = "FOKV")]
    [IsoId("_IOd2QWvrEe2Re-GccwOX8g")]
    [Description(@"Orde executed upon its entering into the order book provided that it can be fully filled (e.g. in the event the order can only be partially executed, then it is automatically rejected and cannot therefore be executed).")]
    FillOrKill = ValidityPeriodTypeCode.FillOrKill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order being active only from the beginning of a pre-determined date.
    /// Encoded/decoded by serializers as &quot;GADV&quot;.
    /// </summary>
    [EnumMember(Value = "GADV")]
    [IsoId("_IVJGAWvrEe2Re-GccwOX8g")]
    [Description(@"Order being active only from the beginning of a pre-determined date.")]
    GoodAfterDate = ValidityPeriodTypeCode.GoodAfterDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order being active only from a pre-determined time on a pre-determined date.
    /// Encoded/decoded by serializers as &quot;GASV&quot;.
    /// </summary>
    [EnumMember(Value = "GASV")]
    [IsoId("_IbEH0WvrEe2Re-GccwOX8g")]
    [Description(@"Order being active only from a pre-determined time on a pre-determined date.")]
    GoodAfterSpecifiedDateTime = ValidityPeriodTypeCode.GoodAfterSpecifiedDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order being active only after a pre-determined time within the current trading session.
    /// Encoded/decoded by serializers as &quot;GATV&quot;.
    /// </summary>
    [EnumMember(Value = "GATV")]
    [IsoId("_IgpycWvrEe2Re-GccwOX8g")]
    [Description(@"Order being active only after a pre-determined time within the current trading session.")]
    GoodAfterTime = ValidityPeriodTypeCode.GoodAfterTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order remaining active in the order book and be executable until it is actually cancelled
    /// Encoded/decoded by serializers as &quot;GTCV&quot;.
    /// </summary>
    [EnumMember(Value = "GTCV")]
    [IsoId("__PkzMWvrEe2Re-GccwOX8g")]
    [Description(@"Order remaining active in the order book and be executable until it is actually cancelled")]
    GoodTillCancelled = ValidityPeriodTypeCode.GoodTillCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order expiring at the end of a specified date.
    /// Encoded/decoded by serializers as &quot;GTDV&quot;.
    /// </summary>
    [EnumMember(Value = "GTDV")]
    [IsoId("__WxAUWvrEe2Re-GccwOX8g")]
    [Description(@"Order expiring at the end of a specified date.")]
    GoodTillDate = ValidityPeriodTypeCode.GoodTillDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order expiring at a specified date and time.
    /// Encoded/decoded by serializers as &quot;GTSV&quot;.
    /// </summary>
    [EnumMember(Value = "GTSV")]
    [IsoId("__eVn8WvrEe2Re-GccwOX8g")]
    [Description(@"Order expiring at a specified date and time.")]
    GoodTillSpecifiedDateTime = ValidityPeriodTypeCode.GoodTillSpecifiedDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order expiring at the latest at a pre-determined time within the current trading session.
    /// Encoded/decoded by serializers as &quot;GTTV&quot;.
    /// </summary>
    [EnumMember(Value = "GTTV")]
    [IsoId("__o3c8WvrEe2Re-GccwOX8g")]
    [Description(@"Order expiring at the latest at a pre-determined time within the current trading session.")]
    GoodTillTime = ValidityPeriodTypeCode.GoodTillTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order executed upon its entering into the order book (for the quantity that can be executed) and which does not remain in the order book for the remaining quantity (if any) that has not been executed.
    /// Encoded/decoded by serializers as &quot;IOCV&quot;.
    /// </summary>
    [EnumMember(Value = "IOCV")]
    [IsoId("__1LaoWvrEe2Re-GccwOX8g")]
    [Description(@"Order executed upon its entering into the order book (for the quantity that can be executed) and which does not remain in the order book for the remaining quantity (if any) that has not been executed.")]
    ImmediateOrCancel = ValidityPeriodTypeCode.ImmediateOrCancel, // same ordinal as derivation source for type conversions
}
