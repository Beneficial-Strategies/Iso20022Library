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
    [IsoId("_Rbhg0tp-Ed-ak6NoX_4Aeg_-1132471706")]
    [DisplayName("Long Business Identification")]
    public partial record LongBusinessIdentification : PaymentIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
        /// </summary>
        [IsoId("_Pirv4dp-Ed-ak6NoX_4Aeg_624722548")]
        [DisplayName("Payment Instruction Reference")]
        [IsoXmlTag("PmtInstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text PaymentInstructionReference { get; init; } 
        
        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent.
        /// </summary>
        [IsoId("_Pirv4tp-Ed-ak6NoX_4Aeg_624722616")]
        [DisplayName("Interbank Settlement Amount")]
        [IsoXmlTag("IntrBkSttlmAmt")]
        public required ImpliedCurrencyAndAmount InterbankSettlementAmount { get; init; } 
        
        /// <summary>
        /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_Pirv49p-Ed-ak6NoX_4Aeg_624722581")]
        [DisplayName("Interbank Value Date")]
        [IsoXmlTag("IntrBkValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate InterbankValueDate { get; init; } 
        
        /// <summary>
        /// The message type with which the instruction has been initiated.
        /// </summary>
        [IsoId("_Pirv5Np-Ed-ak6NoX_4Aeg_624722858")]
        [DisplayName("Payment Method")]
        [IsoXmlTag("PmtMtd")]
        public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
        
        /// <summary>
        /// The identification of the instructing agent that transmitted the payment instruction.
        /// </summary>
        [IsoId("_Pirv5dp-Ed-ak6NoX_4Aeg_624722918")]
        [DisplayName("Instructing Agent Identification")]
        [IsoXmlTag("InstgAgtId")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        public required IsoBICIdentifier InstructingAgentIdentification { get; init; } 
        
        /// <summary>
        /// The identification of the instructed agent in the payment instruction.
        /// </summary>
        [IsoId("_Pirv5tp-Ed-ak6NoX_4Aeg_624722953")]
        [DisplayName("Instructed Agent Identification")]
        [IsoXmlTag("InstdAgtId")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        public required IsoBICIdentifier InstructedAgentIdentification { get; init; } 
        
        /// <summary>
        /// An optional qualifier providing additional system specific information about the entry.||Usage:
        /// </summary>
        [IsoId("_Pirv59p-Ed-ak6NoX_4Aeg_1458662443")]
        [DisplayName("Entry Type")]
        [IsoXmlTag("NtryTp")]
        [IsoSimpleType(IsoSimpleType.EntryTypeIdentifier)]
        public IsoEntryTypeIdentifier? EntryType { get; init; } 
        
        /// <summary>
        /// The related reference as stipulated in the payment instruction.
        /// </summary>
        [IsoId("_Pirv6Np-Ed-ak6NoX_4Aeg_624722893")]
        [DisplayName("Related Reference")]
        [IsoXmlTag("RltdRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? RelatedReference { get; init; } 
        
        
        #nullable disable
        
    }
}
