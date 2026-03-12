// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification information expressed as a country of fiscal domicile and a reference.
/// </summary>
[IsoId("_WUMt-u0REeWLj6RCdgRMog")]
[DisplayName("Market Claim Details SD")]
public partial record MarketClaimDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// Country in which the account owner has one&apos;s fiscal domicile.
    /// </summary>
    [IsoId("_WUMt_-0REeWLj6RCdgRMog")]
    [DisplayName("Fiscal Domicile")]
    [IsoXmlTag("FsclDmcl")]
    public required CountryCode FiscalDomicile { get; init; } 
    
    /// <summary>
    /// Identification of the document assigned by the account servicer.
    /// </summary>
    [IsoId("_WUMuAO0REeWLj6RCdgRMog")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountServicerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the document assigned by the account owner.
    /// </summary>
    [IsoId("_WUMt--0REeWLj6RCdgRMog")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_L6c2cO0SEeWLj6RCdgRMog")]
    [DisplayName("Tax Rate")]
    [IsoXmlTag("TaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxRate { get; init; } 
    
    /// <summary>
    /// Quantity of securities that do not impact the taxable record date entitlement.
    /// </summary>
    [IsoId("_Z3vbQO0TEeWLj6RCdgRMog")]
    [DisplayName("Cash Compensation")]
    [IsoXmlTag("CshCompstn")]
    public FinancialInstrumentQuantity18Choice_? CashCompensation { get; init; } 
    
    /// <summary>
    /// Quantity of securities that impact the taxable record date entitlement.
    /// </summary>
    [IsoId("_7GFPcO0TEeWLj6RCdgRMog")]
    [DisplayName("Dividend Correction")]
    [IsoXmlTag("DvddCrrctn")]
    public FinancialInstrumentQuantity18Choice_? DividendCorrection { get; init; } 
    
    
    #nullable disable
    
}
