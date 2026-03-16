// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer in transaction.
/// </summary>
[IsoId("_QwC1gRgmEeK-_89we2b-bA")]
[DisplayName("Transfer In")]
public record TransferIn8
{
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_RFpSFRgmEeK-_89we2b-bA")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer25> TransferDetails { get; init; } = [];

    // ID for the above is _RFpSFRgmEeK-_89we2b-bA

    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_RFpSGRgmEeK-_89we2b-bA")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_RFpSHRgmEeK-_89we2b-bA")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public DeliverInformation11? SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_RFpSIRgmEeK-_89we2b-bA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
