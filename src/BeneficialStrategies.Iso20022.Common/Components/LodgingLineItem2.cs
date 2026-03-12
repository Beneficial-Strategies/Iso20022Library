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
[IsoId("_Z6ldASCDEey8XKHwKquEQw")]
[DisplayName("Lodging Line Item")]
public partial record LodgingLineItem2
{
    #nullable enable
    
    /// <summary>
    /// Date of the charge for the product or service associated with the line item. 
    /// </summary>
    [IsoId("_Z_7QASCDEey8XKHwKquEQw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Time of the charge for the product or service associated with the line item. 
    /// </summary>
    [IsoId("_Z_7QAyCDEey8XKHwKquEQw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    /// <summary>
    /// Type of product or service associated with the line item. 
    /// </summary>
    [IsoId("_Z_7QBSCDEey8XKHwKquEQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public LodgingService1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of product or service associated with the line item. 
    /// </summary>
    [IsoId("_Z_7QByCDEey8XKHwKquEQw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the charge originated following the checkout. 
    /// </summary>
    [IsoId("_Z_7QCSCDEey8XKHwKquEQw")]
    [DisplayName("Post Check Out Indicator")]
    [IsoXmlTag("PstChckOutInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PostCheckOutIndicator { get; init; } 
    
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_gq1IUTapEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    /// <summary>
    /// Contains the cost for one unit of the product or service.
    /// </summary>
    [IsoId("_Z_7QDSCDEey8XKHwKquEQw")]
    [DisplayName("Unit Amount")]
    [IsoXmlTag("UnitAmt")]
    public ImpliedCurrencyAndAmount? UnitAmount { get; init; } 
    
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_Z_7QDyCDEey8XKHwKquEQw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; } 
    
    /// <summary>
    /// Subtotal amount of line item.  (e.g. total nightly rate, etc.)
    /// </summary>
    [IsoId("_Z_7QESCDEey8XKHwKquEQw")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ImpliedCurrencyAndAmount? SubTotalAmount { get; init; } 
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_Z_7QEyCDEey8XKHwKquEQw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; } 
    
    /// <summary>
    /// Additional data.
    /// </summary>
    [IsoId("_Z_7QFSCDEey8XKHwKquEQw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
