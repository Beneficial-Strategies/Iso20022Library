// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for the tax calculation method A.
/// </summary>
[IsoId("_6PzStJqlEeGSON8vddiWzQ_1375424478")]
[DisplayName("Billing Method")]
public partial record BillingMethod1
{
    #nullable enable
    
    /// <summary>
    /// Amount of the original charge expressed in the host currency.
    /// </summary>
    [IsoId("_6PzStZqlEeGSON8vddiWzQ_-378796185")]
    [DisplayName("Service Charge Host Amount")]
    [IsoXmlTag("SvcChrgHstAmt")]
    public required AmountAndDirection34 ServiceChargeHostAmount { get; init; } 
    
    /// <summary>
    /// Provides for the regional taxes on the service. Up to three regional taxes may be defined for the same service.
    /// </summary>
    [IsoId("_6PzStpqlEeGSON8vddiWzQ_996223479")]
    [DisplayName("Service Tax")]
    [IsoXmlTag("SvcTax")]
    public required BillingServicesAmount1 ServiceTax { get; init; } 
    
    /// <summary>
    /// Specifies the total charge for a service (including taxes).
    /// </summary>
    [IsoId("_6PzSt5qlEeGSON8vddiWzQ_451070786")]
    [DisplayName("Total Charge")]
    [IsoXmlTag("TtlChrg")]
    public required BillingServicesAmount2 TotalCharge { get; init; } 
    
    /// <summary>
    /// Provides for the specific tax identification within the same tax region. 
    /// Usage: This element allows for a maximum of three regional taxes on the same service.
    /// </summary>
    [IsoId("_6P9DsJqlEeGSON8vddiWzQ_-1164327431")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<BillingServicesTax1> TaxIdentification { get; init; } = [];
    
    
    #nullable disable
    
}
