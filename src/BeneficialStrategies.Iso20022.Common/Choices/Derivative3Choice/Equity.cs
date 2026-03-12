// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice
{
    /// <summary>
    /// Details specific for Equity derivatives.
    /// </summary>
    [IsoId("_xH-zZye0Eei12pGEsJIAeQ")]
    [DisplayName("Equity")]
    public partial record Equity : Derivative3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Underlying type of the equity derivative.
        /// </summary>
        [IsoId("_PeXW0WlNEeaLAKoEUNsD9g")]
        [DisplayName("Underlying Type")]
        [IsoXmlTag("UndrlygTp")]
        public required EquityDerivative3Choice_ UnderlyingType { get; init; } 
        
        /// <summary>
        /// Return parameter for the equity derivative.
        /// </summary>
        [IsoId("_PeXW02lNEeaLAKoEUNsD9g")]
        [DisplayName("Parameter")]
        [IsoXmlTag("Param")]
        public EquityReturnParameter1Code? Parameter { get; init; } 
        
        
        #nullable disable
        
    }
}
