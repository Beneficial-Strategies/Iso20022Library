// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice
{
    /// <summary>
    /// Status of the individual order is in repair.
    /// </summary>
    [IsoId("_P8YAnEHREeasdbKMiqizqA")]
    [DisplayName("In Repair")]
    public record InRepair : OrderStatus5Choice_ { }
}
