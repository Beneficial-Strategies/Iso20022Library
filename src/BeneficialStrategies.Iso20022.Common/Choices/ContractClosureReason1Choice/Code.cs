// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractClosureReason1Choice
{
    /// <summary>
    /// Reason in a coded form.
    /// </summary>
    [IsoId("_0KuyYArAEeWD-cmAqruRjw")]
    [DisplayName("Code")]
    public record Code : ContractClosureReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a contract closure reason code, as published in the external ISO 20022 external code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalContractClosureReason1Code Value { get; init; }
    }
}
