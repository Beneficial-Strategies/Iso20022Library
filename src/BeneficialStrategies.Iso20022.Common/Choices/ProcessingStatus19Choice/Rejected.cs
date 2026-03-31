// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus19Choice
{
    /// <summary>
    /// Instruction/Request has been rejected for further processing.
    /// </summary>
    [IsoId("__qYfOf4wEeClUvPNHKL9Zw")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus19Choice_ { }
}
