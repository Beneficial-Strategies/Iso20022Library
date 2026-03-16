// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdjustmentType1Choice
{
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
    /// </summary>
    [IsoId("_POBygBrXEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    public record Type : AdjustmentType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of adjustment.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required AdjustmentType2Code Value { get; init; }
    }
}
