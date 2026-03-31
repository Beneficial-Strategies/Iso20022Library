// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractTerm3Choice
{
    /// <summary>
    /// Transaction is open term, that is, has no fixed maturity date.
    /// </summary>
    [IsoId("_tKrKca9_EemF0ZVFnxVu4g")]
    [DisplayName("Open")]
    public record Open : ContractTerm3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the termination option for a repurchase agreement.
        /// </summary>
        [IsoXmlTag("Opn")]
        public required RepoTerminationOption2Code Value { get; init; }
    }
}
