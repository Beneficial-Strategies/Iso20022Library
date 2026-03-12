// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for regional taxes on the service.
/// </summary>
[IsoId("_6RcRdZqlEeGSON8vddiWzQ_-658807987")]
[DisplayName("Billing Services Tax")]
public partial record BillingServicesTax3
{
    #nullable enable
    
    /// <summary>
    /// Identification number of the specific region tax used to calculate the tax.
    /// </summary>
    [IsoId("_6RcRdpqlEeGSON8vddiWzQ_-1655880340")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; } 
    
    /// <summary>
    /// Name used to describe the tax (such as the national value added tax).
    /// </summary>
    [IsoId("_6RcRd5qlEeGSON8vddiWzQ_1528175537")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public IsoMax40Text? Description { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_6RcReJqlEeGSON8vddiWzQ_-352130103")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Rate { get; init; } 
    
    /// <summary>
    /// Specifies the tax obligation for taxable services within a tax region for a specific tax identifier (such as national value added tax equals 34,00), and expressed in the tax region’s host currency.
    /// </summary>
    [IsoId("_6RmCcJqlEeGSON8vddiWzQ_2143637300")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public required AmountAndDirection34 TotalTaxAmount { get; init; } 
    
    
    #nullable disable
    
}
