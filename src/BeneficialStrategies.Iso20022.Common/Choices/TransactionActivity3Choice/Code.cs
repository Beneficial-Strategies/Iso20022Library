// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionActivity3Choice
{
    /// <summary>
    /// Transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_ilsVYTqDEeWVrPy0StzzSg")]
    [DisplayName("Code")]
    public record Code : TransactionActivity3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of activity to which this transaction relates.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransactionActivity1Code Value { get; init; }
    }
}
