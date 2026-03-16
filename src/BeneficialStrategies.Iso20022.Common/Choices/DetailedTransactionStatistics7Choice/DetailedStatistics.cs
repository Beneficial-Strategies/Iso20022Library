// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DetailedTransactionStatistics7Choice
{
    /// <summary>
    /// Detailed Statistics.
    /// </summary>
    [DisplayName("Detailed Statistics")]
    public partial record DetailedStatistics : DetailedTransactionStatistics7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DtldSttstcs")]
        public required DetailedTransactionStatistics30 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
