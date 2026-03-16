// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus5Choice
{
    /// <summary>
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [IsoId("_JoF7gTnXEeWLJsP1cO-amg")]
    [DisplayName("Code")]
    public record Code : CorporateActionProcessingStatus5Choice_
    {
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
    }
}
