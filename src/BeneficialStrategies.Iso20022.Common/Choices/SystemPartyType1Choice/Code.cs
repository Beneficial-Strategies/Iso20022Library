// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyType1Choice
{
    /// <summary>
    /// System party type, in a coded format.
    /// </summary>
    [IsoId("_DZrOdVhPEeih3fUfzR38Ig")]
    [DisplayName("Code")]
    public record Code : SystemPartyType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the system party type, as published in an external system party type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSystemPartyType1Code Value { get; init; }
    }
}
