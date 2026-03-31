// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification6Choice
{
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_xzhRNSyGEe2xAdY9t5fB3g")]
    [DisplayName("Unique Product Identifier")]
    public record UniqueProductIdentifier : InstrumentIdentification6Choice_ { }
}
