// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_56RpYNP7EeK0PPbKncCqzA")]
[Description(@"Specifies the payment conditions.")]
[DerivedFrom(typeof(PaymentTimeCode))]
public enum PaymentTime3Code
{
    /// <summary>
    /// Code for payment at end of month of delivery.
    /// Encoded/decoded by serializers as &quot;EMTD&quot;.
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_8br2MdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of month of delivery.")]
    EndOfMonthOfDelivery = PaymentTimeCode.EndOfMonthOfDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_8j-2kdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EndOfMonthOfReceipt = PaymentTimeCode.EndOfMonthOfReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment at end of period after baseline establishment date.
    /// Encoded/decoded by serializers as &quot;EPBE&quot;.
    /// </summary>
    [EnumMember(Value = "EPBE")]
    [IsoId("_8sXWgdP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after baseline establishment date.")]
    EndOfPeriodAfterBaselineEstablishment = PaymentTimeCode.EndOfPeriodAfterBaselineEstablishment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after delivery.
    /// Encoded/decoded by serializers as &quot;EPRD&quot;.
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_80nTkdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of period after delivery.")]
    EndOfPeriodAfterDelivery = PaymentTimeCode.EndOfPeriodAfterDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// Encoded/decoded by serializers as &quot;PRMD&quot;.
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_882CgdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    EndOfPeriodAfterEndOfDeliveryMonth = PaymentTimeCode.EndOfPeriodAfterEndOfDeliveryMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;PRMR&quot;.
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_9FOicdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    EndOfPeriodAfterEndOfReceiptMonth = PaymentTimeCode.EndOfPeriodAfterEndOfReceiptMonth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment at end of period after invoice date.
    /// Encoded/decoded by serializers as &quot;EPIN&quot;.
    /// </summary>
    [EnumMember(Value = "EPIN")]
    [IsoId("_9IkxYdP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after invoice date.")]
    EndOfPeriodAfterInvoiceDate = PaymentTimeCode.EndOfPeriodAfterInvoiceDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after match or mismatch acceptance.
    /// Encoded/decoded by serializers as &quot;EPAM&quot;.
    /// </summary>
    [EnumMember(Value = "EPAM")]
    [IsoId("_9P_A8dP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of period after match or mismatch acceptance.")]
    EndOfPeriodAfterMatch = PaymentTimeCode.EndOfPeriodAfterMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment at end of period after purchase order date.
    /// Encoded/decoded by serializers as &quot;EPPO&quot;.
    /// </summary>
    [EnumMember(Value = "EPPO")]
    [IsoId("_9dQA4dP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after purchase order date.")]
    EndOfPeriodAfterPurchaseOrderDate = PaymentTimeCode.EndOfPeriodAfterPurchaseOrderDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EPRR&quot;.
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_9leIwdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EndOfPeriodAfterReceipt = PaymentTimeCode.EndOfPeriodAfterReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment at end of period after shipment date.
    /// Encoded/decoded by serializers as &quot;EPSD&quot;.
    /// </summary>
    [EnumMember(Value = "EPSD")]
    [IsoId("_9tv7AdP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after shipment date.")]
    EndOfPeriodAfterShipmentDate = PaymentTimeCode.EndOfPeriodAfterShipmentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment on delivery.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_9xNesdP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment on delivery.")]
    PaymentOnDelivery = PaymentTimeCode.PaymentOnDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Code for payment on receipt of invoice.
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_94jc0dP7EeK0PPbKncCqzA")]
    [Description(@"Code for payment on receipt of invoice.")]
    PaymentOnReceiptOfInvoice = PaymentTimeCode.PaymentOnReceiptOfInvoice, // same ordinal as derivation source for type conversions
}
