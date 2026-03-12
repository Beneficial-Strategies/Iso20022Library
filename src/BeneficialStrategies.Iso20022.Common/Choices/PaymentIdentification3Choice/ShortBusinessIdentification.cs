// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification3Choice
{
    /// <summary>
    /// Business identification of the payment instruction given by the clearing agent.
    /// </summary>
    [IsoId("_Rbhg09p-Ed-ak6NoX_4Aeg_-1132471681")]
    [DisplayName("Short Business Identification")]
    public partial record ShortBusinessIdentification : PaymentIdentification3Choice_
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
}
