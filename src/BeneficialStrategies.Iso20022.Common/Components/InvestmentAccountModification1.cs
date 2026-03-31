// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information about the reason for the modification and about the application request which triggered this modification.
/// </summary>
[IsoId("_qtE6YQjhEeSI9qETkJHgqw")]
[DisplayName("Investment Account Modification")]
public record InvestmentAccountModification1
{
    /// <summary>
    /// Reason for the modification brought to the investment account information.
    /// </summary>
    [IsoId("_rImYwQjhEeSI9qETkJHgqw")]
    [DisplayName("Modification Reason")]
    [IsoXmlTag("ModRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ModificationReason { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    [IsoId("_rImYwwjhEeSI9qETkJHgqw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer.
    /// </summary>
    [IsoId("_bOgTkgjhEeSI9qETkJHgqw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer as allocated by the counterparty.
    /// </summary>
    [IsoId("_bOgTkwjhEeSI9qETkJHgqw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }
}
