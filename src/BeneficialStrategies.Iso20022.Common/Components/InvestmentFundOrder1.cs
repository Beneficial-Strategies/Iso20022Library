// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of an order, order cancellation and master reference.
/// </summary>
[IsoId("_TSlwKNp-Ed-ak6NoX_4Aeg_-337332402")]
[DisplayName("Investment Fund Order")]
public partial record InvestmentFundOrder1
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_TSu6ENp-Ed-ak6NoX_4Aeg_-2008589874")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Reference of an order and order cancellation.
    /// </summary>
    [IsoId("_TSu6Edp-Ed-ak6NoX_4Aeg_1448063042")]
    [DisplayName("Order References")]
    [IsoXmlTag("OrdrRefs")]
    public ValueList<InvestmentFundOrder5> OrderReferences { get; init; } = new ValueList<InvestmentFundOrder5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TSu6Edp-Ed-ak6NoX_4Aeg_1448063042
    
    
    #nullable disable
    
}
