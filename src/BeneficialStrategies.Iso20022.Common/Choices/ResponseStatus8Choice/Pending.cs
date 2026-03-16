// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus8Choice
{
    /// <summary>
    /// Pending status of an instruction, advice or request.
    /// </summary>
    [IsoId("_Vl2wK5NSEeWGlc8L7oPDIg")]
    [DisplayName("Pending")]
    public record Pending : ResponseStatus8Choice_ { }
}
