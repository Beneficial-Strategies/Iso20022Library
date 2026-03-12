// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification2Choice
{
    /// <summary>
    /// Indicates that the trade was executed off -exchange.
    /// </summary>
    [IsoId("_TCfeptp-Ed-ak6NoX_4Aeg_-1421688662")]
    [DisplayName("Off Market")]
    public partial record OffMarket : PlaceOfTradeIdentification2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
