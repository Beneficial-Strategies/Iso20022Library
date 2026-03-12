// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementType5Choice
{
    /// <summary>
    /// Statement type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_u_T9oTqoEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public partial record Code : StatementType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the statement is an accounting or a custody statement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesStatementType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
