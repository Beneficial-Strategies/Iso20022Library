// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingStatus2Choice
{
    /// <summary>
    /// Reason not specified.
    /// </summary>
    [IsoId("_QxzOZdp-Ed-ak6NoX_4Aeg_-334040091")]
    [DisplayName("No Specified Reason")]
    public partial record NoSpecifiedReason : PendingStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
