// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData19Choice
{
    /// <summary>
    /// Reporting of position or transaction for trade lifecycle events.
    /// </summary>
    [IsoId("_nBfoE3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Report")]
    public partial record Report : TradeData19Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
