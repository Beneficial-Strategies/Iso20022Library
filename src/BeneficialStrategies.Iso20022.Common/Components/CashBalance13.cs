// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance details for a cash account.
/// </summary>
[IsoId("_nkznoXYOEei3jO6riKEVXg")]
[DisplayName("Cash Balance")]
public record CashBalance13
{
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    [IsoId("_nwIG03YOEei3jO6riKEVXg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_nwIG1XYOEei3jO6riKEVXg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_nwIG13YOEei3jO6riKEVXg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public BalanceType11Choice_? Type { get; init; }

    /// <summary>
    /// Current status of a cash balance.
    /// </summary>
    [IsoId("_nwIG2XYOEei3jO6riKEVXg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public BalanceStatus1Code? Status { get; init; }

    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_nwIG23YOEei3jO6riKEVXg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Date or date time when the balance was last updated following an entry posted to the account, in the books of the account servicing institution.
    /// </summary>
    [IsoId("_t2x8AXYOEei3jO6riKEVXg")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Number of payments taken into account for the calculation of the cash balance value.
    /// </summary>
    [IsoId("_nwIG3XYOEei3jO6riKEVXg")]
    [DisplayName("Number Of Payments")]
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPayments { get; init; }

    /// <summary>
    /// Type providing further information on balance restrictions.
    /// </summary>
    [IsoId("_nwIG33YOEei3jO6riKEVXg")]
    [DisplayName("Restriction Type")]
    [IsoXmlTag("RstrctnTp")]
    public BalanceRestrictionType1? RestrictionType { get; init; }
}
