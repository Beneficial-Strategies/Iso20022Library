// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice
{
    /// <summary>
    /// Indicates a modification to the terms or details of a previously reported position or correction the erroneous data fields of a previously submitted position.
    /// </summary>
    [IsoId("_zvSsfcg3EeuGrNSsxk3B0A")]
    [DisplayName("Correction")]
    public partial record Correction : TradeReport22Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_GRkqwczsEeux2uvSBFU54Q")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_GRkqw8zsEeux2uvSBFU54Q")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        public required CounterpartyData88 CounterpartySpecificData { get; init; } 
        
        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_GRkqxczsEeux2uvSBFU54Q")]
        [DisplayName("Loan Data")]
        [IsoXmlTag("LnData")]
        public TransactionLoanData31Choice_? LoanData { get; init; } 
        
        /// <summary>
        /// Provides the details of the collateral used in the transaction.
        /// </summary>
        [IsoId("_GRkqx8zsEeux2uvSBFU54Q")]
        [DisplayName("Collateral Data")]
        [IsoXmlTag("CollData")]
        public TransactionCollateralData18Choice_? CollateralData { get; init; } 
        
        /// <summary>
        /// Information concerning the reported transaction level type.
        /// </summary>
        [IsoId("_GRkqyczsEeux2uvSBFU54Q")]
        [DisplayName("Level Type")]
        [IsoXmlTag("LvlTp")]
        public required ModificationLevel1Code LevelType { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_GRkqy8zsEeux2uvSBFU54Q")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
