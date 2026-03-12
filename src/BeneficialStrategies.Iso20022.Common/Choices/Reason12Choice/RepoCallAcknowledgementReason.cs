// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason12Choice
{
    /// <summary>
    /// Specifies additional information on the repurchase agreement call request acknowledgement.
    /// </summary>
    [IsoId("_C2YFsyRhEeO8sskhVI3IDA")]
    [DisplayName("Repo Call Acknowledgement Reason")]
    public partial record RepoCallAcknowledgementReason : Reason12Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
