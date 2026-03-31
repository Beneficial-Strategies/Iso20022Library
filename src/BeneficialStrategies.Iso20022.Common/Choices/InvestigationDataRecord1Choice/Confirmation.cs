// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord1Choice
{
    /// <summary>
    /// Confirmation.
    /// </summary>
    [DisplayName("Confirmation")]
    public record Confirmation : InvestigationDataRecord1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required BookingConfirmation1 Value { get; init; }
    }
}
