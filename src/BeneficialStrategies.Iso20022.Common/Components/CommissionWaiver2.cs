// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
/// </summary>
[IsoId("_VRshJdp-Ed-ak6NoX_4Aeg_998746205")]
[DisplayName("Commission Waiver")]
public partial record CommissionWaiver2
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, eg, cash.
    /// </summary>
    [IsoId("_VRshJtp-Ed-ak6NoX_4Aeg_999668702")]
    [DisplayName("Instruction Basis")]
    [IsoXmlTag("InstrBsis")]
    public required WaivingType1 InstructionBasis { get; init; } 
    
    /// <summary>
    /// Proportion of the commission that is waived, ie, if the commission is 5% and half is waived, 2.5% should be stated in this field.
    /// </summary>
    [IsoId("_VRshJ9p-Ed-ak6NoX_4Aeg_998747220")]
    [DisplayName("Waived Rate")]
    [IsoXmlTag("WvdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate WaivedRate { get; init; } 
    
    
    #nullable disable
    
}
