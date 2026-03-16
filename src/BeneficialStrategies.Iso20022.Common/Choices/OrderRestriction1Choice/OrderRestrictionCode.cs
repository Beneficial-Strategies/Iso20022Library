// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderRestriction1Choice
{
    /// <summary>
    /// Order Restriction Code.
    /// </summary>
    [DisplayName("Order Restriction Code")]
    public partial record OrderRestrictionCode : OrderRestriction1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrdrRstrctnCd")]
        public required OrderRestrictionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
