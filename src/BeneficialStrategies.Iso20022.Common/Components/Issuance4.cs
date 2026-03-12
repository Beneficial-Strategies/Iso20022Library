// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Preparation/bringing to market of a security (also known as primary market or Initial Public Offering (IPO) issuance).
/// </summary>
[IsoId("_SK5AleLcEeWFtOV72FbX9w")]
[DisplayName("Issuance")]
public partial record Issuance4
{
    #nullable enable
    
    /// <summary>
    /// Indicates where the financial instrument was issued.
    /// </summary>
    [IsoId("_SWDuweLcEeWFtOV72FbX9w")]
    [DisplayName("Issue Place")]
    [IsoXmlTag("IssePlc")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? IssuePlace { get; init; } 
    
    /// <summary>
    /// Country where a security is issued by the issuer or its agent.
    /// </summary>
    [IsoId("_SWDuz-LcEeWFtOV72FbX9w")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public CountryCode? CountryOfIssue { get; init; } 
    
    /// <summary>
    /// Date/time at which the security was made available.
    /// </summary>
    [IsoId("_SWDu1-LcEeWFtOV72FbX9w")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; } 
    
    /// <summary>
    /// Date/time, as announced by the issuer, at which the securities will be issued.
    /// </summary>
    [IsoId("_SWDu3-LcEeWFtOV72FbX9w")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_SWDu4eLcEeWFtOV72FbX9w")]
    [DisplayName("Issuer Organisation")]
    [IsoXmlTag("IssrOrg")]
    public Organisation27? IssuerOrganisation { get; init; } 
    
    /// <summary>
    /// Total original amount or quantity published.
    /// </summary>
    [IsoId("_SWDu4-LcEeWFtOV72FbX9w")]
    [DisplayName("Issue Nominal Amount")]
    [IsoXmlTag("IsseNmnlAmt")]
    public FinancialInstrumentQuantity1Choice_? IssueNominalAmount { get; init; } 
    
    /// <summary>
    /// Figure used as a control to verify whether the information provided is correct. It represents the issue size multiplied by the issue price.
    /// </summary>
    [IsoId("_SWDu5eLcEeWFtOV72FbX9w")]
    [DisplayName("Full Issued Amount")]
    [IsoXmlTag("FullIssdAmt")]
    public ActiveCurrencyAndAmount? FullIssuedAmount { get; init; } 
    
    /// <summary>
    /// Represents the total amount/quantity of the proceeds from the sale of all securities in the initial offering. This amount/quantity is known after the new issue is priced.
    /// </summary>
    [IsoId("_SWDu5-LcEeWFtOV72FbX9w")]
    [DisplayName("Issue Size")]
    [IsoXmlTag("IsseSz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? IssueSize { get; init; } 
    
    /// <summary>
    /// Initial issue price of the asset.
    /// </summary>
    [IsoId("_SWDu6eLcEeWFtOV72FbX9w")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceValue1? IssuePrice { get; init; } 
    
    /// <summary>
    /// Way in which the issue will be marketed to the primary market, via individual dealers (so called non syndicated distribution) or via a syndicate of managers, underwriters and selling group members (so called syndicated distribution).
    /// </summary>
    [IsoId("_SWDu6-LcEeWFtOV72FbX9w")]
    [DisplayName("Issuance Distribution")]
    [IsoXmlTag("IssncDstrbtn")]
    public SecuritiesTransactionType31Choice_? IssuanceDistribution { get; init; } 
    
    /// <summary>
    /// Jurisdiction (country, county, state, province, city) of the issue.
    /// </summary>
    [IsoId("_SWDu7eLcEeWFtOV72FbX9w")]
    [DisplayName("Governing Law")]
    [IsoXmlTag("GovngLaw")]
    public Jurisdiction1? GoverningLaw { get; init; } 
    
    
    #nullable disable
    
}
