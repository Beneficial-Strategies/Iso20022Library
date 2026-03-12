// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReversalReason3Choice
{
    /// <summary>
    /// Reason for the reversal not catered for by the available codes.
    /// </summary>
    [IsoId("_V8nGZ9p-Ed-ak6NoX_4Aeg_-801418309")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : ReversalReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// EPC Technical validation subset restricted to MS02 and MS03 codes.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.RestrictedMS02MS03CodeText)]
        public required IsoRestrictedMS02MS03CodeText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
