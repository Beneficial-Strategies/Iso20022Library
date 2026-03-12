// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundOrderType1Choice
{
    /// <summary>
    /// Order type expressed as a code.
    /// </summary>
    [IsoId("_RY2UhRHcEeKVqeHljBM1MQ")]
    [DisplayName("Type")]
    public partial record Type : FundOrderType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the category of the investment fund order.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required FundOrderType6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
