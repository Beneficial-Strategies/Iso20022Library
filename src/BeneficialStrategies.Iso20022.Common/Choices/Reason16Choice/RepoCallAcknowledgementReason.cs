// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason16Choice
{
    /// <summary>
    /// Specifies additional information on the repurchase agreement call request acknowledgement.
    /// </summary>
    [IsoId("_kYkAcznvEeWfSKvvZlhRKg")]
    [DisplayName("Repo Call Acknowledgement Reason")]
    public record RepoCallAcknowledgementReason : Reason16Choice_ { }
}
