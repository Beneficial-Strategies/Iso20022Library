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
[IsoId("_bphVAW6aEe6DxcrvCrq6hQ")]
[Description(@"Identifies the type of identifier used in the Purchase Identifier field.")]
[DerivedFrom(typeof(PurchaseIdentifierTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PurchaseIdentifierType2Code>))]
public enum PurchaseIdentifierType2Code
{
    /// <summary>
    /// Contract Number
    /// Encoded/decoded by serializers as &quot;CONU&quot;.
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_i6j5xW6aEe6DxcrvCrq6hQ")]
    [Description(@"Contract Number")]
    ContractNumber = PurchaseIdentifierTypeCode.ContractNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Order
    /// Encoded/decoded by serializers as &quot;CUOR&quot;.
    /// </summary>
    [EnumMember(Value = "CUOR")]
    [IsoId("_i6j5zW6aEe6DxcrvCrq6hQ")]
    [Description(@"Customer Order")]
    CustomerOrder = PurchaseIdentifierTypeCode.CustomerOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Purchase Order
    /// Encoded/decoded by serializers as &quot;CUPO&quot;.
    /// </summary>
    [EnumMember(Value = "CUPO")]
    [IsoId("_i6j5z26aEe6DxcrvCrq6hQ")]
    [Description(@"Customer Purchase Order")]
    CustomerPurchaseOrder = PurchaseIdentifierTypeCode.CustomerPurchaseOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Folio Number
    /// Encoded/decoded by serializers as &quot;FONU&quot;.
    /// </summary>
    [EnumMember(Value = "FONU")]
    [IsoId("_i6j5x26aEe6DxcrvCrq6hQ")]
    [Description(@"Folio Number")]
    FolioNumber = PurchaseIdentifierTypeCode.FolioNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invoice Number
    /// Encoded/decoded by serializers as &quot;INNU&quot;.
    /// </summary>
    [EnumMember(Value = "INNU")]
    [IsoId("_i6j5uW6aEe6DxcrvCrq6hQ")]
    [Description(@"Invoice Number")]
    InvoiceNumber = PurchaseIdentifierTypeCode.InvoiceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order Number
    /// Encoded/decoded by serializers as &quot;ORNU&quot;.
    /// </summary>
    [EnumMember(Value = "ORNU")]
    [IsoId("_i6j5y26aEe6DxcrvCrq6hQ")]
    [Description(@"Order Number")]
    OrderNumber = PurchaseIdentifierTypeCode.OrderNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Purchase Identifier defined at a national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_i6j5sW6aEe6DxcrvCrq6hQ")]
    [Description(@"Other Purchase Identifier defined at a national level.")]
    OtherNational = PurchaseIdentifierTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Purchase Identifier defined at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_i6j5s26aEe6DxcrvCrq6hQ")]
    [Description(@"Other Purchase Identifier defined at a private level.")]
    OtherPrivate = PurchaseIdentifierTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment Reference Number
    /// Encoded/decoded by serializers as &quot;PRNU&quot;.
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_i6j5yW6aEe6DxcrvCrq6hQ")]
    [Description(@"Payment Reference Number")]
    PaymentReferenceNumber = PurchaseIdentifierTypeCode.PaymentReferenceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase Identification
    /// Encoded/decoded by serializers as &quot;PUID&quot;.
    /// </summary>
    [EnumMember(Value = "PUID")]
    [IsoId("_i6j5u26aEe6DxcrvCrq6hQ")]
    [Description(@"Purchase Identification")]
    PurchaseIdentification = PurchaseIdentifierTypeCode.PurchaseIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rental Agreement
    /// Encoded/decoded by serializers as &quot;REAG&quot;.
    /// </summary>
    [EnumMember(Value = "REAG")]
    [IsoId("_i6j50W6aEe6DxcrvCrq6hQ")]
    [Description(@"Rental Agreement")]
    RentalAgreement = PurchaseIdentifierTypeCode.RentalAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record Locator
    /// Encoded/decoded by serializers as &quot;RELO&quot;.
    /// </summary>
    [EnumMember(Value = "RELO")]
    [IsoId("_i6j5t26aEe6DxcrvCrq6hQ")]
    [Description(@"Record Locator")]
    RecordLocator = PurchaseIdentifierTypeCode.RecordLocator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rental Number
    /// Encoded/decoded by serializers as &quot;RENU&quot;.
    /// </summary>
    [EnumMember(Value = "RENU")]
    [IsoId("_i6j5vW6aEe6DxcrvCrq6hQ")]
    [Description(@"Rental Number")]
    RentalNumber = PurchaseIdentifierTypeCode.RentalNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation Number
    /// Encoded/decoded by serializers as &quot;RSNU&quot;.
    /// </summary>
    [EnumMember(Value = "RSNU")]
    [IsoId("_i6j5v26aEe6DxcrvCrq6hQ")]
    [Description(@"Reservation Number")]
    ReservationNumber = PurchaseIdentifierTypeCode.ReservationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplier Invoice
    /// Encoded/decoded by serializers as &quot;SUIN&quot;.
    /// </summary>
    [EnumMember(Value = "SUIN")]
    [IsoId("_i6j5tW6aEe6DxcrvCrq6hQ")]
    [Description(@"Supplier Invoice")]
    SupplierInvoice = PurchaseIdentifierTypeCode.SupplierInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplier Order
    /// Encoded/decoded by serializers as &quot;SUOR&quot;.
    /// </summary>
    [EnumMember(Value = "SUOR")]
    [IsoId("_i6j5w26aEe6DxcrvCrq6hQ")]
    [Description(@"Supplier Order")]
    SupplierOrder = PurchaseIdentifierTypeCode.SupplierOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticket Number
    /// Encoded/decoded by serializers as &quot;TINU&quot;.
    /// </summary>
    [EnumMember(Value = "TINU")]
    [IsoId("_i6j5wW6aEe6DxcrvCrq6hQ")]
    [Description(@"Ticket Number")]
    TicketNumber = PurchaseIdentifierTypeCode.TicketNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Reference
    /// Encoded/decoded by serializers as &quot;TREF&quot;.
    /// </summary>
    [EnumMember(Value = "TREF")]
    [IsoId("_F-3xAW6bEe6DxcrvCrq6hQ")]
    [Description(@"Transaction Reference")]
    TransactionReference = PurchaseIdentifierTypeCode.TransactionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tracking Number
    /// Encoded/decoded by serializers as &quot;TRNU&quot;.
    /// </summary>
    [EnumMember(Value = "TRNU")]
    [IsoId("_i6j51W6aEe6DxcrvCrq6hQ")]
    [Description(@"Tracking Number")]
    TrackingNumber = PurchaseIdentifierTypeCode.TrackingNumber, // same ordinal as derivation source for type conversions
}
