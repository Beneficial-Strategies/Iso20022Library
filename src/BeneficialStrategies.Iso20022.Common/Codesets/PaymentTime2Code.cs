// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z7uAQtp-Ed-ak6NoX_4Aeg_1319644743")]
[Description(@"Specifies the payment conditions.")]
[DerivedFrom(typeof(PaymentTimeCode))]
public enum PaymentTime2Code
{
    /// <summary>
    /// Code for payment on delivery.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z7uAQ9p-Ed-ak6NoX_4Aeg_1319644773")]
    [Description(@"Code for payment on delivery.")]
    PaymentOnDelivery = PaymentTimeCode.PaymentOnDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of month of delivery.
    /// Encoded/decoded by serializers as &quot;EMTD&quot;.
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_Z7uARNp-Ed-ak6NoX_4Aeg_1319644774")]
    [Description(@"Code for payment at end of month of delivery.")]
    EndOfMonthOfDelivery = PaymentTimeCode.EndOfMonthOfDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after delivery.
    /// Encoded/decoded by serializers as &quot;EPRD&quot;.
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_Z7uARdp-Ed-ak6NoX_4Aeg_1319644804")]
    [Description(@"Code for payment at end of period after delivery.")]
    EndOfPeriodAfterDelivery = PaymentTimeCode.EndOfPeriodAfterDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// Encoded/decoded by serializers as &quot;PRMD&quot;.
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_Z7uARtp-Ed-ak6NoX_4Aeg_1319645052")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    EndOfPeriodAfterEndOfDeliveryMonth = PaymentTimeCode.EndOfPeriodAfterEndOfDeliveryMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment on receipt of invoice.
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_Z7uAR9p-Ed-ak6NoX_4Aeg_1319645053")]
    [Description(@"Code for payment on receipt of invoice.")]
    PaymentOnReceiptOfInvoice = PaymentTimeCode.PaymentOnReceiptOfInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;PRMR&quot;.
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_Z7uASNp-Ed-ak6NoX_4Aeg_1319645082")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    EndOfPeriodAfterEndOfReceiptMonth = PaymentTimeCode.EndOfPeriodAfterEndOfReceiptMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EPRR&quot;.
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_Z73xQNp-Ed-ak6NoX_4Aeg_1319645083")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EndOfPeriodAfterReceipt = PaymentTimeCode.EndOfPeriodAfterReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_Z73xQdp-Ed-ak6NoX_4Aeg_1319645113")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EndOfMonthOfReceipt = PaymentTimeCode.EndOfMonthOfReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after match or mismatch acceptance.
    /// Encoded/decoded by serializers as &quot;EPAM&quot;.
    /// </summary>
    [EnumMember(Value = "EPAM")]
    [IsoId("_Z73xQtp-Ed-ak6NoX_4Aeg_1348277168")]
    [Description(@"Code for payment at end of period after match or mismatch acceptance.")]
    EndOfPeriodAfterMatch = PaymentTimeCode.EndOfPeriodAfterMatch, // same ordinal as derivation source for type conversions
}
