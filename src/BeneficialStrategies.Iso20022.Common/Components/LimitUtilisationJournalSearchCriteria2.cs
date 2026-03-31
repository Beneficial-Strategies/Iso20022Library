// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Utilisation Journal Search Criteria2.
/// </summary>
[IsoId("_iz-VUWdSEemVjsmmE4lqKA")]
[DisplayName("Limit Utilisation Journal Search Criteria2")]
public record LimitUtilisationJournalSearchCriteria2
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136? AccountOwner { get; init; }

    /// <summary>
    /// Bilateral Limit Counterparty Identification.
    /// </summary>
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public required SystemPartyIdentification8 BilateralLimitCounterpartyIdentification { get; init; }

    /// <summary>
    /// Journal Activity Date.
    /// </summary>
    [DisplayName("Journal Activity Date")]
    [IsoXmlTag("JrnlActvtyDt")]
    public required IsoISODate JournalActivityDate { get; init; }

    /// <summary>
    /// Limit Currency.
    /// </summary>
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; }

    /// <summary>
    /// Limit Type.
    /// </summary>
    [DisplayName("Limit Type")]
    [IsoXmlTag("LmtTp")]
    public ValueList<LimitType4Code> LimitType { get; init; } = [];
}
