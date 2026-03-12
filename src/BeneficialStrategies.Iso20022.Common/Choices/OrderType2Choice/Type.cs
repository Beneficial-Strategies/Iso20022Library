// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderType2Choice
{
    /// <summary>
    /// Order type expressed as a code.
    /// </summary>
    [IsoId("_dOFRwVxUEeWvPv3PXpS3fw")]
    [DisplayName("Type")]
    public partial record Type : OrderType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the fund order type.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required FundOrderType7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
