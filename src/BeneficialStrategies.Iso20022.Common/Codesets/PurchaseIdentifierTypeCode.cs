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
[IsoId("_dsO7g_JOEeiJn9rM2Znz2w")]
[Description(@"Identifies the type of identifier used in the Purchase Identifier field. ")]
[Derivations(typeof(PurchaseIdentifierType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PurchaseIdentifierTypeCode>))]
#endif
public enum PurchaseIdentifierTypeCode
{
    /// <summary>
    /// Other Purchase Identifier defined at a national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_dsO7kfJOEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a national level.")]
    OtherNational,

    /// <summary>
    /// Other Purchase Identifier defined at a private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dsO7iPJOEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a private level.")]
    OtherPrivate,

    /// <summary>
    /// Supplier Invoice
    /// Encoded/decoded by serializers as &quot;SUIN&quot;.
    /// </summary>
    [EnumMember(Value = "SUIN")]
    [IsoId("_dsO7ivJOEeiJn9rM2Znz2w")]
    [Description(@"Supplier Invoice")]
    SupplierInvoice,

    /// <summary>
    /// Record Locator
    /// Encoded/decoded by serializers as &quot;RELO&quot;.
    /// </summary>
    [EnumMember(Value = "RELO")]
    [IsoId("_dsO7j_JOEeiJn9rM2Znz2w")]
    [Description(@"Record Locator")]
    RecordLocator,

    /// <summary>
    /// Invoice Number
    /// Encoded/decoded by serializers as &quot;INNU&quot;.
    /// </summary>
    [EnumMember(Value = "INNU")]
    [IsoId("_dsPigfJOEeiJn9rM2Znz2w")]
    [Description(@"Invoice Number")]
    InvoiceNumber,

    /// <summary>
    /// Purchase Identification
    /// Encoded/decoded by serializers as &quot;PUID&quot;.
    /// </summary>
    [EnumMember(Value = "PUID")]
    [IsoId("_dsO7hPJOEeiJn9rM2Znz2w")]
    [Description(@"Purchase Identification")]
    PurchaseIdentification,

    /// <summary>
    /// Rental Number
    /// Encoded/decoded by serializers as &quot;RENU&quot;.
    /// </summary>
    [EnumMember(Value = "RENU")]
    [IsoId("_dsPigvJOEeiJn9rM2Znz2w")]
    [Description(@"Rental Number")]
    RentalNumber,

    /// <summary>
    /// Reservation Number
    /// Encoded/decoded by serializers as &quot;RSNU&quot;.
    /// </summary>
    [EnumMember(Value = "RSNU")]
    [IsoId("_dsO7hvJOEeiJn9rM2Znz2w")]
    [Description(@"Reservation Number")]
    ReservationNumber,

    /// <summary>
    /// Ticket Number
    /// Encoded/decoded by serializers as &quot;TINU&quot;.
    /// </summary>
    [EnumMember(Value = "TINU")]
    [IsoId("_dsPigPJOEeiJn9rM2Znz2w")]
    [Description(@"Ticket Number ")]
    TicketNumber,

    /// <summary>
    /// Supplier Order
    /// Encoded/decoded by serializers as &quot;SUOR&quot;.
    /// </summary>
    [EnumMember(Value = "SUOR")]
    [IsoId("_dsO7ifJOEeiJn9rM2Znz2w")]
    [Description(@"Supplier Order")]
    SupplierOrder,

    /// <summary>
    /// Contract Number
    /// Encoded/decoded by serializers as &quot;CONU&quot;.
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_dsO7hfJOEeiJn9rM2Znz2w")]
    [Description(@"Contract Number")]
    ContractNumber,

    /// <summary>
    /// Folio Number
    /// Encoded/decoded by serializers as &quot;FONU&quot;.
    /// </summary>
    [EnumMember(Value = "FONU")]
    [IsoId("_dsPig_JOEeiJn9rM2Znz2w")]
    [Description(@"Folio Number")]
    FolioNumber,

    /// <summary>
    /// Payment Reference Number
    /// Encoded/decoded by serializers as &quot;PRNU&quot;.
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_dsO7i_JOEeiJn9rM2Znz2w")]
    [Description(@"Payment Reference Number")]
    PaymentReferenceNumber,

    /// <summary>
    /// Order Number
    /// Encoded/decoded by serializers as &quot;ORNU&quot;.
    /// </summary>
    [EnumMember(Value = "ORNU")]
    [IsoId("_dsO7jPJOEeiJn9rM2Znz2w")]
    [Description(@"Order Number")]
    OrderNumber,

    /// <summary>
    /// Customer Order
    /// Encoded/decoded by serializers as &quot;CUOR&quot;.
    /// </summary>
    [EnumMember(Value = "CUOR")]
    [IsoId("_dsO7jvJOEeiJn9rM2Znz2w")]
    [Description(@"Customer Order")]
    CustomerOrder,

    /// <summary>
    /// Customer Purchase Order
    /// Encoded/decoded by serializers as &quot;CUPO&quot;.
    /// </summary>
    [EnumMember(Value = "CUPO")]
    [IsoId("_dsO7kPJOEeiJn9rM2Znz2w")]
    [Description(@"Customer Purchase Order")]
    CustomerPurchaseOrder,

    /// <summary>
    /// Rental Agreement
    /// Encoded/decoded by serializers as &quot;REAG&quot;.
    /// </summary>
    [EnumMember(Value = "REAG")]
    [IsoId("_dsO7h_JOEeiJn9rM2Znz2w")]
    [Description(@"Rental Agreement")]
    RentalAgreement,

    /// <summary>
    /// Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction.
    /// Encoded/decoded by serializers as &quot;TNID&quot;.
    /// </summary>
    [EnumMember(Value = "TNID")]
    [IsoId("_jPodIPJPEeiJn9rM2Znz2w")]
    [Description(
        @"Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction. "
    )]
    TransactionIdentification,

    /// <summary>
    /// Tracking Number
    /// Encoded/decoded by serializers as &quot;TRNU&quot;.
    /// </summary>
    [EnumMember(Value = "TRNU")]
    [IsoId("_l4c5gPJPEeiJn9rM2Znz2w")]
    [Description(@"Tracking Number")]
    TrackingNumber,
}
