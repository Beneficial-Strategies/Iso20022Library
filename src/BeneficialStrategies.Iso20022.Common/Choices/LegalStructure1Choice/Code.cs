// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LegalStructure1Choice
{
    /// <summary>
    /// Legal structure of the financial instrument expressed as a code.
    /// </summary>
    [IsoId("_nv7r0DQeEeifw8iDiyZLmQ")]
    [DisplayName("Code")]
    public record Code : LegalStructure1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LegalStructureFinancialInstrument1Code Value { get; init; }
    }
}
