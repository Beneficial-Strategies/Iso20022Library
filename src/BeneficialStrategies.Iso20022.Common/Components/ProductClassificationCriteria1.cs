// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Criteria regarding product classification.
/// </summary>
[IsoId("_hfq2Ux3YEeWNp95x0ENf8w")]
[DisplayName("Product Classification Criteria")]
public partial record ProductClassificationCriteria1
{
    /// <summary>
    /// Identifier is an ISO 10962 Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_hfq2VR3YEeWNp95x0ENf8w")]
    [DisplayName("Classification Financial Instrument")]
    [IsoXmlTag("ClssfctnFinInstrm")]
    public SimpleValueList<CFIOct2015Identifier> ClassificationFinancialInstrument { get; init; } =
        [];

    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_hfq2VB3YEeWNp95x0ENf8w")]
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    public SimpleValueList<Max52Text> UniqueProductIdentifier { get; init; } = [];
}
