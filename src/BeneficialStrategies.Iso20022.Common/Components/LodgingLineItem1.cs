// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging line item details
/// </summary>
[IsoId("_sR3mqvcZEeiW-auGnDPZIw")]
[DisplayName("Lodging Line Item")]
public partial record LodgingLineItem1
{
    #nullable enable
    
    /// <summary>
    /// Date of the charge for the product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3mq_cZEeiW-auGnDPZIw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Time of the charge for the product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3msPcZEeiW-auGnDPZIw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    /// <summary>
    /// Type of product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3muvcZEeiW-auGnDPZIw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public LodgingService1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of product or service associated with the line item. 
    /// </summary>
    [IsoId("_sR3mt_cZEeiW-auGnDPZIw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the charge originated following the checkout. 
    /// </summary>
    [IsoId("_sR3msvcZEeiW-auGnDPZIw")]
    [DisplayName("Post Check Out Indicator")]
    [IsoXmlTag("PstChckOutInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PostCheckOutIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the line item is a credit amount.
    /// </summary>
    [IsoId("_sR3mwPcZEeiW-auGnDPZIw")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    
    /// <summary>
    /// Contains the cost for one unit of the product or service.
    /// </summary>
    [IsoId("_sR3mw_cZEeiW-auGnDPZIw")]
    [DisplayName("Unit Amount")]
    [IsoXmlTag("UnitAmt")]
    public ImpliedCurrencyAndAmount? UnitAmount { get; init; } 
    
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_GDYK4fccEeiW-auGnDPZIw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; } 
    
    /// <summary>
    /// Subtotal amount of line item.  (e.g. total nightly rate, etc.)
    /// </summary>
    [IsoId("_sR3mv_cZEeiW-auGnDPZIw")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; init; } 
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_sR3mtPcZEeiW-auGnDPZIw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax33? Tax { get; init; } 
    
    /// <summary>
    /// Additional data.
    /// </summary>
    [IsoId("_sR3mtvcZEeiW-auGnDPZIw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
