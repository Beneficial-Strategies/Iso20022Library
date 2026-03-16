// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountDesignation1Choice
{
    /// <summary>
    /// Account designation expressed as a code.
    /// </summary>
    [IsoId("_l6enkCCzEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public record Code : AccountDesignation1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the rank of an element (party, market) in a specific environment.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Rank1Code Value { get; init; }
    }
}
