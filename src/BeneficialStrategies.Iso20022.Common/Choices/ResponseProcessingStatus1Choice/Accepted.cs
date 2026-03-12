// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseProcessingStatus1Choice
{
    /// <summary>
    /// The received message or the multipart received report (sent with pagination in multiple messages) is accepted.
    /// </summary>
    [IsoId("_lOZu8IeUEemJ1cSJJmVYRQ")]
    [DisplayName("Accepted")]
    public partial record Accepted : ResponseProcessingStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason not specified.
        /// </summary>
        [IsoId("_6xuti4eUEemJ1cSJJmVYRQ")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        
        
        #nullable disable
        
    }
}
