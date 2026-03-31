// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestorCapacity1Choice
{
    /// <summary>
    /// Investor capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qs45MNp-Ed-ak6NoX_4Aeg_-1222322943")]
    [DisplayName("Code")]
    public record Code : InvestorCapacity1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the type of investor. The rules that apply to each type of client are different.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Eligibility1Code Value { get; init; }
    }
}
