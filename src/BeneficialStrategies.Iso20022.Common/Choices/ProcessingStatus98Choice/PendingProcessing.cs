// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus98Choice
{
    /// <summary>
    /// Processing of the trade is pending.
    /// </summary>
    [IsoId("_x4XDlwarEe2phaVG0lYKTw")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus98Choice_ { }
}
