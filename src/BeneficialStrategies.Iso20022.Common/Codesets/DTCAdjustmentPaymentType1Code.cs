// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_16HD8TL3EeKU9IrkkToqcw_819967480")]
[Description(@"Specified the type of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCAdjustmentPaymentType1Code>))]
#endif
public enum DTCAdjustmentPaymentType1Code
{
    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as &quot;STOK&quot;.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_16HD8jL3EeKU9IrkkToqcw_-1873975027")]
    [Description(@"Stock loan transaction.")]
    StockLoanPayment = DTCAdjustmentPaymentTypeCode.StockLoanPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_16HD8zL3EeKU9IrkkToqcw_-990741740")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoPayment = DTCAdjustmentPaymentTypeCode.RepoPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_16HD9DL3EeKU9IrkkToqcw_-1315859247")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailPayment = DTCAdjustmentPaymentTypeCode.FailPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_16HD9TL3EeKU9IrkkToqcw_-872870755")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousPayment = DTCAdjustmentPaymentTypeCode.MiscellaneousPayment, // same ordinal as derivation source for type conversions
}
