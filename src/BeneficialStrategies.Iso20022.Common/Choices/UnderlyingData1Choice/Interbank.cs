// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData1Choice
{
    /// <summary>
    /// Reference details on the original interbank payment transaction.
    /// </summary>
    [IsoId("_CXmpaVRtEe23M4WgERMsYw")]
    [DisplayName("Interbank")]
    public partial record Interbank : UnderlyingData1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_UwdCs3fJEe2A6pitLvwC_g")]
        [DisplayName("Original Group Information")]
        [IsoXmlTag("OrgnlGrpInf")]
        public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
        /// </summary>
        [IsoId("_UwdCtXfJEe2A6pitLvwC_g")]
        [DisplayName("Original Instruction Identification")]
        [IsoXmlTag("OrgnlInstrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
        /// </summary>
        [IsoId("_UwdCt3fJEe2A6pitLvwC_g")]
        [DisplayName("Original End To End Identification")]
        [IsoXmlTag("OrgnlEndToEndId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
        /// </summary>
        [IsoId("_UwdCuXfJEe2A6pitLvwC_g")]
        [DisplayName("Original Transaction Identification")]
        [IsoXmlTag("OrgnlTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
        
        /// <summary>
        /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_UwdCu3fJEe2A6pitLvwC_g")]
        [DisplayName("Original UETR")]
        [IsoXmlTag("OrgnlUETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
        
        /// <summary>
        /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
        /// </summary>
        [IsoId("_UwdCvXfJEe2A6pitLvwC_g")]
        [DisplayName("Original Interbank Settlement Amount")]
        [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
        public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
        
        /// <summary>
        /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
        /// </summary>
        [IsoId("_UwdCv3fJEe2A6pitLvwC_g")]
        [DisplayName("Original Interbank Settlement Date")]
        [IsoXmlTag("OrgnlIntrBkSttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
        
        /// <summary>
        /// Key elements used to identify the original transaction that is being referred to.
        /// </summary>
        [IsoId("_UwdCwXfJEe2A6pitLvwC_g")]
        [DisplayName("Original Transaction Reference")]
        [IsoXmlTag("OrgnlTxRef")]
        public OriginalTransactionReference35? OriginalTransactionReference { get; init; } 
        
        /// <summary>
        /// Agreement under which or rules under which the transaction should be processed.
        /// </summary>
        [IsoId("_XFN6oXfJEe2A6pitLvwC_g")]
        [DisplayName("Original Service Level")]
        [IsoXmlTag("OrgnlSvcLvl")]
        public ServiceLevel8Choice_? OriginalServiceLevel { get; init; } 
        
        
        #nullable disable
        
    }
}
