// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt2Choice
{
    /// <summary>
    /// Claim non-receipt is accepted and processed by the agent.
    /// </summary>
    [IsoId("_EhbFMW4-EeiU9cctagi5ow")]
    [DisplayName("Accepted")]
    public partial record Accepted : ClaimNonReceipt2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the date the original payment instruction was processed.
        /// </summary>
        [IsoId("_EtCfUW4-EeiU9cctagi5ow")]
        [DisplayName("Date Processed")]
        [IsoXmlTag("DtPrcd")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate DateProcessed { get; init; } 
        
        /// <summary>
        /// Specifies the next party the original payment instruction was sent to.
        /// </summary>
        [IsoId("_EtCfU24-EeiU9cctagi5ow")]
        [DisplayName("Original Next Agent")]
        [IsoXmlTag("OrgnlNxtAgt")]
        public BranchAndFinancialInstitutionIdentification6? OriginalNextAgent { get; init; } 
        
        
        #nullable disable
        
    }
}
