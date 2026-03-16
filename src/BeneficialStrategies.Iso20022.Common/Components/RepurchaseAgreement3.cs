// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement between two parties to sell a financial instrument or set of financial instruments and repurchase such instruments at an agreed future date.
/// </summary>
[IsoId("_aOU-QbcREeabfchHYoktpA")]
[DisplayName("Repurchase Agreement")]
public record RepurchaseAgreement3
{
    /// <summary>
    /// Specifies attributes of a derivative based on Final ISDA Taxonomy v1.0 and Final ISDA Taxonomy v2.0.
    /// </summary>
    [IsoId("_EBtPIDXHEemdWfjs3tykFQ")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    public required ProductClassification1 ProductClassification { get; init; }

    /// <summary>
    /// Indicates whether the repo is a general collateral repo or specific repo.
    /// </summary>
    [IsoId("_aYveibcREeabfchHYoktpA")]
    [DisplayName("Repurchase Agreement Type")]
    [IsoXmlTag("RpAgrmtTp")]
    public required RepurchaseAgreementType1Choice_ RepurchaseAgreementType { get; init; }

    /// <summary>
    /// Identifier for triparty agent if applicable.
    /// </summary>
    [IsoId("_aYvei7cREeabfchHYoktpA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? TripartyAgent { get; init; }
}
