// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RequestType3Choice
{
    /// <summary>
    /// Liquidity transfer request type, in a coded form.
    /// </summary>
    [IsoId("_72rN9KMgEeCJ6YNENx4h-w_1386424077")]
    [DisplayName("Code")]
    public partial record Code : RequestType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StandingOrderQueryType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
