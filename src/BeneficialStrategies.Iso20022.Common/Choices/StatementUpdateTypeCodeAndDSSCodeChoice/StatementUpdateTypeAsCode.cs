// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementUpdateTypeCodeAndDSSCodeChoice
{
    /// <summary>
    /// Update type expressed as a code.
    /// </summary>
    [IsoId("_Q7Cp9Np-Ed-ak6NoX_4Aeg_-2092497455")]
    [DisplayName("Statement Update Type As Code")]
    public partial record StatementUpdateTypeAsCode : StatementUpdateTypeCodeAndDSSCodeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of a statement update, eg, it is a complete statement.
        /// </summary>
        [IsoXmlTag("StmtUpdTpAsCd")]
        public required StatementUpdateTypeCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
