// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingOpeningStatusReason1Choice
{
    /// <summary>
    /// There is no reason available or to report for the pending account opening status.
    /// </summary>
    [IsoId("_g7MiwWCJEeabZtzjEVWYCQ")]
    [DisplayName("No Specified Reason")]
    public partial record NoSpecifiedReason : PendingOpeningStatusReason1Choice_
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
