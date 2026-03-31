// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_VKl9Cc3zEee5nJBZsW8MFQ")]
[DisplayName("Securities Financing Transaction Details")]
public record SecuritiesFinancingTransactionDetails41
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_VKl9Dc3zEee5nJBZsW8MFQ")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? SecuritiesFinancingTradeIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_VKl9Fc3zEee5nJBZsW8MFQ")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_VKl9Hc3zEee5nJBZsW8MFQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate7Choice_? TerminationDate { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_VKl9Jc3zEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType67Choice_? RateType { get; init; }

    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_VKl9Lc3zEee5nJBZsW8MFQ")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework4Choice_? LegalFramework { get; init; }

    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_VKl9Nc3zEee5nJBZsW8MFQ")]
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MaturityDateModification { get; init; }

    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_VKl9Pc3zEee5nJBZsW8MFQ")]
    [DisplayName("Interest Payment")]
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InterestPayment { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_VKl9Rc3zEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName2? VariableRateSupport { get; init; }

    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_VKl9Tc3zEee5nJBZsW8MFQ")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_VKl9Vc3zEee5nJBZsW8MFQ")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TransactionCallDelay { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_VKl9Xc3zEee5nJBZsW8MFQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection59? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_VKl9Zc3zEee5nJBZsW8MFQ")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection59? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_VKl9bc3zEee5nJBZsW8MFQ")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; }
}
