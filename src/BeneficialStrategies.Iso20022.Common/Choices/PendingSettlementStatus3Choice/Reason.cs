// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingSettlementStatus3Choice
{
    /// <summary>
    /// Reason for the settlement pending status.
    /// </summary>
    [IsoId("_LrsCYyY4EeW_ZNn8gbfY7Q")]
    [DisplayName("Reason")]
    public partial record Reason : PendingSettlementStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transfer or settlement instruction settlement pending status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required PendingSettlementStatusReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
