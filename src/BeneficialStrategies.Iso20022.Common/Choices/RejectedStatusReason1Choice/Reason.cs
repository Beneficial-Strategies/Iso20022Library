// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatusReason1Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_Rhov59p-Ed-ak6NoX_4Aeg_-75492719")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a rejected status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required RejectedStatusReason10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
