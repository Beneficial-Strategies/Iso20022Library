// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of a transfer and of a transfer cancellation.
/// </summary>
[IsoId("_6hDwcZGpEem-9Y6mq5ZH3Q")]
[DisplayName("Transfer Reference")]
public record TransferReference15
{
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction for which the cancellation request is sent, as assigned by the instructing party.
    /// </summary>
    [IsoId("_61cFAZGpEem-9Y6mq5ZH3Q")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_61cFA5GpEem-9Y6mq5ZH3Q")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_61cFBZGpEem-9Y6mq5ZH3Q")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_61cFB5GpEem-9Y6mq5ZH3Q")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_61cFCZGpEem-9Y6mq5ZH3Q")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReason { get; init; }
}
