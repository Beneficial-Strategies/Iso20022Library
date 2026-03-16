// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Card34.
/// </summary>
[IsoId("_5fWjpRwMEe6O0NdiBuX__w")]
[DisplayName("Payment Card34")]
public partial record PaymentCard34
{
    #nullable enable

    /// <summary>
    /// Card Issuer Identification.
    /// </summary>
    [DisplayName("Card Issuer Identification")]
    [IsoXmlTag("CardIssrId")]
    public PartyIdentification139? CardIssuerIdentification { get; init; } 

    /// <summary>
    /// Card Issuer Name.
    /// </summary>
    [DisplayName("Card Issuer Name")]
    [IsoXmlTag("CardIssrNm")]
    public IsoMax35Text? CardIssuerName { get; init; } 

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required IsoISOYearMonth ExpiryDate { get; init; } 

    /// <summary>
    /// Holder Name.
    /// </summary>
    [DisplayName("Holder Name")]
    [IsoXmlTag("HldrNm")]
    public required IsoMax35Text HolderName { get; init; } 

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required IsoMax35Text Number { get; init; } 

    /// <summary>
    /// Security Code.
    /// </summary>
    [DisplayName("Security Code")]
    [IsoXmlTag("SctyCd")]
    public IsoMax35Text? SecurityCode { get; init; } 

    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoMax3Text? SequenceNumber { get; init; } 

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public IsoISOYearMonth? StartDate { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CardType1Code Type { get; init; } 

    
    #nullable disable
    
}
