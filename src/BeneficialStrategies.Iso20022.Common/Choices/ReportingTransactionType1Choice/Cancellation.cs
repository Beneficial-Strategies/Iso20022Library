// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportingTransactionType1Choice
{
    /// <summary>
    /// Transaction is a cancellation transaction.
    /// </summary>
    [IsoId("_J-kCE4G-EeaalK9UbuVGFw")]
    [DisplayName("Cancellation")]
    public partial record Cancellation : ReportingTransactionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the transaction.
        /// </summary>
        [IsoId("_CVjMkyrlEeWiy6-TnRWhpA")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text TransactionIdentification { get; init; } 
        
        /// <summary>
        /// Identification of the entity executing the transaction. 
        /// Usage:
        /// For legal entities, use the legal entity identifier. For non-legal entities, this field shall be populated with an identifier as specified in the local regulation.
        /// </summary>
        [IsoId("_CVjMmSrlEeWiy6-TnRWhpA")]
        [DisplayName("Executing Party")]
        [IsoXmlTag("ExctgPty")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier ExecutingParty { get; init; } 
        
        /// <summary>
        /// Entity submitting the transaction report to the competent authority.
        /// </summary>
        [IsoId("_QrvSQFymEeWe9sWf-OA_kA")]
        [DisplayName("Submitting Party")]
        [IsoXmlTag("SubmitgPty")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier SubmittingParty { get; init; } 
        
        /// <summary>
        /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
        /// </summary>
        [IsoId("_vgWC4DH8EeWRJePX1ORoaw")]
        [DisplayName("Technical Attributes")]
        [IsoXmlTag("TechAttrbts")]
        public RecordTechnicalData2? TechnicalAttributes { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_WLYxoMpeEeW3lKrJLTgxRg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
