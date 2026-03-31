// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentYearType2Choice
{
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3gENYUXfEeGY6MkiuzuPOA_-1651867592")]
    [DisplayName("Extended Current Year Type")]
    public record ExtendedCurrentYearType : CurrentYearType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code and / or description for values that are not yet part of the related code list.
        /// </summary>
        [IsoXmlTag("XtndedCurYrTp")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoExtended350Code Value { get; init; }
    }
}
