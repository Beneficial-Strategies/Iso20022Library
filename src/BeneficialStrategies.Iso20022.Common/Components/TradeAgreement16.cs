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
[IsoId("_Issv0eWnEeevU7McUP3D1w")]
[DisplayName("Trade Agreement")]
public record TradeAgreement16
{
    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    [IsoId("_I1XjoeWnEeevU7McUP3D1w")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required TradeParty4 Buyer { get; init; }

    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    [IsoId("_I1Xjo-WnEeevU7McUP3D1w")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required TradeParty4 Seller { get; init; }

    /// <summary>
    /// Quotation document referenced from this trade agreement.
    /// </summary>
    [IsoId("_I1XjpeWnEeevU7McUP3D1w")]
    [DisplayName("Quotation Document Identification")]
    [IsoXmlTag("QtnDocId")]
    public DocumentIdentification22? QuotationDocumentIdentification { get; init; }

    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    [IsoId("_I1Xjp-WnEeevU7McUP3D1w")]
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public DocumentIdentification22? ContractDocumentIdentification { get; init; }

    /// <summary>
    /// Buyer order document referenced from this trade agreement.
    /// </summary>
    [IsoId("_I1XjqeWnEeevU7McUP3D1w")]
    [DisplayName("Buyer Order Identification Document")]
    [IsoXmlTag("BuyrOrdrIdDoc")]
    public DocumentIdentification22? BuyerOrderIdentificationDocument { get; init; }

    /// <summary>
    /// Additional document referenced from this trade agreement.
    /// </summary>
    [IsoId("_I1Xjq-WnEeevU7McUP3D1w")]
    [DisplayName("Additional Reference Document")]
    [IsoXmlTag("AddtlRefDoc")]
    public DocumentGeneralInformation2? AdditionalReferenceDocument { get; init; }

    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_I1XjreWnEeevU7McUP3D1w")]
    [DisplayName("Incoterms")]
    [IsoXmlTag("Incotrms")]
    public Incoterms3? Incoterms { get; init; }
}
