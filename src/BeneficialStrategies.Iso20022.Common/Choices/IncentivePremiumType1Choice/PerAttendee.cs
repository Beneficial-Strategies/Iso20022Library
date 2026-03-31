// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType1Choice
{
    /// <summary>
    /// Indicates that the premium is given per attendee.
    /// </summary>
    [IsoId("_RDiepNp-Ed-ak6NoX_4Aeg_1361394967")]
    [DisplayName("Per Attendee")]
    public record PerAttendee : IncentivePremiumType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("PerAttndee")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
