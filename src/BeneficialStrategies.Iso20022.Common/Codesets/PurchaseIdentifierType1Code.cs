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
[IsoId("_e3_SAPJQEeiJn9rM2Znz2w")]
[Description(@"Identifies the type of identifier used in the Purchase Identifier field. ")]
[DerivedFrom(typeof(PurchaseIdentifierTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PurchaseIdentifierType1Code>))]
#endif
public enum PurchaseIdentifierType1Code
{
    /// <summary>
    /// Contract Number
    /// Encoded/decoded by serializers as &quot;CONU&quot;.
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_gqOrsfJQEeiJn9rM2Znz2w")]
    [Description(@"Contract Number")]
    ContractNumber = PurchaseIdentifierTypeCode.ContractNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Order
    /// Encoded/decoded by serializers as &quot;CUOR&quot;.
    /// </summary>
    [EnumMember(Value = "CUOR")]
    [IsoId("_gwj9MfJQEeiJn9rM2Znz2w")]
    [Description(@"Customer Order")]
    CustomerOrder = PurchaseIdentifierTypeCode.CustomerOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Purchase Order
    /// Encoded/decoded by serializers as &quot;CUPO&quot;.
    /// </summary>
    [EnumMember(Value = "CUPO")]
    [IsoId("_g0ZUUfJQEeiJn9rM2Znz2w")]
    [Description(@"Customer Purchase Order")]
    CustomerPurchaseOrder = PurchaseIdentifierTypeCode.CustomerPurchaseOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Folio Number
    /// Encoded/decoded by serializers as &quot;FONU&quot;.
    /// </summary>
    [EnumMember(Value = "FONU")]
    [IsoId("_g4ApAfJQEeiJn9rM2Znz2w")]
    [Description(@"Folio Number")]
    FolioNumber = PurchaseIdentifierTypeCode.FolioNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invoice Number
    /// Encoded/decoded by serializers as &quot;INNU&quot;.
    /// </summary>
    [EnumMember(Value = "INNU")]
    [IsoId("_g7xHofJQEeiJn9rM2Znz2w")]
    [Description(@"Invoice Number")]
    InvoiceNumber = PurchaseIdentifierTypeCode.InvoiceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order Number
    /// Encoded/decoded by serializers as &quot;ORNU&quot;.
    /// </summary>
    [EnumMember(Value = "ORNU")]
    [IsoId("_hAyKgfJQEeiJn9rM2Znz2w")]
    [Description(@"Order Number")]
    OrderNumber = PurchaseIdentifierTypeCode.OrderNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Purchase Identifier defined at a national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_hSflkfJQEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a national level.")]
    OtherNational = PurchaseIdentifierTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Purchase Identifier defined at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_hYff4fJQEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a private level.")]
    OtherPrivate = PurchaseIdentifierTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment Reference Number
    /// Encoded/decoded by serializers as &quot;PRNU&quot;.
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_hb288fJQEeiJn9rM2Znz2w")]
    [Description(@"Payment Reference Number")]
    PaymentReferenceNumber = PurchaseIdentifierTypeCode.PaymentReferenceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Purchase Identification
    /// Encoded/decoded by serializers as &quot;PUID&quot;.
    /// </summary>
    [EnumMember(Value = "PUID")]
    [IsoId("_hfKvofJQEeiJn9rM2Znz2w")]
    [Description(@"Purchase Identification")]
    PurchaseIdentification = PurchaseIdentifierTypeCode.PurchaseIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record Locator
    /// Encoded/decoded by serializers as &quot;RELO&quot;.
    /// </summary>
    [EnumMember(Value = "RELO")]
    [IsoId("_hioTUfJQEeiJn9rM2Znz2w")]
    [Description(@"Record Locator")]
    RecordLocator = PurchaseIdentifierTypeCode.RecordLocator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rental Agreement
    /// Encoded/decoded by serializers as &quot;REAG&quot;.
    /// </summary>
    [EnumMember(Value = "REAG")]
    [IsoId("_hmAXcfJQEeiJn9rM2Znz2w")]
    [Description(@"Rental Agreement")]
    RentalAgreement = PurchaseIdentifierTypeCode.RentalAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rental Number
    /// Encoded/decoded by serializers as &quot;RENU&quot;.
    /// </summary>
    [EnumMember(Value = "RENU")]
    [IsoId("_hpS8AfJQEeiJn9rM2Znz2w")]
    [Description(@"Rental Number")]
    RentalNumber = PurchaseIdentifierTypeCode.RentalNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reservation Number
    /// Encoded/decoded by serializers as &quot;RSNU&quot;.
    /// </summary>
    [EnumMember(Value = "RSNU")]
    [IsoId("_hs1_QfJQEeiJn9rM2Znz2w")]
    [Description(@"Reservation Number")]
    ReservationNumber = PurchaseIdentifierTypeCode.ReservationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplier Order
    /// Encoded/decoded by serializers as &quot;SUOR&quot;.
    /// </summary>
    [EnumMember(Value = "SUOR")]
    [IsoId("_hxaWMfJQEeiJn9rM2Znz2w")]
    [Description(@"Supplier Order")]
    SupplierOrder = PurchaseIdentifierTypeCode.SupplierOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticket Number
    /// Encoded/decoded by serializers as &quot;TINU&quot;.
    /// </summary>
    [EnumMember(Value = "TINU")]
    [IsoId("_h0zBYfJQEeiJn9rM2Znz2w")]
    [Description(@"Ticket Number ")]
    TicketNumber = PurchaseIdentifierTypeCode.TicketNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tracking Number
    /// Encoded/decoded by serializers as &quot;TRNU&quot;.
    /// </summary>
    [EnumMember(Value = "TRNU")]
    [IsoId("_h4l8QfJQEeiJn9rM2Znz2w")]
    [Description(@"Tracking Number")]
    TrackingNumber = PurchaseIdentifierTypeCode.TrackingNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplier Invoice
    /// Encoded/decoded by serializers as &quot;SUIN&quot;.
    /// </summary>
    [EnumMember(Value = "SUIN")]
    [IsoId("_iJh7QfJQEeiJn9rM2Znz2w")]
    [Description(@"Supplier Invoice")]
    SupplierInvoice = PurchaseIdentifierTypeCode.SupplierInvoice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction.
    /// Encoded/decoded by serializers as &quot;TNID&quot;.
    /// </summary>
    [EnumMember(Value = "TNID")]
    [IsoId("_iPBfQfJQEeiJn9rM2Znz2w")]
    [Description(
        @"Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction. "
    )]
    TransactionIdentification = PurchaseIdentifierTypeCode.TransactionIdentification, // same ordinal as derivation source for type conversions
}
