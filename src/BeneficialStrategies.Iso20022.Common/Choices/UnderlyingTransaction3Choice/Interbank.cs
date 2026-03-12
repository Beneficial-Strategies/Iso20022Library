// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction3Choice
{
    /// <summary>
    /// Set of elements used to reference the details of the original interbank payment transaction.
    /// </summary>
    [IsoId("_X0Xj42XpEeap-P22vGV91g")]
    [DisplayName("Interbank")]
    public partial record Interbank : UnderlyingTransaction3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_P3EMVJ9XEeGBX4a4yy-WHg_-351369784")]
        [DisplayName("Original Group Information")]
        [IsoXmlTag("OrgnlGrpInf")]
        public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
        /// </summary>
        [IsoId("_P3EMVZ9XEeGBX4a4yy-WHg_-586407989")]
        [DisplayName("Original Instruction Identification")]
        [IsoXmlTag("OrgnlInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
        /// </summary>
        [IsoId("_P3EMVp9XEeGBX4a4yy-WHg_-473837918")]
        [DisplayName("Original End To End Identification")]
        [IsoXmlTag("OrgnlEndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
        /// </summary>
        [IsoId("_P3N9UJ9XEeGBX4a4yy-WHg_-91382810")]
        [DisplayName("Original Transaction Identification")]
        [IsoXmlTag("OrgnlTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
        
        /// <summary>
        /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
        /// </summary>
        [IsoId("_P3N9UZ9XEeGBX4a4yy-WHg_-102481587")]
        [DisplayName("Original Interbank Settlement Amount")]
        [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
        public required ActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmount { get; init; } 
        
        /// <summary>
        /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_P3N9Up9XEeGBX4a4yy-WHg_222635920")]
        [DisplayName("Original Interbank Settlement Date")]
        [IsoXmlTag("OrgnlIntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate OriginalInterbankSettlementDate { get; init; } 
        
        
        #nullable disable
        
    }
}
