// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the central counterparty clearing time.
/// </summary>
[IsoId("_-GFDERZNEe2QNcZTDeoKnQ")]
[DisplayName("Clearing Party And Time")]
public record ClearingPartyAndTime22
{
    /// <summary>
    /// Identifies the central counterparty (CCP) that cleared the transaction.
    /// </summary>
    [IsoId("_-HsMpxZNEe2QNcZTDeoKnQ")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public OrganisationIdentification15Choice_? CCP { get; init; }

    /// <summary>
    /// Time and date when the original derivative was received by the central counterparty for clearing.
    /// </summary>
    [IsoId("_-HsMqRZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Receipt Date Time")]
    [IsoXmlTag("ClrRctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ClearingReceiptDateTime { get; init; }

    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    [IsoId("_-HsMqxZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Date Time")]
    [IsoXmlTag("ClrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ClearingDateTime { get; init; }

    /// <summary>
    /// Unique identifier of each clearing derivative that replaces the original derivative that was submitted for clearing to the central counterparty, other than the identifier for the transaction being reported.
    /// </summary>
    [IsoId("_-HsMrRZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Identifier")]
    [IsoXmlTag("ClrIdr")]
    public UniqueTransactionIdentifier2Choice_? ClearingIdentifier { get; init; }

    /// <summary>
    /// Unique identifier of the original derivative submitted for clearing to the central counterparty that is replaced by the clearing derivative.
    /// </summary>
    [IsoId("_-HsMrxZNEe2QNcZTDeoKnQ")]
    [DisplayName("Original Identifier")]
    [IsoXmlTag("OrgnlIdr")]
    public UniqueTransactionIdentifier2Choice_? OriginalIdentifier { get; init; }

    /// <summary>
    /// Identifies the trade repository to which the original derivative was reported.
    /// </summary>
    [IsoId("_-HsMsRZNEe2QNcZTDeoKnQ")]
    [DisplayName("Original Trade Repository Identifier")]
    [IsoXmlTag("OrgnlTradRpstryIdr")]
    public OrganisationIdentification15Choice_? OriginalTradeRepositoryIdentifier { get; init; }

    /// <summary>
    /// Indicator of whether the clearing member acted as principal for a house trade or an agent for a customer trade.
    /// </summary>
    [IsoId("_-HsMsxZNEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Account Origin")]
    [IsoXmlTag("ClrAcctOrgn")]
    public ClearingAccountType4Code? ClearingAccountOrigin { get; init; }
}
