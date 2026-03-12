// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.
    /// </summary>
    [IsoId("_QyGwZdp-Ed-ak6NoX_4Aeg_-1849747781")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionCancellationRequestStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
