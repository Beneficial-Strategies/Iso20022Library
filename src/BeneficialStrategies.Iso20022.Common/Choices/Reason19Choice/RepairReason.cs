// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason19Choice
{
    /// <summary>
    /// Specifies the reason why the instruction is in repair.
    /// </summary>
    [IsoId("_8NNHJytXEeyhipY4f42fZQ")]
    [DisplayName("Repair Reason")]
    public record RepairReason : Reason19Choice_ { }
}
