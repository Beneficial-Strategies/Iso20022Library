// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementSource1Choice
{
    /// <summary>
    /// Report source expressed in coded form.
    /// </summary>
    [IsoId("_m_xsc_NBEeCuA5Tr22BnwA_-1086239416")]
    [DisplayName("Code")]
    public record Code : StatementSource1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the source of the report.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementSource1Code Value { get; init; }
    }
}
