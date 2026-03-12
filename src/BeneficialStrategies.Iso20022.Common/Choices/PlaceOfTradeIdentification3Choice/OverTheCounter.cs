// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification3Choice
{
    /// <summary>
    /// Place at which the Over-the-Counter (OTC) transaction is executed.
    /// </summary>
    [IsoId("_WNmIstp-Ed-ak6NoX_4Aeg_-1162943025")]
    [DisplayName("Over The Counter")]
    public partial record OverTheCounter : PlaceOfTradeIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 30 characters. It has a pattern ([^/]+/)+([^/]+)|([^/]*) that disables the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
        /// </summary>
        [IsoXmlTag("OverTheCntr")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
        [StringLength(maximumLength: 30 ,MinimumLength = 1)]
        public required IsoRestrictedFINMax30Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
