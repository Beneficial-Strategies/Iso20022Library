// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus19Choice
{
    /// <summary>
    /// Processing of the instruction/request is pending.
    /// </summary>
    [IsoId("__qYfL_4wEeClUvPNHKL9Zw")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus19Choice_ { }
}
