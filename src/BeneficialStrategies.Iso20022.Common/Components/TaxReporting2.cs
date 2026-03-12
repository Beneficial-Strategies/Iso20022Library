// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for tax reporting.
/// </summary>
[IsoId("_1U4BwUN2EeaS-NnwLNvMPg")]
[DisplayName("Tax Reporting")]
public partial record TaxReporting2
{
    #nullable enable
    
    /// <summary>
    /// Country of taxation of the organisation or individual person.
    /// </summary>
    [IsoId("_1uKrgUN2EeaS-NnwLNvMPg")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public required CountryCode TaxationCountry { get; init; } 
    
    /// <summary>
    /// Tax rate to be applied.
    /// </summary>
    [IsoId("_1uKrg0N2EeaS-NnwLNvMPg")]
    [DisplayName("Tax Rate")]
    [IsoXmlTag("TaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxRate { get; init; } 
    
    /// <summary>
    /// Party that pays the tax.
    /// </summary>
    [IsoId("_1uKrhUN2EeaS-NnwLNvMPg")]
    [DisplayName("Tax Payer")]
    [IsoXmlTag("TaxPyer")]
    public PartyIdentification70Choice_? TaxPayer { get; init; } 
    
    /// <summary>
    /// Party that receives the tax.
    /// </summary>
    [IsoId("_1uKrh0N2EeaS-NnwLNvMPg")]
    [DisplayName("Tax Recipient")]
    [IsoXmlTag("TaxRcpt")]
    public PartyIdentification70Choice_? TaxRecipient { get; init; } 
    
    /// <summary>
    /// Cash account information for the payment of tax.
    /// </summary>
    [IsoId("_1uKriUN2EeaS-NnwLNvMPg")]
    [DisplayName("Cash Account Details")]
    [IsoXmlTag("CshAcctDtls")]
    public CashAccount33? CashAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information for the reporting of tax.
    /// </summary>
    [IsoId("_1uKri0N2EeaS-NnwLNvMPg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; } 
    
    
    #nullable disable
    
}
