// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus6Choice
{
    /// <summary>
    /// Trade has been unaffirmed.
    /// </summary>
    [IsoId("_A55R5tokEeC60axPepSq7g_323180115")]
    [DisplayName("Unaffirmed")]
    public record Unaffirmed : AffirmationStatus6Choice_ { }
}
