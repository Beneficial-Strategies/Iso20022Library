// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to a pending cancellation request.
    /// </summary>
    [IsoId("_QyGwZtp-Ed-ak6NoX_4Aeg_-377654656")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : InstructionCancellationRequestStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
