// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus98Choice
{
    /// <summary>
    /// Trade is InRepair.
    /// </summary>
    [IsoId("_x4XDkQarEe2phaVG0lYKTw")]
    [DisplayName("In Repair")]
    public record InRepair : ProcessingStatus98Choice_ { }
}
