// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus44Choice
{
    /// <summary>
    /// Request has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_iZ0nQ1hgEeS8HfHHd4stCA")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : ProcessingStatus44Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
