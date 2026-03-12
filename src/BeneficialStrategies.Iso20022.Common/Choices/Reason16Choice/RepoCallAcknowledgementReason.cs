// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason16Choice
{
    /// <summary>
    /// Specifies additional information on the repurchase agreement call request acknowledgement.
    /// </summary>
    [IsoId("_kYkAcznvEeWfSKvvZlhRKg")]
    [DisplayName("Repo Call Acknowledgement Reason")]
    public partial record RepoCallAcknowledgementReason : Reason16Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
