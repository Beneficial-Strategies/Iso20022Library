// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionDateOrPeriod1Choice
{
    /// <summary>
    /// Number of calendar days that the holder of the instrument/issuer of the instrument will give to the issuer/holder of the instrument before exercising the put/call option.
    /// </summary>
    [IsoId("_FBT62TU7EeWITbq5W8H-2w")]
    [DisplayName("Notice Period")]
    public record NoticePeriod : OptionDateOrPeriod1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("NtcePrd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
