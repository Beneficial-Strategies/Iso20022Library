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
[IsoId("_5gXuoHrnEeSz_of_1TY14A")]
[DisplayName("Card Transaction Environment")]
public record CardTransactionEnvironment1
{
    /// <summary>
    /// Acquirer of the card transaction.
    /// </summary>
    [IsoId("_ebIxQHroEeSz_of_1TY14A")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer6 Acquirer { get; init; }

    /// <summary>
    /// Identification of the interconnected card scheme from which the request is coming.
    /// </summary>
    [IsoId("_3YiPkIPTEeSvn4rZUbUwhw")]
    [DisplayName("Card Scheme Identification")]
    [IsoXmlTag("CardSchmeId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardSchemeIdentification { get; init; }

    /// <summary>
    /// Acceptor performing the card transaction.
    /// </summary>
    [IsoId("_6PTNAHruEeSz_of_1TY14A")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public Organisation18? Acceptor { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_ofcDkHrvEeSz_of_1TY14A")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public CardAcceptorTerminal1? Terminal { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_r8eUsHr7EeSZrs_hiwNOWA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard12 Card { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_8BQm8Hr7EeSZrs_hiwNOWA")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_Crb_8Hr8EeSZrs_hiwNOWA")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_WCKkEHr8EeSZrs_hiwNOWA")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken4? PaymentToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card transaction.
    /// It correspond partially to the ISO 8583: 2003, field number 49-71.
    /// </summary>
    [IsoId("_SGWZUHr9EeSZrs_hiwNOWA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder9? Cardholder { get; init; }

    /// <summary>
    /// Protection of cardholder sensitive data by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_jHXyIIREEeSn-cdDKE4Flg")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; }
}
