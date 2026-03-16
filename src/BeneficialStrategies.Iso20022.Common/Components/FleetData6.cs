// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet Data6.
/// </summary>
[IsoId("_XZUnwXNTEe6Y1uOeeiF_Eg")]
[DisplayName("Fleet Data6")]
public partial record FleetData6
{
    #nullable enable

    /// <summary>
    /// Additional Entered Data.
    /// </summary>
    [DisplayName("Additional Entered Data")]
    [IsoXmlTag("AddtlNtrdData")]
    public AdditionalInformation31? AdditionalEnteredData { get; init; } 

    /// <summary>
    /// Agent Fuel Prompt Code.
    /// </summary>
    [DisplayName("Agent Fuel Prompt Code")]
    [IsoXmlTag("AgtFuelPrmptCd")]
    public IsoMax35Text? AgentFuelPromptCode { get; init; } 

    /// <summary>
    /// Card Fuel Prompt Code.
    /// </summary>
    [DisplayName("Card Fuel Prompt Code")]
    [IsoXmlTag("CardFuelPrmptCd")]
    public IsoMax1Number? CardFuelPromptCode { get; init; } 

    /// <summary>
    /// Driver.
    /// </summary>
    [DisplayName("Driver")]
    [IsoXmlTag("Drvr")]
    public Driver3? Driver { get; init; } 

    /// <summary>
    /// Driver Or Vehicle Card.
    /// </summary>
    [DisplayName("Driver Or Vehicle Card")]
    [IsoXmlTag("DrvrOrVhclCard")]
    public PlainCardData23? DriverOrVehicleCard { get; init; } 

    /// <summary>
    /// Line Item.
    /// </summary>
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<FleetLineItem5> LineItem { get; init; } = [];

    /// <summary>
    /// Local Amenity.
    /// </summary>
    [DisplayName("Local Amenity")]
    [IsoXmlTag("LclAmnty")]
    public ValueList<LocalAmenity1> LocalAmenity { get; init; } = [];

    /// <summary>
    /// Transaction Related Data.
    /// </summary>
    [DisplayName("Transaction Related Data")]
    [IsoXmlTag("TxRltdData")]
    public ValueList<FleetTransactionDetail1> TransactionRelatedData { get; init; } = [];

    /// <summary>
    /// Trip Billing Identification.
    /// </summary>
    [DisplayName("Trip Billing Identification")]
    [IsoXmlTag("TripBllgId")]
    public IsoMax70Text? TripBillingIdentification { get; init; } 

    /// <summary>
    /// Trip Control Number.
    /// </summary>
    [DisplayName("Trip Control Number")]
    [IsoXmlTag("TripCtrlNb")]
    public IsoMax35Text? TripControlNumber { get; init; } 

    /// <summary>
    /// Trip Delivery Ticket Number.
    /// </summary>
    [DisplayName("Trip Delivery Ticket Number")]
    [IsoXmlTag("TripDlvryTcktNb")]
    public IsoMax35Text? TripDeliveryTicketNumber { get; init; } 

    /// <summary>
    /// Trip Invoice Number.
    /// </summary>
    [DisplayName("Trip Invoice Number")]
    [IsoXmlTag("TripInvcNb")]
    public IsoMax70Text? TripInvoiceNumber { get; init; } 

    /// <summary>
    /// Trip Job Number.
    /// </summary>
    [DisplayName("Trip Job Number")]
    [IsoXmlTag("TripJobNb")]
    public IsoMax10Text? TripJobNumber { get; init; } 

    /// <summary>
    /// Trip Number.
    /// </summary>
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    public IsoMax35Text? TripNumber { get; init; } 

    /// <summary>
    /// Trip Work Order.
    /// </summary>
    [DisplayName("Trip Work Order")]
    [IsoXmlTag("TripWorkOrdr")]
    public IsoMax70Text? TripWorkOrder { get; init; } 

    /// <summary>
    /// Vehicle.
    /// </summary>
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle6? Vehicle { get; init; } 

    
    #nullable disable
    
}
