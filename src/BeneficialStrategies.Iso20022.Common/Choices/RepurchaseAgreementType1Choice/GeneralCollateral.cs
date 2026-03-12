// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType1Choice
{
    /// <summary>
    /// Repurchase agreement where the agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
    /// </summary>
    [IsoId("_EbIM8LbrEeaqL_M7XFD7PQ")]
    [DisplayName("General Collateral")]
    public partial record GeneralCollateral : RepurchaseAgreementType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// List of the identifiers of the securities eligible for a general collateral repurchase agreement.
        /// </summary>
        [IsoId("_OFpSY8huEeadgvwNGwK05w")]
        [DisplayName("Eligible Financial Instrument Identification")]
        [IsoXmlTag("ElgblFinInstrmId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> EligibleFinancialInstrumentIdentification { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _OFpSY8huEeadgvwNGwK05w
        
        
        #nullable disable
        
    }
}
