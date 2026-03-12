// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice7Choice
{
    /// <summary>
    /// Estimated price, for example, for valuation purposes.
    /// </summary>
    [IsoId("_dWrpA0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Indicative Price")]
    public partial record IndicativePrice : IndicativeOrMarketPrice7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
