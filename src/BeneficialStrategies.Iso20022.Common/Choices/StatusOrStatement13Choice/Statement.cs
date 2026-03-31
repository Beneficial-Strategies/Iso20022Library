// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement13Choice
{
    /// <summary>
    /// Statement.
    /// </summary>
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Stmt")]
        public required DocumentNumber13 Value { get; init; }
    }
}
