// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of identifier used in the Purchase Identifier field.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cCE84WPxEfCX7uJiAWHfoQ")]
[Description(@"Identifies the type of identifier used in the Purchase Identifier field.")]
[DerivedFrom(typeof(PurchaseIdentifierTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PurchaseIdentifierType3Code>))]
public enum PurchaseIdentifierType3Code
{
    /// <summary>
    /// Contract Number
    /// Encoded/decoded by serializers as &quot;CONU&quot;.
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_cEpv1WPxEfCX7uJiAWHfoQ")]
    [Description(@"Contract Number")]
    ContractNumber = PurchaseIdentifierTypeCode.ContractNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Order
    /// Encoded/decoded by serializers as &quot;CUOR&quot;.
    /// </summary>
    [EnumMember(Value = "CUOR")]
    [IsoId("_cEpv3WPxEfCX7uJiAWHfoQ")]
    [Description(@"Customer Order")]
    CustomerOrder = PurchaseIdentifierTypeCode.CustomerOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Purchase Order
    /// Encoded/decoded by serializers as &quot;CUPO&quot;.
    /// </summary>
    [EnumMember(Value = "CUPO")]
    [IsoId("_cEpv32PxEfCX7uJiAWHfoQ")]
    [Description(@"Customer Purchase Order")]
    CustomerPurchaseOrder = PurchaseIdentifierTypeCode.CustomerPurchaseOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Folio Number
    /// Encoded/decoded by serializers as &quot;FONU&quot;.
    /// </summary>
    [EnumMember(Value = "FONU")]
    [IsoId("_cEpv12PxEfCX7uJiAWHfoQ")]
    [Description(@"Folio Number")]
    FolioNumber = PurchaseIdentifierTypeCode.FolioNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invoice Number
    /// Encoded/decoded by serializers as &quot;INNU&quot;.
    /// </summary>
    [EnumMember(Value = "INNU")]
    [IsoId("_cEpvyWPxEfCX7uJiAWHfoQ")]
    [Description(@"Invoice Number")]
    InvoiceNumber = PurchaseIdentifierTypeCode.InvoiceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order Number
    /// Encoded/decoded by serializers as &quot;ORNU&quot;.
    /// </summary>
    [EnumMember(Value = "ORNU")]
    [IsoId("_cEpv22PxEfCX7uJiAWHfoQ")]
    [Description(@"Order Number")]
    OrderNumber = PurchaseIdentifierTypeCode.OrderNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment Reference Number
    /// Encoded/decoded by serializers as &quot;PRNU&quot;.
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_cEpv2WPxEfCX7uJiAWHfoQ")]
    [Description(@"Payment Reference Number")]
    PaymentReferenceNumber = PurchaseIdentifierTypeCode.PaymentReferenceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase Identification
    /// Encoded/decoded by serializers as &quot;PUID&quot;.
    /// </summary>
    [EnumMember(Value = "PUID")]
    [IsoId("_cEpvy2PxEfCX7uJiAWHfoQ")]
    [Description(@"Purchase Identification")]
    PurchaseIdentification = PurchaseIdentifierTypeCode.PurchaseIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rental Agreement
    /// Encoded/decoded by serializers as &quot;REAG&quot;.
    /// </summary>
    [EnumMember(Value = "REAG")]
    [IsoId("_cEpv4WPxEfCX7uJiAWHfoQ")]
    [Description(@"Rental Agreement")]
    RentalAgreement = PurchaseIdentifierTypeCode.RentalAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record Locator
    /// Encoded/decoded by serializers as &quot;RELO&quot;.
    /// </summary>
    [EnumMember(Value = "RELO")]
    [IsoId("_cEpvx2PxEfCX7uJiAWHfoQ")]
    [Description(@"Record Locator")]
    RecordLocator = PurchaseIdentifierTypeCode.RecordLocator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rental Number
    /// Encoded/decoded by serializers as &quot;RENU&quot;.
    /// </summary>
    [EnumMember(Value = "RENU")]
    [IsoId("_cEpvzWPxEfCX7uJiAWHfoQ")]
    [Description(@"Rental Number")]
    RentalNumber = PurchaseIdentifierTypeCode.RentalNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation Number
    /// Encoded/decoded by serializers as &quot;RSNU&quot;.
    /// </summary>
    [EnumMember(Value = "RSNU")]
    [IsoId("_cEpvz2PxEfCX7uJiAWHfoQ")]
    [Description(@"Reservation Number")]
    ReservationNumber = PurchaseIdentifierTypeCode.ReservationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplier Invoice
    /// Encoded/decoded by serializers as &quot;SUIN&quot;.
    /// </summary>
    [EnumMember(Value = "SUIN")]
    [IsoId("_cEpvxWPxEfCX7uJiAWHfoQ")]
    [Description(@"Supplier Invoice")]
    SupplierInvoice = PurchaseIdentifierTypeCode.SupplierInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplier Order
    /// Encoded/decoded by serializers as &quot;SUOR&quot;.
    /// </summary>
    [EnumMember(Value = "SUOR")]
    [IsoId("_cEpv02PxEfCX7uJiAWHfoQ")]
    [Description(@"Supplier Order")]
    SupplierOrder = PurchaseIdentifierTypeCode.SupplierOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticket Number
    /// Encoded/decoded by serializers as &quot;TINU&quot;.
    /// </summary>
    [EnumMember(Value = "TINU")]
    [IsoId("_cEpv0WPxEfCX7uJiAWHfoQ")]
    [Description(@"Ticket Number")]
    TicketNumber = PurchaseIdentifierTypeCode.TicketNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Reference
    /// Encoded/decoded by serializers as &quot;TREF&quot;.
    /// </summary>
    [EnumMember(Value = "TREF")]
    [IsoId("_cEpv5WPxEfCX7uJiAWHfoQ")]
    [Description(@"Transaction Reference")]
    TransactionReference = PurchaseIdentifierTypeCode.TransactionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tracking Number
    /// Encoded/decoded by serializers as &quot;TRNU&quot;.
    /// </summary>
    [EnumMember(Value = "TRNU")]
    [IsoId("_cEpv42PxEfCX7uJiAWHfoQ")]
    [Description(@"Tracking Number")]
    TrackingNumber = PurchaseIdentifierTypeCode.TrackingNumber, // same ordinal as derivation source for type conversions
}
