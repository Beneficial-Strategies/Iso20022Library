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
[IsoId("_55smERuCEeOqSdXzJ0oydA")]
[DisplayName("Commission Waiver")]
public partial record CommissionWaiver4
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, for example, cash.
    /// </summary>
    [IsoId("_HfvlABuDEeOqSdXzJ0oydA")]
    [DisplayName("Instruction Basis")]
    [IsoXmlTag("InstrBsis")]
    public required WaivingInstruction1Choice_ InstructionBasis { get; init; } 
    
    /// <summary>
    /// Proportion of the commission that is waived, for example, if the commission is 5% and half is waived, 2.5% should be stated in this field.
    /// </summary>
    [IsoId("_6QdgSRuCEeOqSdXzJ0oydA")]
    [DisplayName("Waived Rate")]
    [IsoXmlTag("WvdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate WaivedRate { get; init; } 
    
    
    #nullable disable
    
}
