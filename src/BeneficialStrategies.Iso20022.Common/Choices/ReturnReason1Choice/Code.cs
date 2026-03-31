// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason1Choice
{
    /// <summary>
    /// Reason for the return in a coded form.
    /// </summary>
    [IsoId("_TOkLyNp-Ed-ak6NoX_4Aeg_191375030")]
    [DisplayName("Code")]
    public record Code : ReturnReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionRejectReason2Code Value { get; init; }
    }
}
