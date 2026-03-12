// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty3Choice
{
    /// <summary>
    /// Detailed statistics per counterparty.
    /// </summary>
    [IsoId("_68WeEc2GEeqFGLkKbAvCGg")]
    [DisplayName("Report")]
    public partial record Report : StatisticsPerCounterparty3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reference period for statistics collection.
        /// </summary>
        [IsoId("_DPXdIc2HEeqFGLkKbAvCGg")]
        [DisplayName("Reporting Period")]
        [IsoXmlTag("RptgPrd")]
        public required Period2 ReportingPeriod { get; init; } 
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_DPXdI82HEeqFGLkKbAvCGg")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        public required CounterpartyData78 CounterpartyIdentification { get; init; } 
        
        /// <summary>
        /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
        /// </summary>
        [IsoId("_DPXdJc2HEeqFGLkKbAvCGg")]
        [DisplayName("Rejection Statistics")]
        [IsoXmlTag("RjctnSttstcs")]
        public required RejectionStatistics3 RejectionStatistics { get; init; } 
        
        /// <summary>
        /// Identification of the competent authority which supervises the reporting counterparty.
        /// </summary>
        [IsoId("_DPXdJ82HEeqFGLkKbAvCGg")]
        [DisplayName("Competent Authority")]
        [IsoXmlTag("CmptntAuthrty")]
        public CompetentAuthority1? CompetentAuthority { get; init; } 
        
        
        #nullable disable
        
    }
}
