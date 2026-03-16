// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderCriteria5Choice
{
    /// <summary>
    /// Query Name.
    /// </summary>
    [DisplayName("Query Name")]
    public partial record QueryName : StandingOrderCriteria5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("QryNm")]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
