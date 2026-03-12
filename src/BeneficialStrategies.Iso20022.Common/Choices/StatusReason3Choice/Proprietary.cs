// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusReason3Choice
{
    /// <summary>
    /// Reason for the status not catered for by the available codes.
    /// </summary>
    [IsoId("_V8w3Zdp-Ed-ak6NoX_4Aeg_-860400370")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : StatusReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// EPC Technical validation subset restricted RR01 code.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.RestrictedRR01CodeText)]
        public required IsoRestrictedRR01CodeText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
