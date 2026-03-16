// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice
{
    /// <summary>
    /// Current Limit Identification.
    /// </summary>
    [DisplayName("Current Limit Identification")]
    public partial record CurrentLimitIdentification : LimitStructure3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CurLmtId")]
        public required LimitIdentification8 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
