// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestShareHeldDate1Choice
{
    /// <summary>
    /// Indicates what is the logical method to be used to determine and communicate from which date the shares have been held.
    /// </summary>
    [IsoId("_zKTRMFSTEempisJfoIfvvQ")]
    [DisplayName("Date Calculation Method")]
    public record DateCalculationMethod : RequestShareHeldDate1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the calculation method to be used to determine on which dates the shares have been acquired.
        /// </summary>
        [IsoXmlTag("DtClctnMtd")]
        public required DateCalculationMethod1Code Value { get; init; }
    }
}
