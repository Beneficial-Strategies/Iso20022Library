// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies additional information on the repurchase agreement call request acknowledgement.
    /// </summary>
    [IsoId("_UXb4VNp-Ed-ak6NoX_4Aeg_-2126970993")]
    [DisplayName("Repo Call Acknowledgement Reason")]
    public record RepoCallAcknowledgementReason : Reason1Choice_ { }
}
