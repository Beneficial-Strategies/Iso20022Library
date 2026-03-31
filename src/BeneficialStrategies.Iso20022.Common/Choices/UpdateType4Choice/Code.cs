// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType4Choice
{
    /// <summary>
    /// Update type expressed in coded form.
    /// </summary>
    [IsoId("_m_7dc_NBEeCuA5Tr22BnwA_238148282")]
    [DisplayName("Code")]
    public record Code : UpdateType4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of a statement update, for example, it is a complete statement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementUpdateType1Code Value { get; init; }
    }
}
