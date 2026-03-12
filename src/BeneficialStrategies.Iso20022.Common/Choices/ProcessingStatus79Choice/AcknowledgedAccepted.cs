// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus79Choice
{
    /// <summary>
    /// Buy-in advice is acknowledged by the account servicer.
    /// </summary>
    [IsoId("_HqnHYZwZEeqtp-LOti013g")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : ProcessingStatus79Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
