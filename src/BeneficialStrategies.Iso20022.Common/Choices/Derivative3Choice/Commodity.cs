// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice
{
    /// <summary>
    /// Details specific for commodity derivatives.
    /// </summary>
    [IsoId("_xH-zYSe0Eei12pGEsJIAeQ")]
    [DisplayName("Commodity")]
    public partial record Commodity : Derivative3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides specific information related to commodity derivatives.
        /// </summary>
        [IsoId("_e8jMkU-nEeiVsYLJl6hleg")]
        [DisplayName("Class Specific")]
        [IsoXmlTag("ClssSpcfc")]
        public CommodityDerivative2Choice_? ClassSpecific { get; init; } 
        
        /// <summary>
        /// Currency in which the notional is denominated.
        /// </summary>
        [IsoId("_e8jMk0-nEeiVsYLJl6hleg")]
        [DisplayName("Notional Currency")]
        [IsoXmlTag("NtnlCcy")]
        public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
        
        
        #nullable disable
        
    }
}
