// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionAmendment1Choice
{
    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    public record Other : TransactionAmendment1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required IsoMax140Text Value { get; init; }
    }
}
