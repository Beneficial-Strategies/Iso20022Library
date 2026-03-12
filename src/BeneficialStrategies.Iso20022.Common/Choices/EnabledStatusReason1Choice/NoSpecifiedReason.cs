// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EnabledStatusReason1Choice
{
    /// <summary>
    /// There is no reason available or to report for the enabled account status.
    /// </summary>
    [IsoId("_4hBVcEy9EeafiMTDrtSnyw")]
    [DisplayName("No Specified Reason")]
    public partial record NoSpecifiedReason : EnabledStatusReason1Choice_
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
