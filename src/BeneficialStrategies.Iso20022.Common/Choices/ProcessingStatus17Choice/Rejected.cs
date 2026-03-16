// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus17Choice
{
    /// <summary>
    /// Trade has been rejected.
    /// </summary>
    [IsoId("_A5JrAdokEeC60axPepSq7g_-2129572820")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus17Choice_ { }
}
