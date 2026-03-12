// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError3Choice
{
    /// <summary>
    /// Reports either on the standing order or on a business error.
    /// </summary>
    [IsoId("_i_MAQRbvEeOy-PlRuFSUzQ")]
    [DisplayName("Report")]
    public partial record Report : StandingOrderOrError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_kIiN8RbvEeOy-PlRuFSUzQ")]
        [DisplayName("Standing Order Identification")]
        [IsoXmlTag("StgOrdrId")]
        public required StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
        
        /// <summary>
        /// Requested information on the standing order or business error when information has not been found.
        /// </summary>
        [IsoId("_kIiN8xbvEeOy-PlRuFSUzQ")]
        [DisplayName("Standing Order Or Error")]
        [IsoXmlTag("StgOrdrOrErr")]
        public required StandingOrderOrError4Choice_ StandingOrderOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
