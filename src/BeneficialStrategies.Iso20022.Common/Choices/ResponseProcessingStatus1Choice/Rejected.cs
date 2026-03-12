// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseProcessingStatus1Choice
{
    /// <summary>
    /// The received message or the multipart received report (sent with pagination in multiple messages) is rejected.
    /// </summary>
    [IsoId("_mjD0wIeUEemJ1cSJJmVYRQ")]
    [DisplayName("Rejected")]
    public partial record Rejected : ResponseProcessingStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
