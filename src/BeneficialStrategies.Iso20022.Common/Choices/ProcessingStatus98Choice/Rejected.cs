// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus98Choice
{
    /// <summary>
    /// Trade has been rejected.
    /// </summary>
    [IsoId("_x4XDmwarEe2phaVG0lYKTw")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus98Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
