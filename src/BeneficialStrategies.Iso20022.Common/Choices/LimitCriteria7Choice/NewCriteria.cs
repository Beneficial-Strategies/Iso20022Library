// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitCriteria7Choice
{
    /// <summary>
    /// New Criteria.
    /// </summary>
    [DisplayName("New Criteria")]
    public partial record NewCriteria : LimitCriteria7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NewCrit")]
        public required LimitCriteria7 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
