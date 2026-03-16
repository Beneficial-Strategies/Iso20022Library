// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer out transaction.
/// </summary>
[IsoId("_fQ1CkRgfEeK-_89we2b-bA")]
[DisplayName("Transfer Out")]
public record TransferOut9
{
    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    [IsoId("_flsfVRgfEeK-_89we2b-bA")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_flsfWRgfEeK-_89we2b-bA")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer20> TransferDetails { get; init; } = [];

    // ID for the above is _flsfWRgfEeK-_89we2b-bA

    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    [IsoId("_flsfXRgfEeK-_89we2b-bA")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_flsfYRgfEeK-_89we2b-bA")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public ReceiveInformation9? SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_flsfZRgfEeK-_89we2b-bA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
