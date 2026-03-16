// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice
{
    /// <summary>
    /// All Current Limits.
    /// </summary>
    [DisplayName("All Current Limits")]
    public partial record AllCurrentLimits : LimitStructure3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AllCurLmts")]
        public required LimitIdentification9 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
