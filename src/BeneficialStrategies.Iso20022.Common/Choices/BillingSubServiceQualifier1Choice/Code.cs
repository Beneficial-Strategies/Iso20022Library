// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingSubServiceQualifier1Choice
{
    /// <summary>
    /// Specifies the contents of the sub service qualifier, in a coded form.
    /// </summary>
    [IsoId("_6PphwZqlEeGSON8vddiWzQ_-1237515416")]
    [DisplayName("Code")]
    public record Code : BillingSubServiceQualifier1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Qualifies the content of the subservice code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BillingSubServiceQualifier1Code Value { get; init; }
    }
}
