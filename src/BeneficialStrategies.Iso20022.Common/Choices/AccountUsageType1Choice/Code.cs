// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountUsageType1Choice
{
    /// <summary>
    /// Type of account usage expressed as a code.
    /// </summary>
    [IsoId("_IOcgkBKDEeKj15WxqwlXPw")]
    [DisplayName("Code")]
    public record Code : AccountUsageType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of usage of the account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountUsageType1Code Value { get; init; }
    }
}
