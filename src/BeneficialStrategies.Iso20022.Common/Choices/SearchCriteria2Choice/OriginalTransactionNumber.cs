// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria2Choice
{
    /// <summary>
    /// Original Transaction Number.
    /// </summary>
    [DisplayName("Original Transaction Number")]
    public partial record OriginalTransactionNumber : SearchCriteria2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlTxNb")]
        public required RequestType1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
