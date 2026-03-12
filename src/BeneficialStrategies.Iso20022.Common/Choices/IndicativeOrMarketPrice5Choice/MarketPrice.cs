// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice5Choice
{
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_oc_1deEJEd-udr336SN7mQ")]
    [DisplayName("Market Price")]
    public partial record MarketPrice : IndicativeOrMarketPrice5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
