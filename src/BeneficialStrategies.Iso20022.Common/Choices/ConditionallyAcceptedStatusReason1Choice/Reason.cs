// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConditionallyAcceptedStatusReason1Choice
{
    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    [IsoId("_RgmOEdp-Ed-ak6NoX_4Aeg_-317806380")]
    [DisplayName("Reason")]
    public partial record Reason : ConditionallyAcceptedStatusReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a conditionally accepted status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required ConditionallyAcceptedStatusReason3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
