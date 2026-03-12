// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice18Choice
{
    /// <summary>
    /// Indicates that price is expressed as a decimal.
    /// </summary>
    [IsoId("_wWf3kMgqEeuGrNSsxk3B0A")]
    [DisplayName("Decimal")]
    public partial record Decimal : SecuritiesTransactionPrice18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a decimal, for example, 0.7 is 7/10 and 70%.
        /// </summary>
        [IsoXmlTag("Dcml")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public required IsoBaseOneRate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
