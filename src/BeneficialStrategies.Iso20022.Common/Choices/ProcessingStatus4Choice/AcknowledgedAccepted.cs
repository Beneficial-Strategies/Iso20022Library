// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus4Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_UUTEx9p-Ed-ak6NoX_4Aeg_1329543913")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : ProcessingStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
