// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus8Choice
{
    /// <summary>
    /// Modification request will not be executed.
    /// </summary>
    [IsoId("_6QCdP5NLEeWGlc8L7oPDIg")]
    [DisplayName("Denied")]
    public record Denied : ModificationProcessingStatus8Choice_ { }
}
