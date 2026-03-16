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
[IsoId("_ZeCrQXuPEeSVeNXcmBQ4hQ")]
[DisplayName("Card Transaction Environment")]
public record CardTransactionEnvironment2
{
    /// <summary>
    /// Acquirer identification of the transaction.
    /// </summary>
    [IsoId("_JAOYgHuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the interconnected card scheme from which the response is coming.
    /// </summary>
    [IsoId("_S9U60HuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Card Scheme Identification")]
    [IsoXmlTag("CardSchmeId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardSchemeIdentification { get; init; }

    /// <summary>
    /// Identification of the card acceptor performing the transaction.
    /// </summary>
    [IsoId("_Xixb8HuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Acceptor Identification")]
    [IsoXmlTag("AccptrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AcceptorIdentification { get; init; }

    /// <summary>
    /// Identification of the card terminal performing the transaction.
    /// </summary>
    [IsoId("_b8lU0HuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TerminalIdentification { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_ZrJ6N3uPEeSVeNXcmBQ4hQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard13 Card { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_ZrJ6PXuPEeSVeNXcmBQ4hQ")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken2? PaymentToken { get; init; }

    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_Yi5KQHuSEeSVeNXcmBQ4hQ")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress18? ShippingAddress { get; init; }
}
