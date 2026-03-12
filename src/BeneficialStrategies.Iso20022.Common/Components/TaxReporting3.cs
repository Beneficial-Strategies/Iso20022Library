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
[IsoId("_fh93EZS6EemqYPWMBuVawg")]
[DisplayName("Tax Reporting")]
public partial record TaxReporting3
{
    #nullable enable
    
    /// <summary>
    /// Country of taxation of the organisation or individual person.
    /// </summary>
    [IsoId("_f1mkwZS6EemqYPWMBuVawg")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public required CountryCode TaxationCountry { get; init; } 
    
    /// <summary>
    /// Tax rate to be applied.
    /// </summary>
    [IsoId("_f1mkw5S6EemqYPWMBuVawg")]
    [DisplayName("Tax Rate")]
    [IsoXmlTag("TaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxRate { get; init; } 
    
    /// <summary>
    /// Party that pays the tax.
    /// </summary>
    [IsoId("_f1mkxZS6EemqYPWMBuVawg")]
    [DisplayName("Tax Payer")]
    [IsoXmlTag("TaxPyer")]
    public PartyIdentification125Choice_? TaxPayer { get; init; } 
    
    /// <summary>
    /// Party that receives the tax.
    /// </summary>
    [IsoId("_f1mkx5S6EemqYPWMBuVawg")]
    [DisplayName("Tax Recipient")]
    [IsoXmlTag("TaxRcpt")]
    public PartyIdentification125Choice_? TaxRecipient { get; init; } 
    
    /// <summary>
    /// Cash account information for the payment of tax.
    /// </summary>
    [IsoId("_f1mkyZS6EemqYPWMBuVawg")]
    [DisplayName("Cash Account Details")]
    [IsoXmlTag("CshAcctDtls")]
    public CashAccount204? CashAccountDetails { get; init; } 
    
    /// <summary>
    /// Additional information for the reporting of tax.
    /// </summary>
    [IsoId("_f1mky5S6EemqYPWMBuVawg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; } 
    
    
    #nullable disable
    
}
