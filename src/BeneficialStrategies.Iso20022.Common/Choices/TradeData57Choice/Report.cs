// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData57Choice
{
    /// <summary>
    /// Reporting of position or transaction for trade lifecycle events.
    /// </summary>
    [IsoId("_xYZZ82EUEe2P-L9DBerEgA")]
    [DisplayName("Report")]
    public partial record Report : TradeData57Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
