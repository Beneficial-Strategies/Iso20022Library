// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice
{
    /// <summary>
    /// A credit default swap derivative on an index.
    /// </summary>
    [IsoId("_xfbL135eEea2k7EBUopqxw")]
    [DisplayName("Credit Default Swap Index Derivative")]
    public record CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative3Choice_
    {
        /// <summary>
        /// Derivative on a credit default swap with the ISIN code of the underlying index.
        /// </summary>
        [IsoId("_x6DSUX5eEea2k7EBUopqxw")]
        [DisplayName("Underlying Index Identification")]
        [IsoXmlTag("UndrlygIndxId")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; }

        /// <summary>
        /// To be populated for derivatives on a CDS index with the standardized name of the index.
        /// </summary>
        [IsoId("_x6DSU35eEea2k7EBUopqxw")]
        [DisplayName("Index Name")]
        [IsoXmlTag("IndxNm")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25, MinimumLength = 1)]
        public required IsoMax25Text IndexName { get; init; }

        /// <summary>
        /// Describes the Index specific details the derivative is being made on.
        /// </summary>
        [IsoId("_x6DSVX5eEea2k7EBUopqxw")]
        [DisplayName("Index")]
        [IsoXmlTag("Indx")]
        public required CreditDefaultSwapIndex2 Index { get; init; }
    }
}
