// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of an order, deal reference, client reference and master reference.
/// </summary>
[IsoId("_R60r-dp-Ed-ak6NoX_4Aeg_-571676430")]
[DisplayName("Investment Fund Order Execution")]
public partial record InvestmentFundOrderExecution1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_R60r-tp-Ed-ak6NoX_4Aeg_-1894994328")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_R60r-9p-Ed-ak6NoX_4Aeg_-314609339")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    
    /// <summary>
    /// Reference of an order, client or deal reference.
    /// </summary>
    [IsoId("_R60r_Np-Ed-ak6NoX_4Aeg_-424772693")]
    [DisplayName("Order References")]
    [IsoXmlTag("OrdrRefs")]
    public ValueList<InvestmentFundOrderExecution2> OrderReferences { get; init; } = new ValueList<InvestmentFundOrderExecution2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R60r_Np-Ed-ak6NoX_4Aeg_-424772693
    
    
    #nullable disable
    
}
