// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contractual details related to the agreement between parties.
/// </summary>
[IsoId("_S_vMYwEcEeCQm6a_G2yO_w_490060980")]
[DisplayName("Trade Agreement")]
public record TradeAgreement6
{
    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    [IsoId("_S_vMZAEcEeCQm6a_G2yO_w_-420004793")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required TradeParty1 Buyer { get; init; }

    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    [IsoId("_S_vMZQEcEeCQm6a_G2yO_w_-2137864759")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required TradeParty1 Seller { get; init; }

    /// <summary>
    /// Quotation document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMZgEcEeCQm6a_G2yO_w_1723651688")]
    [DisplayName("Quotation Document Identification")]
    [IsoXmlTag("QtnDocId")]
    public DocumentIdentification22? QuotationDocumentIdentification { get; init; }

    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMZwEcEeCQm6a_G2yO_w_-365569461")]
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public DocumentIdentification22? ContractDocumentIdentification { get; init; }

    /// <summary>
    /// Buyer order document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMaAEcEeCQm6a_G2yO_w_154969253")]
    [DisplayName("Buyer Order Identification Document")]
    [IsoXmlTag("BuyrOrdrIdDoc")]
    public DocumentIdentification22? BuyerOrderIdentificationDocument { get; init; }

    /// <summary>
    /// Additional document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMaQEcEeCQm6a_G2yO_w_-457727477")]
    [DisplayName("Additional Reference Document")]
    [IsoXmlTag("AddtlRefDoc")]
    public DocumentGeneralInformation2? AdditionalReferenceDocument { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_S_vMagEcEeCQm6a_G2yO_w_-2027263920")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms3? Incoterms { get; init; }
}
