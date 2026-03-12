// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice2Choice
{
    /// <summary>
    /// Estimated price, for example, for valuation purposes.
    /// </summary>
    [IsoId("_UKwuRtp-Ed-ak6NoX_4Aeg_-814082965")]
    [DisplayName("Indicative Price")]
    public partial record IndicativePrice : IndicativeOrMarketPrice2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
