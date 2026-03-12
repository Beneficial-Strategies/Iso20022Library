// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice
{
    /// <summary>
    /// Frequency expressed as a proprietary code.
    /// </summary>
    [IsoId("_6GkgCR7yEeSxevWRRWxNAg")]
    [DisplayName("Period")]
    public partial record Period : Frequency21Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Period for which the number of instructions are to be created and processed.
        /// </summary>
        [IsoId("_1bz5sB71EeSxevWRRWxNAg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required Frequency6Code Type { get; init; } 
        
        /// <summary>
        /// Number of instructions to be created and processed during the specified period.
        /// </summary>
        [IsoId("_OPlVUB72EeSxevWRRWxNAg")]
        [DisplayName("Count Per Period")]
        [IsoXmlTag("CntPerPrd")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber CountPerPeriod { get; init; } 
        
        
        #nullable disable
        
    }
}
