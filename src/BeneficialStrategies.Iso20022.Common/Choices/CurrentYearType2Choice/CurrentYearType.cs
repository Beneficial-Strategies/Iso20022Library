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
    [IsoId("_3gENYEXfEeGY6MkiuzuPOA_-654795239")]
    [DisplayName("Current Year Type")]
    public record CurrentYearType : CurrentYearType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of the current year ISA.
        /// </summary>
        [IsoXmlTag("CurYrTp")]
        public required ISAType2Code Value { get; init; }
    }
}
