// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxable service charge amount conversions to host currency.
/// </summary>
[IsoId("_6QZvopqlEeGSON8vddiWzQ_-1627146001")]
[DisplayName("Billing Services Amount")]
public partial record BillingServicesAmount3
{
    #nullable enable
    
    /// <summary>
    /// Represents the total of all taxable services in a specific tax region for a specific currency. For example, all taxable services for a tax region in Euro would be totalled here in the Euro currency.
    /// </summary>
    [IsoId("_6QZvo5qlEeGSON8vddiWzQ_1670748942")]
    [DisplayName("Source Amount")]
    [IsoXmlTag("SrcAmt")]
    public required AmountAndDirection34 SourceAmount { get; init; } 
    
    /// <summary>
    /// Represents the total of all taxable services in a specific tax region for a specific currency and is a one-to-one relationship with total taxable charge of services, but represented in the host currency after conversion.
    /// </summary>
    [IsoId("_6QZvpJqlEeGSON8vddiWzQ_-1449027329")]
    [DisplayName("Host Amount")]
    [IsoXmlTag("HstAmt")]
    public required AmountAndDirection34 HostAmount { get; init; } 
    
    
    #nullable disable
    
}
