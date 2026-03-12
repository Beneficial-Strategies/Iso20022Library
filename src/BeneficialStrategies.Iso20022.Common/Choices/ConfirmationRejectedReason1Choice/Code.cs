// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConfirmationRejectedReason1Choice
{
    /// <summary>
    /// Reason for the rejected status expressed as a code.
    /// </summary>
    [IsoId("__OYdIXZxEeaN2c674jyTxQ")]
    [DisplayName("Code")]
    public partial record Code : ConfirmationRejectedReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a confirmation rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectedConfirmationStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
