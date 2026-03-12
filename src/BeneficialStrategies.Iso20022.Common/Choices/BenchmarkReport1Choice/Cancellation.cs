// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BenchmarkReport1Choice
{
    /// <summary>
    /// Cancellation of a benchmark previously updated.
    /// </summary>
    [IsoId("_P2VfdDrWEeedCZZ8dIPp6g")]
    [DisplayName("Cancellation")]
    public partial record Cancellation : BenchmarkReport1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice messages.
        /// </summary>
        [IsoId("_QSO71zrXEeedCZZ8dIPp6g")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
        
        /// <summary>
        /// Identification of the benchmark to be cancelled.
        /// </summary>
        [IsoId("_QSO71jrXEeedCZZ8dIPp6g")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required SecurityIdentification19 Identification { get; init; } 
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_QSO71TrXEeedCZZ8dIPp6g")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
