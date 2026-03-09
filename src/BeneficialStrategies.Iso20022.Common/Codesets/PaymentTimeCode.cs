// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z73xQ9p-Ed-ak6NoX_4Aeg_-2012418215")]
[Description(@"Specifies the payment conditions.")]
[Derivations(typeof(PaymentTime1Code),typeof(PaymentTime2Code),typeof(PaymentTime3Code),typeof(PaymentTime4Code))]
public enum PaymentTimeCode
{
    /// <summary>
    /// Code for payment on delivery.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z73xRNp-Ed-ak6NoX_4Aeg_-1967166215")]
    [Description(@"Code for payment on delivery.")]
    PaymentOnDelivery,
    
    /// <summary>
    /// Code for payment at end of month of delivery.
    /// Encoded/decoded by serializers as &quot;EMTD&quot;.
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_Z73xRdp-Ed-ak6NoX_4Aeg_-1155391143")]
    [Description(@"Code for payment at end of month of delivery.")]
    EndOfMonthOfDelivery,
    
    /// <summary>
    /// Code for payment at end of period after delivery.
    /// Encoded/decoded by serializers as &quot;EPRD&quot;.
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_Z73xRtp-Ed-ak6NoX_4Aeg_-1040874060")]
    [Description(@"Code for payment at end of period after delivery.")]
    EndOfPeriodAfterDelivery,
    
    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// Encoded/decoded by serializers as &quot;PRMD&quot;.
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_Z73xR9p-Ed-ak6NoX_4Aeg_-765666214")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    EndOfPeriodAfterEndOfDeliveryMonth,
    
    /// <summary>
    /// Code for payment on receipt of invoice.
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_Z73xSNp-Ed-ak6NoX_4Aeg_-292822159")]
    [Description(@"Code for payment on receipt of invoice.")]
    PaymentOnReceiptOfInvoice,
    
    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;PRMR&quot;.
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_Z73xSdp-Ed-ak6NoX_4Aeg_-1538322044")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    EndOfPeriodAfterEndOfReceiptMonth,
    
    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EPRR&quot;.
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_Z8A7MNp-Ed-ak6NoX_4Aeg_-1538322027")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EndOfPeriodAfterReceipt,
    
    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_Z8A7Mdp-Ed-ak6NoX_4Aeg_-1538322009")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EndOfMonthOfReceipt,
    
    /// <summary>
    /// Code for payment at end of period after match or mismatch acceptance.
    /// Encoded/decoded by serializers as &quot;EPAM&quot;.
    /// </summary>
    [EnumMember(Value = "EPAM")]
    [IsoId("_Z8A7Mtp-Ed-ak6NoX_4Aeg_-582673899")]
    [Description(@"Code for payment at end of period after match or mismatch acceptance.")]
    EndOfPeriodAfterMatch,
    
    /// <summary>
    /// Payment at end of period after shipment date.
    /// Encoded/decoded by serializers as &quot;EPSD&quot;.
    /// </summary>
    [EnumMember(Value = "EPSD")]
    [IsoId("_diO1wNP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after shipment date.")]
    EndOfPeriodAfterShipmentDate,
    
    /// <summary>
    /// Payment at end of period after purchase order date.
    /// Encoded/decoded by serializers as &quot;EPPO&quot;.
    /// </summary>
    [EnumMember(Value = "EPPO")]
    [IsoId("_l0Ld0NP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after purchase order date.")]
    EndOfPeriodAfterPurchaseOrderDate,
    
    /// <summary>
    /// Payment at end of period after baseline establishment date.
    /// Encoded/decoded by serializers as &quot;EPBE&quot;.
    /// </summary>
    [EnumMember(Value = "EPBE")]
    [IsoId("_sXidINP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after baseline establishment date.")]
    EndOfPeriodAfterBaselineEstablishment,
    
    /// <summary>
    /// Payment at end of period after invoice date.
    /// Encoded/decoded by serializers as &quot;EPIN&quot;.
    /// </summary>
    [EnumMember(Value = "EPIN")]
    [IsoId("_z9m2oNP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after invoice date.")]
    EndOfPeriodAfterInvoiceDate,
    
}
