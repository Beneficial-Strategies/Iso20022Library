// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt1Choice
{
    /// <summary>
    /// Specifies that the claim non receipt has been rejected and provides the reason for the rejection.
    /// </summary>
    [IsoId("_w4YfsIjYEeeDW7_wB-eK_g")]
    [DisplayName("Rejected")]
    public record Rejected : ClaimNonReceipt1Choice_ { }
}
