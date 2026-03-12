// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return criteria for information to be returned in the report deriving from a query about securities reference data.
/// </summary>
[IsoId("_hXQrSWliEeGaMcKyqKNRfQ_-1281740246")]
[DisplayName("Securities Return Criteria")]
public partial record SecuritiesReturnCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_hXQrSmliEeGaMcKyqKNRfQ_1355658104")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_hXQrS2liEeGaMcKyqKNRfQ_2109594347")]
    [DisplayName("ISO Security Long Name")]
    [IsoXmlTag("ISOSctyLngNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ISOSecurityLongName { get; init; } 
    
    /// <summary>
    /// Short name of the security expressed as ISO 18773/18774.
    /// </summary>
    [IsoId("_hXQrTGliEeGaMcKyqKNRfQ_1698752525")]
    [DisplayName("ISO Security Short Name")]
    [IsoXmlTag("ISOSctyShrtNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ISOSecurityShortName { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_hXQrTWliEeGaMcKyqKNRfQ_-1867260926")]
    [DisplayName("Classification Financial Instrument")]
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ClassificationFinancialInstrument { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_hXQrTmliEeGaMcKyqKNRfQ_1997846748")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator MaturityDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the security was made available.
    /// </summary>
    [IsoId("_hXQrT2liEeGaMcKyqKNRfQ_-847027990")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator IssueDate { get; init; } 
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_hXQrUGliEeGaMcKyqKNRfQ_-270251885")]
    [DisplayName("Issue Currency")]
    [IsoXmlTag("IsseCcy")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator IssueCurrency { get; init; } 
    
    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_hXQrUWliEeGaMcKyqKNRfQ_812960440")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator CountryOfIssue { get; init; } 
    
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_hXQrUmliEeGaMcKyqKNRfQ_-876696833")]
    [DisplayName("Security Status")]
    [IsoXmlTag("SctySts")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator SecurityStatus { get; init; } 
    
    /// <summary>
    /// CSD Investor of a security.
    /// </summary>
    [IsoId("_hXQrU2liEeGaMcKyqKNRfQ_-1284010832")]
    [DisplayName("Investor CSD")]
    [IsoXmlTag("InvstrCSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator InvestorCSD { get; init; } 
    
    /// <summary>
    /// CSD Issuer of a security.
    /// </summary>
    [IsoId("_hXQrVGliEeGaMcKyqKNRfQ_361256603")]
    [DisplayName("Issuer CSD")]
    [IsoXmlTag("IssrCSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator IssuerCSD { get; init; } 
    
    /// <summary>
    /// Technical issuer of a security.
    /// </summary>
    [IsoId("_hXQrVWliEeGaMcKyqKNRfQ_-1496901381")]
    [DisplayName("Technical Issuer CSD")]
    [IsoXmlTag("TechIssrCSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator TechnicalIssuerCSD { get; init; } 
    
    /// <summary>
    /// CSD of a security.
    /// </summary>
    [IsoId("_hXacQGliEeGaMcKyqKNRfQ_1152798480")]
    [DisplayName("CSD")]
    [IsoXmlTag("CSD")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator CSD { get; init; } 
    
    /// <summary>
    /// Quantity of a security.
    /// </summary>
    [IsoId("_hXacQWliEeGaMcKyqKNRfQ_-419471499")]
    [DisplayName("Securities Quantity Type")]
    [IsoXmlTag("SctiesQtyTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator SecuritiesQuantityType { get; init; } 
    
    /// <summary>
    /// Indicates the minimum quantity (unit or nominal) of a security.
    /// </summary>
    [IsoId("_hXacQmliEeGaMcKyqKNRfQ_912420582")]
    [DisplayName("Minimum Denomination")]
    [IsoXmlTag("MinDnmtn")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator MinimumDenomination { get; init; } 
    
    /// <summary>
    /// Minimum multiple quantity (unit or nominal) of securities.
    /// </summary>
    [IsoId("_hXacQ2liEeGaMcKyqKNRfQ_-2107680798")]
    [DisplayName("Minimum Multiple Quantity")]
    [IsoXmlTag("MinMltplQty")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator MinimumMultipleQuantity { get; init; } 
    
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_hXacRGliEeGaMcKyqKNRfQ_830858922")]
    [DisplayName("Deviating Settlement Unit")]
    [IsoXmlTag("DevtgSttlmUnit")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator DeviatingSettlementUnit { get; init; } 
    
    
    #nullable disable
    
}
