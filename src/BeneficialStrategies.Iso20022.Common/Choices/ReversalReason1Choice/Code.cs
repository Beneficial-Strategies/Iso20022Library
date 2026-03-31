// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason1Choice
{
    /// <summary>
    /// Reason for the reversal in a coded form.
    /// </summary>
    [IsoId("_TPTypNp-Ed-ak6NoX_4Aeg_1404293985")]
    [DisplayName("Code")]
    public record Code : ReversalReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionReversalReason1Code Value { get; init; }
    }
}
