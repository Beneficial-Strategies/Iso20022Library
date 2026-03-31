// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Authorisation1Choice
{
    /// <summary>
    /// Specifies the authorisation, in a free text form.
    /// </summary>
    [IsoId("_RD_KkNp-Ed-ak6NoX_4Aeg_-955120080")]
    [DisplayName("Proprietary")]
    public record Proprietary : Authorisation1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 128 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max128Text)]
        [StringLength(maximumLength: 128, MinimumLength = 1)]
        public required IsoMax128Text Value { get; init; }
    }
}
