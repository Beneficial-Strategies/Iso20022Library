// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusReason3Choice
{
    /// <summary>
    /// Reason for the status in a coded form.
    /// </summary>
    [IsoId("_V8w3ZNp-Ed-ak6NoX_4Aeg_-860400481")]
    [DisplayName("Code")]
    public partial record Code : StatusReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionRejectReason4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
