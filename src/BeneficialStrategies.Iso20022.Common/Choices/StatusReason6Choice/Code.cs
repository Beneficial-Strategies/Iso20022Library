// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatusReason6Choice
{
    /// <summary>
    /// Reason for the status, as published in an external reason code list.
    /// </summary>
    [IsoId("_TRGiZ9p-Ed-ak6NoX_4Aeg_-1877638996")]
    [DisplayName("Code")]
    public partial record Code : StatusReason6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status reason, as published in an external status reason code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalStatusReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
