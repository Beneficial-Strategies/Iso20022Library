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
[IsoId("__Q-MgXuxEeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Environment")]
public record CardTransactionEnvironment3
{
    /// <summary>
    /// Acquirer of the card transaction.
    /// </summary>
    [IsoId("__de-gXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer6 Acquirer { get; init; }

    /// <summary>
    /// Identification of the interconnected card scheme from which the response is coming.
    /// </summary>
    [IsoId("_Tj0ZkIPUEeSvn4rZUbUwhw")]
    [DisplayName("Card Scheme Identification")]
    [IsoXmlTag("CardSchmeId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardSchemeIdentification { get; init; }

    /// <summary>
    /// Acceptor performing the card transaction.
    /// </summary>
    [IsoId("__de-g3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public required Organisation19 Acceptor { get; init; }

    /// <summary>
    /// Identification of the card terminal performing the transaction.
    /// </summary>
    [IsoId("_g_fVkHuyEeS2Z_kGi7H1VQ")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    public GenericIdentification32? TerminalIdentification { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("__de-h3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard14 Card { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("__de-iXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("__de-i3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("__de-jXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken4? PaymentToken { get; init; }
}
