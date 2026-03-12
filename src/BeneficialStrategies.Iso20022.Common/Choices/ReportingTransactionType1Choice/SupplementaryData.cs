// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportingTransactionType1Choice
{
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J-kCFYG-EeaalK9UbuVGFw")]
    [DisplayName("Supplementary Data")]
    public partial record SupplementaryData : ReportingTransactionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance.
        /// In the case of XML, this is expressed by a valid XPath.
        /// </summary>
        [IsoId("_Qn988Np-Ed-ak6NoX_4Aeg_354388497")]
        [DisplayName("Place And Name")]
        [IsoXmlTag("PlcAndNm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? PlaceAndName { get; init; } 
        
        /// <summary>
        /// Technical element wrapping the supplementary data.
        /// </summary>
        [IsoId("_Qn988dp-Ed-ak6NoX_4Aeg_-642683856")]
        [DisplayName("Envelope")]
        [IsoXmlTag("Envlp")]
        public required SupplementaryDataEnvelope1 Envelope { get; init; } 
        
        
        #nullable disable
        
    }
}
