// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NarrativeType1Choice
{
    /// <summary>
    /// Type of narrative.
    /// </summary>
    [IsoId("_93HE03ltEeG7BsjMvd1mEw_2098352159")]
    [DisplayName("Code")]
    public record Code : NarrativeType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalNarrativeType1Code Value { get; init; }
    }
}
