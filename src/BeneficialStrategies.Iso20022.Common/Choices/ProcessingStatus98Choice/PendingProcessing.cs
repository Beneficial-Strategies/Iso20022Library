// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus98Choice
{
    /// <summary>
    /// Processing of the trade is pending.
    /// </summary>
    [IsoId("_x4XDlwarEe2phaVG0lYKTw")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : ProcessingStatus98Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
