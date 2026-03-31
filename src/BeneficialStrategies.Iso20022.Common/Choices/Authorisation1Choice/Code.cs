// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Authorisation1Choice
{
    /// <summary>
    /// Specifies the authorisation, in a coded form.
    /// </summary>
    [IsoId("_RD1Zl9p-Ed-ak6NoX_4Aeg_-955120142")]
    [DisplayName("Code")]
    public record Code : Authorisation1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Authorisation1Code Value { get; init; }
    }
}
