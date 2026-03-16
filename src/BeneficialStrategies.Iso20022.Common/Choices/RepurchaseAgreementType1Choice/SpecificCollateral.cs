// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType1Choice
{
    /// <summary>
    /// Repurchase agreement where a single, pre-defined, financial instrument is sold and repurchased.
    /// </summary>
    [IsoId("_9ll4gLbqEeaqL_M7XFD7PQ")]
    [DisplayName("Specific Collateral")]
    public record SpecificCollateral : RepurchaseAgreementType1Choice_
    {
        /// <summary>
        /// Identification of collateral placed as security for repo.
        /// </summary>
        [IsoId("_u_BmAbcREeabfchHYoktpA")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public required FinancialInstrument59 FinancialInstrumentIdentification { get; init; }
    }
}
