// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status12Choice
{
    /// <summary>
    /// Status of the order is rejected.
    /// </summary>
    [IsoId("_huaOfRdSEeK5g-3oYI0_9Q")]
    [DisplayName("Rejected")]
    public record Rejected : Status12Choice_ { }
}
