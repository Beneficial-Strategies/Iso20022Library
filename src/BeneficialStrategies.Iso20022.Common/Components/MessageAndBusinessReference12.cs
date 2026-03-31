// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("_43AM8ZGqEem-9Y6mq5ZH3Q")]
[DisplayName("Message And Business Reference")]
public record MessageAndBusinessReference12
{
    /// <summary>
    /// Reference to the message or communication that was previously sent.
    /// </summary>
    [IsoId("_5Lrcd5GqEem-9Y6mq5ZH3Q")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References68Choice_? Reference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_5LrceZGqEem-9Y6mq5ZH3Q")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_5Lrce5GqEem-9Y6mq5ZH3Q")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_5LrcfZGqEem-9Y6mq5ZH3Q")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_5Lrcf5GqEem-9Y6mq5ZH3Q")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Investment account information of the transfer message for which the status is requested.
    /// </summary>
    [IsoId("_5LrcgZGqEem-9Y6mq5ZH3Q")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount72? InvestmentAccountDetails { get; init; }
}
