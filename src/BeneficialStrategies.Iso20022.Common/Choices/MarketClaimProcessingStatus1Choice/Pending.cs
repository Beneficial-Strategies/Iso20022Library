// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus1Choice
{
    /// <summary>
    /// Provides status information related to a pending instruction.
    /// </summary>
    [IsoId("_YGaIg9x4EeqESbVR5AloZQ")]
    [DisplayName("Pending")]
    public partial record Pending : MarketClaimProcessingStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
