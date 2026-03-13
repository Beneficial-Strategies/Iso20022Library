// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for the tax calculation method C.
/// </summary>
[IsoId("_6QGNo5qlEeGSON8vddiWzQ_288570123")]
[DisplayName("Billing Method")]
public partial record BillingMethod4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the details of the taxable services using tax calculation method C.
    /// </summary>
    [IsoId("_6QGNpJqlEeGSON8vddiWzQ_-708502230")]
    [DisplayName("Service Detail")]
    [IsoXmlTag("SvcDtl")]
    public ValueList<BillingServiceParameters2> ServiceDetail { get; init; } = [];
    // ID for the above is _6QGNpJqlEeGSON8vddiWzQ_-708502230
    
    /// <summary>
    /// Total amount of service charge to be taxed in the tax region’s host currency along with the supporting tax calculations. ||Usage: Used for tax calculation method C only, and only one per tax region may be specified.
    /// </summary>
    [IsoId("_6QGNpZqlEeGSON8vddiWzQ_-1819413649")]
    [DisplayName("Tax Calculation")]
    [IsoXmlTag("TaxClctn")]
    public required TaxCalculation1 TaxCalculation { get; init; } 
    
    
    #nullable disable
    
}
