// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Account Entry Search8.
/// </summary>
[IsoId("_3RossTEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Account Entry Search8")]
public record CashAccountEntrySearch8
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } =
        [];

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification272? AccountOwner { get; init; }

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Entry Amount.
    /// </summary>
    [DisplayName("Entry Amount")]
    [IsoXmlTag("NtryAmt")]
    public ValueList<ActiveOrHistoricAmountRange2Choice_> EntryAmount { get; init; } = [];

    /// <summary>
    /// Entry Amount Currency.
    /// </summary>
    [DisplayName("Entry Amount Currency")]
    [IsoXmlTag("NtryAmtCcy")]
    public ValueList<ActiveOrHistoricCurrencyCode> EntryAmountCurrency { get; init; } = [];

    /// <summary>
    /// Entry Date.
    /// </summary>
    [DisplayName("Entry Date")]
    [IsoXmlTag("NtryDt")]
    public ValueList<DateAndDateTimeSearch3Choice_> EntryDate { get; init; } = [];

    /// <summary>
    /// Entry Status.
    /// </summary>
    [DisplayName("Entry Status")]
    [IsoXmlTag("NtrySts")]
    public ValueList<EntryStatus1Code> EntryStatus { get; init; } = [];
}
