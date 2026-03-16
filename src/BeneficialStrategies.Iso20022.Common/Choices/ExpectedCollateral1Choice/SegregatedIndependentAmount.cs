// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral1Choice
{
    /// <summary>
    /// Provides the expected collateral type and direction for the segregated independent amount.
    /// </summary>
    [IsoId("_QmevNNp-Ed-ak6NoX_4Aeg_1398356900")]
    [DisplayName("Segregated Independent Amount")]
    public record SegregatedIndependentAmount : ExpectedCollateral1Choice_
    {
        /// <summary>
        /// Type of collateral that will be delivered.
        /// </summary>
        [IsoId("_UmVP9tp-Ed-ak6NoX_4Aeg_759302404")]
        [DisplayName("Delivery")]
        [IsoXmlTag("Dlvry")]
        public CollateralType1Code? Delivery { get; init; }

        /// <summary>
        /// Type of collateral that will be returned.
        /// </summary>
        [IsoId("_UmVP99p-Ed-ak6NoX_4Aeg_1623020220")]
        [DisplayName("Return")]
        [IsoXmlTag("Rtr")]
        public CollateralType1Code? Return { get; init; }
    }
}
