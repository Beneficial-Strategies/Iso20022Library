// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet data pertaining to the payment transaction.
/// </summary>
[IsoId("_OghhAUYkEfCJpvfyM9roFQ")]
[DisplayName("Fleet Data7")]
public record FleetData7
{
    /// <summary>
    /// Contains driver-related information.
    /// </summary>
    [IsoId("_OjEesUYkEfCJpvfyM9roFQ")]
    [DisplayName("Driver")]
    [IsoXmlTag("Drvr")]
    public FleetDriverData2? Driver { get; init; }

    /// <summary>
    /// Vehicle belonging to the fleet.
    /// </summary>
    [IsoId("_OjEes0YkEfCJpvfyM9roFQ")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public FleetVehicleData1? Vehicle { get; init; }

    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_OjEetUYkEfCJpvfyM9roFQ")]
    [DisplayName("Driver Or Vehicle Card")]
    [IsoXmlTag("DrvrOrVhclCard")]
    public DriverOrVehicleCardData1? DriverOrVehicleCard { get; init; }

    /// <summary>
    /// Indicates whether or not fuel or fleet data prompting should occur.
    /// </summary>
    [IsoId("_OjEet0YkEfCJpvfyM9roFQ")]
    [DisplayName("Card Fuel Prompt Code")]
    [IsoXmlTag("CardFuelPrmptCd")]
    public IsoMax1Number? CardFuelPromptCode { get; init; }

    /// <summary>
    /// An identification code assigned by an agent.
    /// </summary>
    [IsoId("_OjEeuUYkEfCJpvfyM9roFQ")]
    [DisplayName("Agent Fuel Prompt Code")]
    [IsoXmlTag("AgtFuelPrmptCd")]
    public IsoMax35Text? AgentFuelPromptCode { get; init; }

    /// <summary>
    /// Identification number of the trip.
    /// </summary>
    [IsoId("_OjEeu0YkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    public IsoMax35Text? TripNumber { get; init; }

    /// <summary>
    /// Contains an indicator identifying the job or task identifier of the individual.
    /// </summary>
    [IsoId("_OjEevUYkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Job Number")]
    [IsoXmlTag("TripJobNb")]
    public IsoMax10Text? TripJobNumber { get; init; }

    /// <summary>
    /// Contains the work order or purchase order number.
    /// </summary>
    [IsoId("_OjEev0YkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Work Order")]
    [IsoXmlTag("TripWorkOrdr")]
    public IsoMax70Text? TripWorkOrder { get; init; }

    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_OjEewUYkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Invoice Number")]
    [IsoXmlTag("TripInvcNb")]
    public IsoMax70Text? TripInvoiceNumber { get; init; }

    /// <summary>
    /// Contains the billing identification number.
    /// </summary>
    [IsoId("_OjEew0YkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Billing Identification")]
    [IsoXmlTag("TripBllgId")]
    public IsoMax70Text? TripBillingIdentification { get; init; }

    /// <summary>
    /// Identification number assigned by an agent.
    /// </summary>
    [IsoId("_OjEexUYkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Control Number")]
    [IsoXmlTag("TripCtrlNb")]
    public IsoMax35Text? TripControlNumber { get; init; }

    /// <summary>
    /// Delivery Ticket Number for the trip information.
    /// </summary>
    [IsoId("_OjEex0YkEfCJpvfyM9roFQ")]
    [DisplayName("Trip Delivery Ticket Number")]
    [IsoXmlTag("TripDlvryTcktNb")]
    public IsoMax35Text? TripDeliveryTicketNumber { get; init; }

    /// <summary>
    /// Indicates the amenities available at the location where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_OjEeyUYkEfCJpvfyM9roFQ")]
    [DisplayName("Local Amenity")]
    [IsoXmlTag("LclAmnty")]
    public ValueList<LocalAmenity2> LocalAmenity { get; init; } = [];

    /// <summary>
    /// Contains information related specifically to the transaction.
    /// </summary>
    [IsoId("_OjEey0YkEfCJpvfyM9roFQ")]
    [DisplayName("Transaction Related Data")]
    [IsoXmlTag("TxRltdData")]
    public ValueList<FleetTransactionDetail2> TransactionRelatedData { get; init; } = [];

    /// <summary>
    /// Contains additional fleet summary data.
    /// </summary>
    [IsoId("_OjEezUYkEfCJpvfyM9roFQ")]
    [DisplayName("Additional Entered Data")]
    [IsoXmlTag("AddtlNtrdData")]
    public AdditionalEnteredFleetData1? AdditionalEnteredData { get; init; }

    /// <summary>
    /// A value to indicate the discount method applied to a transaction.
    /// </summary>
    [IsoId("_PpJocFBVEfC5WMyGsBx7PA")]
    [DisplayName("Discount Method")]
    [IsoXmlTag("DscntMtd")]
    public IsoMax4AlphaNumericText? DiscountMethod { get; init; }

    /// <summary>
    /// Contains any of these codes to identify the entity who calculated discount.
    /// </summary>
    [IsoId("_tooegFBWEfC5WMyGsBx7PA")]
    [DisplayName("Discount Entity")]
    [IsoXmlTag("DscntNtty")]
    public ATICAPartyType1Code? DiscountEntity { get; init; }

    /// <summary>
    /// Contains a value to identify discount plan applied to a transaction.
    /// </summary>
    [IsoId("_2aD34FBWEfC5WMyGsBx7PA")]
    [DisplayName("Discount Plan Identification")]
    [IsoXmlTag("DscntPlanId")]
    public IsoMax35Text? DiscountPlanIdentification { get; init; }

    /// <summary>
    /// Indicate if the card acceptor supports purchase control override at POS.
    /// </summary>
    [IsoId("_RqJWMFBdEfC5WMyGsBx7PA")]
    [DisplayName("Purchase Restriction Indicator")]
    [IsoXmlTag("PurchsRstrctnInd")]
    public IsoExact1Text? PurchaseRestrictionIndicator { get; init; }

    /// <summary>
    /// Fleet Line Item component to carry detail level fleet data.
    /// </summary>
    [IsoId("_OjEez0YkEfCJpvfyM9roFQ")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<FleetLineItem7> LineItem { get; init; } = [];
}
