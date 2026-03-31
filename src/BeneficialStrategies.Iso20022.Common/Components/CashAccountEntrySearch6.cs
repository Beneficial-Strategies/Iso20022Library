// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a cash entry.
/// </summary>
[IsoId("_PEwWiW49EeiU9cctagi5ow")]
[DisplayName("Cash Account Entry Search")]
public record CashAccountEntrySearch6
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_PTgkN249EeiU9cctagi5ow")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } =
        [];

    /// <summary>
    /// Specifies the entry amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_PTgkOW49EeiU9cctagi5ow")]
    [DisplayName("Entry Amount")]
    [IsoXmlTag("NtryAmt")]
    public ValueList<ActiveOrHistoricAmountRange2Choice_> EntryAmount { get; init; } = [];

    /// <summary>
    /// Currency of the entry amount.
    /// </summary>
    [IsoId("_PTgkO249EeiU9cctagi5ow")]
    [DisplayName("Entry Amount Currency")]
    [IsoXmlTag("NtryAmtCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> EntryAmountCurrency { get; init; } = [];

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_PTgkPW49EeiU9cctagi5ow")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_PTgkP249EeiU9cctagi5ow")]
    [DisplayName("Entry Status")]
    [IsoXmlTag("NtrySts")]
    public SimpleValueList<EntryStatus1Code> EntryStatus { get; init; } = [];

    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_PTgkQW49EeiU9cctagi5ow")]
    [DisplayName("Entry Date")]
    [IsoXmlTag("NtryDt")]
    public ValueList<DateAndDateTimeSearch3Choice_> EntryDate { get; init; } = [];

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_PTgkQ249EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification135? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    [IsoId("_PTgkRW49EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; }
}
