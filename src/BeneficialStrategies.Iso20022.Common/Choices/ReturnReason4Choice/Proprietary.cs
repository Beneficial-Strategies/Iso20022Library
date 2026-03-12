// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReturnReason4Choice
{
    /// <summary>
    /// Reason for the return not catered for by the available codes.
    /// </summary>
    [IsoId("_V5oD09p-Ed-ak6NoX_4Aeg_434826094")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : ReturnReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// EPC Technical validation subset restricted RR01 or SL01 code.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.RestrictedRR01SL01CodeText)]
        public required IsoRestrictedRR01SL01CodeText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
