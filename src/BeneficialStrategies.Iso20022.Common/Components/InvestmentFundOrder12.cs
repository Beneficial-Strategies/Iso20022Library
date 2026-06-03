// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of an order and of an order cancellation.
/// </summary>
[IsoId("68b7fa2d-3b01-4ba3-b18e-a811799e8595")]
[DisplayName("Investment Fund Order12")]
public record InvestmentFundOrder12
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("c269f780-9515-4ad8-8ff5-3d56f8ce6940")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("25c7a394-df32-495a-8376-e11551f5183b")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order.
    /// </summary>
    [IsoId("531be4ba-2b6e-4287-ba86-339b78466d6f")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("0d47943a-08d0-4c7c-b48c-f8f13837e68d")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("1a5d6743-8eae-462b-9931-fafda400eed0")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("f4df70b3-569b-40a7-9279-29acb0a44b1b")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Account information of the individual order instruction or individual order cancellation request for which the status is requested.
    /// </summary>
    [IsoId("26b432c8-31f7-41ea-a32e-d43e64015d6a")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Financial instrument information of the individual order or individual order cancellation request for which the status is requested.
    /// </summary>
    [IsoId("eddd7537-356e-47e4-91e5-32bb0b149d97")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument107? FinancialInstrumentDetails { get; init; }
}
