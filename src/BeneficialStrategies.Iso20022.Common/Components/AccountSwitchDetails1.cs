// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the account switch, including its status and any response codes.
/// </summary>
[IsoId("_8m2xcQ2ZEeSNWNtJlXOAhg")]
[DisplayName("Account Switch Details")]
public record AccountSwitchDetails1
{
    /// <summary>
    /// Unique number that provides unique and unambiguous identification of the account switch.
    /// </summary>
    [IsoId("_vm6TwA2aEeSNWNtJlXOAhg")]
    [DisplayName("Unique Reference Number")]
    [IsoXmlTag("UnqRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text UniqueReferenceNumber { get; init; }

    /// <summary>
    /// Unique number that provides unique and unambiguous identification of the account switch.
    /// Usage: Where one or more account switches have taken place since the original account switch this field contains the unique number that relates to the switch that transferred the account to the latest new account servicer.
    /// </summary>
    [IsoId("_cbscEA2aEeSNWNtJlXOAhg")]
    [DisplayName("Routing Unique Reference Number")]
    [IsoXmlTag("RtgUnqRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RoutingUniqueReferenceNumber { get; init; }

    /// <summary>
    /// Date and time that the request was received by the central switch service, populated by the central switch service only.
    /// </summary>
    [IsoId("_f7vbYA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Received Date Time")]
    [IsoXmlTag("SwtchRcvdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SwitchReceivedDateTime { get; init; }

    /// <summary>
    /// Date on which the account switch is expected to have completed. The value is the same as the targeted switch date if the switch completes in the expected timeline.
    /// </summary>
    [IsoId("_o9RtUA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Date")]
    [IsoXmlTag("SwtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SwitchDate { get; init; }

    /// <summary>
    /// Indicates whether the account switch is a full switch or a partial switch.
    /// Usage: A full switch indicates the transfer of the full balance of the account and associated payment mandates. A partial switch indicates the transfer of certain payment mandates to a new account.
    /// </summary>
    [IsoId("_jB57EA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Type")]
    [IsoXmlTag("SwtchTp")]
    public required SwitchType1Code SwitchType { get; init; }

    /// <summary>
    /// State of the account switch at the time the message is sent.
    /// </summary>
    [IsoId("_mPEaoA2aEeSNWNtJlXOAhg")]
    [DisplayName("Switch Status")]
    [IsoXmlTag("SwtchSts")]
    public SwitchStatus1Code? SwitchStatus { get; init; }

    /// <summary>
    /// Identifies the processing window in which the balance transfer will be processed on the day of the account switch.
    /// </summary>
    [IsoId("_s39aMA2aEeSNWNtJlXOAhg")]
    [DisplayName("Balance Transfer Window")]
    [IsoXmlTag("BalTrfWndw")]
    public BalanceTransferWindow1Code? BalanceTransferWindow { get; init; }

    /// <summary>
    /// Response code and additional information.
    /// </summary>
    [IsoId("_wTtyIBE7EeafpqhYGpTDnw")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public ValueList<ResponseDetails1> Response { get; init; } = [];
}
