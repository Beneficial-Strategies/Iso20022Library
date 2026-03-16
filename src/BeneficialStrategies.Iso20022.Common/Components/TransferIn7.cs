// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer in transaction.
/// </summary>
[IsoId("__Z37QRgiEeK-_89we2b-bA")]
[DisplayName("Transfer In")]
public record TransferIn7
{
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("__vBr5RgiEeK-_89we2b-bA")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer22> TransferDetails { get; init; } = [];

    // ID for the above is __vBr5RgiEeK-_89we2b-bA

    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    [IsoId("__vBr6RgiEeK-_89we2b-bA")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("__vBr7RgiEeK-_89we2b-bA")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public DeliverInformation9? SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__vBr8RgiEeK-_89we2b-bA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
