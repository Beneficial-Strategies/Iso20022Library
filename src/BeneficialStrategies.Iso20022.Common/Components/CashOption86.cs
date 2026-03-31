// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_q5hAwTQLEe2o-K1dwNg8Gg")]
[DisplayName("Cash Option")]
public record CashOption86
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_rSaB4TQLEe2o-K1dwNg8Gg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_rSaB6TQLEe2o-K1dwNg8Gg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account8Choice_? Account { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_rSaB8TQLEe2o-K1dwNg8Gg")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PostingDate { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_rSaB-TQLEe2o-K1dwNg8Gg")]
    [DisplayName("Original Posting Date")]
    [IsoXmlTag("OrgnlPstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OriginalPostingDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_rSaB-zQLEe2o-K1dwNg8Gg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_rSaCAzQLEe2o-K1dwNg8Gg")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; }
}
