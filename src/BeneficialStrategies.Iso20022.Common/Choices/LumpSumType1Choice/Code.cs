// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LumpSumType1Choice
{
    /// <summary>
    /// Type of lump sum expressed as a code.
    /// </summary>
    [IsoId("_GJThoLKdEeiXL6Ccd-oU8g")]
    [DisplayName("Code")]
    public record Code : LumpSumType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of lump sum.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LumpSumType1Code Value { get; init; }
    }
}
