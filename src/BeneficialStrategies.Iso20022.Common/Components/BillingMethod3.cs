// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for the tax calculation method D.
/// </summary>
[IsoId("_6QGNoJqlEeGSON8vddiWzQ_173630706")]
[DisplayName("Billing Method")]
public partial record BillingMethod3
{
    #nullable enable
    
    /// <summary>
    /// Equivalent amount to the service tax host amount but allows the sender to optionally express the value in the pricing currency.
    /// </summary>
    [IsoId("_6QGNoZqlEeGSON8vddiWzQ_-823441647")]
    [DisplayName("Service Tax Price Amount")]
    [IsoXmlTag("SvcTaxPricAmt")]
    public required AmountAndDirection34 ServiceTaxPriceAmount { get; init; } 
    
    /// <summary>
    /// Provides for the specific tax identification within the same tax region. 
    /// Usage: This element allows for a maximum of three regional taxes on the same service.
    /// </summary>
    [IsoId("_6QGNopqlEeGSON8vddiWzQ_480308590")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<BillingServicesTax2> TaxIdentification { get; init; } = [];
    
    
    #nullable disable
    
}
