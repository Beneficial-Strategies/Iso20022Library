// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the tax identification related to a service to be billed.
/// </summary>
[IsoId("_6TYLLJqlEeGSON8vddiWzQ_-2138086814")]
[DisplayName("Billing Tax Identification")]
public partial record BillingTaxIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Value added tax (VAT) registration number as provided by the region’s local taxing authority.
    /// </summary>
    [IsoId("_6TYLLZqlEeGSON8vddiWzQ_-845733598")]
    [DisplayName("VAT Registration Number")]
    [IsoXmlTag("VATRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? VATRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Tax registration number (TRN) as provided by the tax region’s local taxing authority.
    /// </summary>
    [IsoId("_6Th8IJqlEeGSON8vddiWzQ_-832304253")]
    [DisplayName("Tax Registration Number")]
    [IsoXmlTag("TaxRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Specifies financial institution&apos;s contact details for the tax region. This contact works for the financial institution, not the tax region.
    /// </summary>
    [IsoId("_6Th8IZqlEeGSON8vddiWzQ_-1556028091")]
    [DisplayName("Tax Contact")]
    [IsoXmlTag("TaxCtct")]
    public ContactDetails3? TaxContact { get; init; } 
    
    
    #nullable disable
    
}
