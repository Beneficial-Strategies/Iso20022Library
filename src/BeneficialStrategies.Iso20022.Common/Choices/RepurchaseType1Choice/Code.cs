// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType1Choice
{
    /// <summary>
    /// Type of securities financing transaction process expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QuFMA9p-Ed-ak6NoX_4Aeg_-588201004")]
    [DisplayName("Code")]
    public record Code : RepurchaseType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of repurchase transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepurchaseType2Code Value { get; init; }
    }
}
