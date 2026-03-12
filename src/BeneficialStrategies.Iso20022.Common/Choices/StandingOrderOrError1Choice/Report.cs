// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError1Choice
{
    /// <summary>
    /// Reports either on the standing order or on a business error.
    /// </summary>
    [IsoId("_76G8cKMgEeCJ6YNENx4h-w_-327808063")]
    [DisplayName("Report")]
    public partial record Report : StandingOrderOrError1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_7-lMyKMgEeCJ6YNENx4h-w_62369976")]
        [DisplayName("Standing Order Identification")]
        [IsoXmlTag("StgOrdrId")]
        public required StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
        
        /// <summary>
        /// Requested information on the standing order or business error when information has not been found.
        /// </summary>
        [IsoId("_7-uWsKMgEeCJ6YNENx4h-w_2079274139")]
        [DisplayName("Standing Order Or Error")]
        [IsoXmlTag("StgOrdrOrErr")]
        public required StandingOrderOrError2Choice_ StandingOrderOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
