// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Criteria for a query about securities reference data.
/// </summary>
[IsoId("_QETUpZJKEeuAlLVx8pyt3w")]
[DisplayName("Securities Search Criteria")]
public partial record SecuritiesSearchCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_QGUG0ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_QGUG05JKEeuAlLVx8pyt3w")]
    [DisplayName("Classification Financial Instrument")]
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; } 
    
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_QGUG1ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DatePeriodSearch1Choice_? MaturityDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the security was made available.
    /// </summary>
    [IsoId("_QGUG6ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public DatePeriodSearch1Choice_? IssueDate { get; init; } 
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_QGUG65JKEeuAlLVx8pyt3w")]
    [DisplayName("Issue Currency")]
    [IsoXmlTag("IsseCcy")]
    public ActiveOrHistoricCurrencyCode? IssueCurrency { get; init; } 
    
    /// <summary>
    /// Primary market or country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_QGUG85JKEeuAlLVx8pyt3w")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public CountryCode? CountryOfIssue { get; init; } 
    
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_QGUG-5JKEeuAlLVx8pyt3w")]
    [DisplayName("Security Status")]
    [IsoXmlTag("SctySts")]
    public SecurityStatus3Choice_? SecurityStatus { get; init; } 
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_QGUHA5JKEeuAlLVx8pyt3w")]
    [DisplayName("Maintaining CSD")]
    [IsoXmlTag("MntngCSD")]
    public SystemPartyIdentification2Choice_? MaintainingCSD { get; init; } 
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_QGUHBZJKEeuAlLVx8pyt3w")]
    [DisplayName("Investor CSD")]
    [IsoXmlTag("InvstrCSD")]
    public SystemPartyIdentification2Choice_? InvestorCSD { get; init; } 
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_QGUHB5JKEeuAlLVx8pyt3w")]
    [DisplayName("Issuer CSD")]
    [IsoXmlTag("IssrCSD")]
    public SystemPartyIdentification2Choice_? IssuerCSD { get; init; } 
    
    /// <summary>
    /// Technical issuer of a security.
    /// </summary>
    [IsoId("_QGUHCZJKEeuAlLVx8pyt3w")]
    [DisplayName("Technical Issuer CSD")]
    [IsoXmlTag("TechIssrCSD")]
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 
    
    /// <summary>
    /// CSD of a security.
    /// </summary>
    [IsoId("_QGUHC5JKEeuAlLVx8pyt3w")]
    [DisplayName("CSD")]
    [IsoXmlTag("CSD")]
    public SystemPartyIdentification2Choice_? CSD { get; init; } 
    
    
    #nullable disable
    
}
