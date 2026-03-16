// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitType1Choice
{
    /// <summary>
    /// Type of the limit, in a coded form.
    /// </summary>
    [IsoId("_79FX8aMgEeCJ6YNENx4h-w_418078119")]
    [DisplayName("Code")]
    public record Code : LimitType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of risk management limit.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LimitType3Code Value { get; init; }
    }
}
