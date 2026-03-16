// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z7kPQ9p-Ed-ak6NoX_4Aeg_381154806")]
[Description(@"Specifies the payment conditions.")]
[DerivedFrom(typeof(PaymentTimeCode))]
public enum PaymentTime1Code
{
    /// <summary>
    /// Code for payment on delivery.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z7kPRNp-Ed-ak6NoX_4Aeg_428253334")]
    [Description(@"Code for payment on delivery.")]
    PaymentOnDelivery = PaymentTimeCode.PaymentOnDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of month of delivery.
    /// Encoded/decoded by serializers as &quot;EMTD&quot;.
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_Z7kPRdp-Ed-ak6NoX_4Aeg_428253352")]
    [Description(@"Code for payment at end of month of delivery.")]
    EndOfMonthOfDelivery = PaymentTimeCode.EndOfMonthOfDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after delivery.
    /// Encoded/decoded by serializers as &quot;EPRD&quot;.
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_Z7kPRtp-Ed-ak6NoX_4Aeg_428253377")]
    [Description(@"Code for payment at end of period after delivery.")]
    EndOfPeriodAfterDelivery = PaymentTimeCode.EndOfPeriodAfterDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// Encoded/decoded by serializers as &quot;PRMD&quot;.
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_Z7kPR9p-Ed-ak6NoX_4Aeg_428253378")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    EndOfPeriodAfterEndOfDeliveryMonth = PaymentTimeCode.EndOfPeriodAfterEndOfDeliveryMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment on receipt of invoice.
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_Z7kPSNp-Ed-ak6NoX_4Aeg_428253394")]
    [Description(@"Code for payment on receipt of invoice.")]
    PaymentOnReceiptOfInvoice = PaymentTimeCode.PaymentOnReceiptOfInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;PRMR&quot;.
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_Z7kPSdp-Ed-ak6NoX_4Aeg_428253412")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    EndOfPeriodAfterEndOfReceiptMonth = PaymentTimeCode.EndOfPeriodAfterEndOfReceiptMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EPRR&quot;.
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_Z7uAQNp-Ed-ak6NoX_4Aeg_428253429")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EndOfPeriodAfterReceipt = PaymentTimeCode.EndOfPeriodAfterReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_Z7uAQdp-Ed-ak6NoX_4Aeg_428253447")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EndOfMonthOfReceipt = PaymentTimeCode.EndOfMonthOfReceipt, // same ordinal as derivation source for type conversions
}
