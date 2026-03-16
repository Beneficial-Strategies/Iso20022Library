// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the type of opening instruction and identification of the application request.
/// </summary>
[IsoId("_9UTJoQjgEeSI9qETkJHgqw")]
[DisplayName("Investment Account Opening")]
public record InvestmentAccountOpening1
{
    /// <summary>
    /// Specifies if the account opening instruction is about a newly created account or a supplementary account.
    /// </summary>
    [IsoId("_9uyGMQjgEeSI9qETkJHgqw")]
    [DisplayName("Opening Type")]
    [IsoXmlTag("OpngTp")]
    public required AccountOpeningType1Code OpeningType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening request at application level.
    /// </summary>
    [IsoId("_9uyGMwjgEeSI9qETkJHgqw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer.
    /// </summary>
    [IsoId("_GdTVggjhEeSI9qETkJHgqw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer as allocated by the counterparty.
    /// </summary>
    [IsoId("_GdTVgwjhEeSI9qETkJHgqw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }
}
