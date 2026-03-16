// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_BMczYS_6EeO4w-IWHJMI9g")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment20
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_BbLy8S_6EeO4w-IWHJMI9g")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer2? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_BbLy8y_6EeO4w-IWHJMI9g")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_BbLy9S_6EeO4w-IWHJMI9g")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction3 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_BbLy9y_6EeO4w-IWHJMI9g")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard7 Card { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_BbLy-S_6EeO4w-IWHJMI9g")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder5? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_jmvdUC_6EeO4w-IWHJMI9g")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType7? ProtectedCardholderData { get; init; }
}
