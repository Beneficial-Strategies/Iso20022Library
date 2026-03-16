// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies additional information on the repurchase agreement call request acknowledgement.
    /// </summary>
    [IsoId("_8Qc105NLEeWGlc8L7oPDIg")]
    [DisplayName("Repo Call Acknowledgement Reason")]
    public record RepoCallAcknowledgementReason : Reason17Choice_ { }
}
