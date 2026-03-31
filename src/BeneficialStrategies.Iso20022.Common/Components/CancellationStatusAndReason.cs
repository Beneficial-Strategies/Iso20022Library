// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a transfer cancellation instruction and the reason for the status.
/// </summary>
[IsoId("_Uww-Vtp-Ed-ak6NoX_4Aeg_-973620019")]
[DisplayName("Cancellation Status And Reason")]
public record CancellationStatusAndReason
{
    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_Uww-V9p-Ed-ak6NoX_4Aeg_698798027")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferCancellationStatus Status { get; init; }

    /// <summary>
    /// Status of transfer cancellation is rejected.
    /// </summary>
    [IsoId("_Uww-WNp-Ed-ak6NoX_4Aeg_409661495")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required TransferCancellationRejectedStatus1Choice_ Rejected { get; init; }

    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    [IsoId("_Uww-Wdp-Ed-ak6NoX_4Aeg_-1596403694")]
    [DisplayName("Complete")]
    [IsoXmlTag("Cmplt")]
    public required TransferCancellationCompleteStatusChoice_ Complete { get; init; }

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_Uww-Wtp-Ed-ak6NoX_4Aeg_1646242469")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification1Choice_? StatusInitiator { get; init; }
}
