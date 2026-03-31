// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType16Choice
{
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_cfq12ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : UpdateType16Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of a statement update, for example, it is a complete statement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementUpdateType1Code Value { get; init; }
    }
}
