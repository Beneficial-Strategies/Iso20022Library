// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice9Choice
{
    /// <summary>
    /// Estimated price, for example, for valuation purposes.
    /// </summary>
    [IsoId("_chez1ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Price")]
    public partial record IndicativePrice : IndicativeOrMarketPrice9Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
