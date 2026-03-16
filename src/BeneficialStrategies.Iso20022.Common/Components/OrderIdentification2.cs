// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Identification2.
/// </summary>
[IsoId("_7DweURATEe6N57R8Wekj-w")]
[DisplayName("Order Identification2")]
public partial record OrderIdentification2
{
    #nullable enable

    /// <summary>
    /// Date Of Receipt.
    /// </summary>
    [DisplayName("Date Of Receipt")]
    [IsoXmlTag("DtOfRct")]
    public IsoISODate? DateOfReceipt { get; init; } 

    /// <summary>
    /// Event Type.
    /// </summary>
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public OrderEventType1Choice_? EventType { get; init; } 

    /// <summary>
    /// Financial Instrument.
    /// </summary>
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required FinancialInstrument99Choice_ FinancialInstrument { get; init; } 

    /// <summary>
    /// Order Book Identification.
    /// </summary>
    [DisplayName("Order Book Identification")]
    [IsoXmlTag("OrdrBookId")]
    public required IsoMax35Text OrderBookIdentification { get; init; } 

    /// <summary>
    /// Order Identification.
    /// </summary>
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    public IsoMax50Text? OrderIdentification { get; init; } 

    /// <summary>
    /// Order Restriction.
    /// </summary>
    [DisplayName("Order Restriction")]
    [IsoXmlTag("OrdrRstrctn")]
    public ValueList<OrderRestriction1Choice_> OrderRestriction { get; init; } = [];

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public OrderPriority1? Priority { get; init; } 

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public required IsoPositiveNumber SequenceNumber { get; init; } 

    /// <summary>
    /// Time Stamp.
    /// </summary>
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public required IsoISODateTime TimeStamp { get; init; } 

    /// <summary>
    /// Trade Venue.
    /// </summary>
    [DisplayName("Trade Venue")]
    [IsoXmlTag("TradVn")]
    public required IsoMICIdentifier TradeVenue { get; init; } 

    /// <summary>
    /// Validity Date Time.
    /// </summary>
    [DisplayName("Validity Date Time")]
    [IsoXmlTag("VldtyDtTm")]
    public IsoISODateTime? ValidityDateTime { get; init; } 

    /// <summary>
    /// Validity Period.
    /// </summary>
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public ValidityPeriod1Choice_? ValidityPeriod { get; init; } 

    
    #nullable disable
    
}
