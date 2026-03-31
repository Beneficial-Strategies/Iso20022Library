// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus98Choice
{
    /// <summary>
    /// Trade has been rejected.
    /// </summary>
    [IsoId("_x4XDmwarEe2phaVG0lYKTw")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus98Choice_ { }
}
