// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Card34.
/// </summary>
[IsoId("_5fWjpRwMEe6O0NdiBuX__w")]
[DisplayName("Payment Card34")]
public record PaymentCard34
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CardType1Code Type { get; init; }

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required Max35Text Number { get; init; }

    /// <summary>
    /// Holder Name.
    /// </summary>
    [DisplayName("Holder Name")]
    [IsoXmlTag("HldrNm")]
    public required Max35Text HolderName { get; init; }

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public ISOYearMonth? StartDate { get; init; }

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required ISOYearMonth ExpiryDate { get; init; }

    /// <summary>
    /// Card Issuer Name.
    /// </summary>
    [DisplayName("Card Issuer Name")]
    [IsoXmlTag("CardIssrNm")]
    public Max35Text? CardIssuerName { get; init; }

    /// <summary>
    /// Card Issuer Identification.
    /// </summary>
    [DisplayName("Card Issuer Identification")]
    [IsoXmlTag("CardIssrId")]
    public PartyIdentification139? CardIssuerIdentification { get; init; }

    /// <summary>
    /// Security Code.
    /// </summary>
    [DisplayName("Security Code")]
    [IsoXmlTag("SctyCd")]
    public Max35Text? SecurityCode { get; init; }

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public Max3Text? SequenceNumber { get; init; }
}
