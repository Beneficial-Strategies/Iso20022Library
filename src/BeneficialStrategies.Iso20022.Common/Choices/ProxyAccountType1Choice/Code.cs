// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice
{
    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_dyoclXh3EeidzqjNEfehPg")]
    [DisplayName("Code")]
    public record Code : ProxyAccountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external proxy account type code, as published in the proxy account type external code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalProxyAccountType1Code Value { get; init; }
    }
}
