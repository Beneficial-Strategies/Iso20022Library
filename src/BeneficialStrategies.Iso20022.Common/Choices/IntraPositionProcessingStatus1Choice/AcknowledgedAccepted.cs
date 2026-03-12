// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus1Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_UW_MY9p-Ed-ak6NoX_4Aeg_-40215371")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : IntraPositionProcessingStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
