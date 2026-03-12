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
[IsoId("_QbTZ-dp-Ed-ak6NoX_4Aeg_-841172268")]
[DisplayName("Commission Waiver")]
public partial record CommissionWaiver3
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, eg, cash.
    /// </summary>
    [IsoId("_QbTZ-tp-Ed-ak6NoX_4Aeg_-841172225")]
    [DisplayName("Instruction Basis")]
    [IsoXmlTag("InstrBsis")]
    public required WaivingInstruction1Code InstructionBasis { get; init; } 
    
    /// <summary>
    /// Form of the rebate, eg, cash.
    /// </summary>
    [IsoId("_QbTZ-9p-Ed-ak6NoX_4Aeg_-1880085102")]
    [DisplayName("Extended Instruction Basis")]
    [IsoXmlTag("XtndedInstrBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedInstructionBasis { get; init; } 
    
    /// <summary>
    /// Proportion of the commission that is waived, ie, if the commission is 5% and half is waived, 2.5% should be stated in this field.
    /// </summary>
    [IsoId("_QbTZ_Np-Ed-ak6NoX_4Aeg_-841172243")]
    [DisplayName("Waived Rate")]
    [IsoXmlTag("WvdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate WaivedRate { get; init; } 
    
    
    #nullable disable
    
}
