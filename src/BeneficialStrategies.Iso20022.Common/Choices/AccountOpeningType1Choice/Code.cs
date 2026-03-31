// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountOpeningType1Choice
{
    /// <summary>
    /// Type of account opening instruction expressed as a code.
    /// </summary>
    [IsoId("_3Et5EUzJEeafiMTDrtSnyw")]
    [DisplayName("Code")]
    public record Code : AccountOpeningType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of account to which an account opening request is related, eg, a new account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountOpeningType1Code Value { get; init; }
    }
}
