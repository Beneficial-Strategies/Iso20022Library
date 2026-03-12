// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus1Choice
{
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_Q1O85dp-Ed-ak6NoX_4Aeg_109671588")]
    [DisplayName("Event Status")]
    public partial record EventStatus : CorporateActionProcessingStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates whether the details provided about an event are complete or incomplete.
        /// </summary>
        [IsoId("_UKK4Z9p-Ed-ak6NoX_4Aeg_1527495156")]
        [DisplayName("Event Completeness Status")]
        [IsoXmlTag("EvtCmpltnsSts")]
        public required EventCompletenessStatus1Code EventCompletenessStatus { get; init; } 
        
        /// <summary>
        /// Indicates the status of the occurrence of an event.
        /// </summary>
        [IsoId("_UKK4aNp-Ed-ak6NoX_4Aeg_1457310397")]
        [DisplayName("Event Confirmation Status")]
        [IsoXmlTag("EvtConfSts")]
        public required EventConfirmationStatus1Code EventConfirmationStatus { get; init; } 
        
        
        #nullable disable
        
    }
}
