// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vla3MBVeEeOrY9qSHVspCA")]
[Description(@"Specifies the payment conditions.")]
[DerivedFrom(typeof(PaymentTimeCode))]
public enum PaymentTime4Code
{
    /// <summary>
    /// Code for payment on receipt of invoice.
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_w_H1ERVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment on receipt of invoice.")]
    PaymentOnReceiptOfInvoice = PaymentTimeCode.PaymentOnReceiptOfInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment on delivery.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_xGRl8RVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment on delivery.")]
    PaymentOnDelivery = PaymentTimeCode.PaymentOnDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment at end of period after shipment date.
    /// Encoded/decoded by serializers as &quot;EPSD&quot;.
    /// </summary>
    [EnumMember(Value = "EPSD")]
    [IsoId("_xPEVkRVeEeOrY9qSHVspCA")]
    [Description(@"Payment at end of period after shipment date.")]
    EndOfPeriodAfterShipmentDate = PaymentTimeCode.EndOfPeriodAfterShipmentDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EPRR&quot;.
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_xYA2MRVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EndOfPeriodAfterReceipt = PaymentTimeCode.EndOfPeriodAfterReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment at end of period after purchase order date.
    /// Encoded/decoded by serializers as &quot;EPPO&quot;.
    /// </summary>
    [EnumMember(Value = "EPPO")]
    [IsoId("_xgDX4RVeEeOrY9qSHVspCA")]
    [Description(@"Payment at end of period after purchase order date.")]
    EndOfPeriodAfterPurchaseOrderDate = PaymentTimeCode.EndOfPeriodAfterPurchaseOrderDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment at end of period after invoice date.
    /// Encoded/decoded by serializers as &quot;EPIN&quot;.
    /// </summary>
    [EnumMember(Value = "EPIN")]
    [IsoId("_xqyBMRVeEeOrY9qSHVspCA")]
    [Description(@"Payment at end of period after invoice date.")]
    EndOfPeriodAfterInvoiceDate = PaymentTimeCode.EndOfPeriodAfterInvoiceDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;PRMR&quot;.
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_x1EloRVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    EndOfPeriodAfterEndOfReceiptMonth = PaymentTimeCode.EndOfPeriodAfterEndOfReceiptMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// Encoded/decoded by serializers as &quot;PRMD&quot;.
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_x8OWgRVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    EndOfPeriodAfterEndOfDeliveryMonth = PaymentTimeCode.EndOfPeriodAfterEndOfDeliveryMonth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment at end of period after delivery.
    /// Encoded/decoded by serializers as &quot;EPRD&quot;.
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_yDYHYRVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment at end of period after delivery.")]
    EndOfPeriodAfterDelivery = PaymentTimeCode.EndOfPeriodAfterDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment at end of period after baseline establishment date.
    /// Encoded/decoded by serializers as &quot;EPBE&quot;.
    /// </summary>
    [EnumMember(Value = "EPBE")]
    [IsoId("_yKOWQRVeEeOrY9qSHVspCA")]
    [Description(@"Payment at end of period after baseline establishment date.")]
    EndOfPeriodAfterBaselineEstablishment = PaymentTimeCode.EndOfPeriodAfterBaselineEstablishment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_yRO9MRVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EndOfMonthOfReceipt = PaymentTimeCode.EndOfMonthOfReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for payment at end of month of delivery.
    /// Encoded/decoded by serializers as &quot;EMTD&quot;.
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_yYFMERVeEeOrY9qSHVspCA")]
    [Description(@"Code for payment at end of month of delivery.")]
    EndOfMonthOfDelivery = PaymentTimeCode.EndOfMonthOfDelivery, // same ordinal as derivation source for type conversions
    
}
