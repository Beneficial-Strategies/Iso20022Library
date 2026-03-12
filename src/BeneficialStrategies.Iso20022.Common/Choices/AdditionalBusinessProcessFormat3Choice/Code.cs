// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat3Choice
{
    /// <summary>
    /// Standard code to specify the additional business process &quot;tax refund&quot; linked to a corporate action event.
    /// </summary>
    [IsoId("_Q10yxNp-Ed-ak6NoX_4Aeg_861159195")]
    [DisplayName("Code")]
    public partial record Code : AdditionalBusinessProcessFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the additional business process linked to a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdditionalBusinessProcess3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
