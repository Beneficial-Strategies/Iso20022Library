// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt1Choice
{
    /// <summary>
    /// Claim non-receipt is accepted and processed by the agent.
    /// </summary>
    [IsoId("_vzbp0IjYEeeDW7_wB-eK_g")]
    [DisplayName("Accepted")]
    public record Accepted : ClaimNonReceipt1Choice_
    {
        /// <summary>
        /// Specifies the date the original payment instruction was processed.
        /// </summary>
        [IsoId("_hPoCUItuEee-OJ-wXSj3YQ")]
        [DisplayName("Date Processed")]
        [IsoXmlTag("DtPrcd")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate DateProcessed { get; init; }

        /// <summary>
        /// Specifies the next party the original payment instruction was sent to.
        /// </summary>
        [IsoId("_jfyHEItuEee-OJ-wXSj3YQ")]
        [DisplayName("Original Next Agent")]
        [IsoXmlTag("OrgnlNxtAgt")]
        public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; }
    }
}
