// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice
{
    /// <summary>
    /// Reason for the mandate setup, in a proprietary form.
    /// </summary>
    [IsoId("_iQq8Nz2OEeS6DKIV6SF6gw")]
    [DisplayName("Proprietary")]
    public record Proprietary : MandateSetupReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 70characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public required IsoMax70Text Value { get; init; }
    }
}
