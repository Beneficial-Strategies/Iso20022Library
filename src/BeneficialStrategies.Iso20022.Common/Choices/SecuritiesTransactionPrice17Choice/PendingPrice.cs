// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice
{
    /// <summary>
    /// Indicates that price is currently not available, but pending.
    /// </summary>
    [IsoId("_gSTIi5jcEeqkLZLH6DK3UQ")]
    [DisplayName("Pending Price")]
    public partial record PendingPrice : SecuritiesTransactionPrice17Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the price of a financial instrument.
        /// </summary>
        [IsoXmlTag("PdgPric")]
        public required PriceStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
