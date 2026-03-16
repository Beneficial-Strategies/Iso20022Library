// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction8Choice
{
    /// <summary>
    /// Statement Entry.
    /// </summary>
    [DisplayName("Statement Entry")]
    public partial record StatementEntry : UnderlyingTransaction8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StmtNtry")]
        public required UnderlyingStatementEntry3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
