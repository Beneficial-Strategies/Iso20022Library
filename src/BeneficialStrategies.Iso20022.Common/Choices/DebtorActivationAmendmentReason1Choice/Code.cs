// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DebtorActivationAmendmentReason1Choice
{
    /// <summary>
    /// Reason, as published in an external reason code list.
    /// </summary>
    [IsoId("_bjMUcPGAEemQ7oqCO5NTQw")]
    [DisplayName("Code")]
    public record Code : DebtorActivationAmendmentReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDebtorActivationAmendmentReason1Code Value { get; init; }
    }
}
