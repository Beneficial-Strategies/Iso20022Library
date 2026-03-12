// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a payment instruction by a simple set of characteristics which provides an unambiguous indentification of the instruction.
/// </summary>
[IsoId("_Pg5AI9p-Ed-ak6NoX_4Aeg_-2108565597")]
[DisplayName("Payment Instruction Reference Details")]
public partial record PaymentInstructionReferenceDetails2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
    /// </summary>
    [IsoId("_Pg5AJNp-Ed-ak6NoX_4Aeg_-2107642032")]
    [DisplayName("Payment Instruction Reference")]
    [IsoXmlTag("PmtInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PaymentInstructionReference { get; init; } 
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_Pg5AJdp-Ed-ak6NoX_4Aeg_-2106719051")]
    [DisplayName("Interbank Value Date")]
    [IsoXmlTag("IntrBkValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate InterbankValueDate { get; init; } 
    
    /// <summary>
    /// The identification of the instructing agent that transmitted the payment instruction.
    /// </summary>
    [IsoId("_Pg5AJtp-Ed-ak6NoX_4Aeg_-2106718120")]
    [DisplayName("Instructing Agent Identification")]
    [IsoXmlTag("InstgAgtId")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public required IsoBICIdentifier InstructingAgentIdentification { get; init; } 
    
    
    #nullable disable
    
}
