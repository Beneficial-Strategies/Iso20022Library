// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemSecuritiesAccountType1Choice
{
    /// <summary>
    /// System securities account type, in a coded form.
    /// </summary>
    [IsoId("_i0Z6YDp0Eemk2e6qGBk8IQ")]
    [DisplayName("Code")]
    public record Code : SystemSecuritiesAccountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Lists the type of the securities account specific for a system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemSecuritiesAccountType1Code Value { get; init; }
    }
}
