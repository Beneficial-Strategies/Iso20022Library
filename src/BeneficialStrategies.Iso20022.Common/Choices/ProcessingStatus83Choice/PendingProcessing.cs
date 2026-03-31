// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus83Choice
{
    /// <summary>
    /// Processing of the instruction/request is pending.
    /// </summary>
    [IsoId("_NAqkmStVEeyhipY4f42fZQ")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus83Choice_ { }
}
