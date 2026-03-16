// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentYearType1Choice
{
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3f6cYUXfEeGY6MkiuzuPOA_-2028918886")]
    [DisplayName("Current Year Type")]
    public record CurrentYearType : CurrentYearType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of the current year ISA.
        /// </summary>
        [IsoXmlTag("CurYrTp")]
        public required ISAType1Code Value { get; init; }
    }
}
