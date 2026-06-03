// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// References of an order confirmation and an order confirmation cancellation.
/// </summary>
[IsoId("8b945314-7b6b-4346-8e01-095c6dad944b")]
[DisplayName("Investment Fund Order14")]
public record InvestmentFundOrder14
{
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("a7b783f4-9b7e-4278-a10e-f8783a7d2ab6")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order.
    /// </summary>
    [IsoId("29772961-18d1-429f-9e25-5cc7cc144278")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("7e58176c-858b-4a63-ad20-3868c396f71d")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("0ca82dbb-0937-4130-b769-f13fa262c4a8")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order confirmation cancellation, as assigned by the confirming party.
    /// </summary>
    [IsoId("90dab6d3-15f7-414d-8ba9-26eeec245ff6")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Reason for the cancellation of the confirmation.
    /// </summary>
    [IsoId("7f07638b-35be-49ce-bef2-130bb676b1ad")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public CancellationReason31Choice_? CancellationReason { get; init; }
}
