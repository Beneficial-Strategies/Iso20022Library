// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionProcessingStatus1Choice
{
    /// <summary>
    /// Indicates that the message is for information only, that is processing of client&apos;s instruction will not be supported by the Account Servicer.
    /// </summary>
    [IsoId("_Q1O85tp-Ed-ak6NoX_4Aeg_-1955694222")]
    [DisplayName("For Information Only Indicator")]
    public record ForInformationOnlyIndicator : CorporateActionProcessingStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("ForInfOnlyInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
