// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Branch5Choice
{
    /// <summary>
    /// Identification of the branch office of a reporting counterparty.
    /// </summary>
    [IsoId("_Brx1ccg4Eeu4ecZgAYuz5w")]
    [DisplayName("Identification")]
    public partial record Identification : Branch5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
