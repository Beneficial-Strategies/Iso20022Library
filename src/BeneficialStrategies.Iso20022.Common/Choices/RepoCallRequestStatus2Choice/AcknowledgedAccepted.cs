// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepoCallRequestStatus2Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_UWYvdNp-Ed-ak6NoX_4Aeg_1704043249")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : RepoCallRequestStatus2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
