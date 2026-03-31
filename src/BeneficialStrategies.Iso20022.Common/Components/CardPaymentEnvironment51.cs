// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment common to a collection of transactions.
/// </summary>
[IsoId("_TAll8Y3LEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment51
{
    /// <summary>
    /// Acquirer involved in the card payment transactions.
    /// </summary>
    [IsoId("_TLw7MY3LEeWjkqXgn_0Imw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer5? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment transactions.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_TLw7M43LEeWjkqXgn_0Imw")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation9? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_TLw7NY3LEeWjkqXgn_0Imw")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction5? POI { get; init; }
}
