// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_RyB8X9p-Ed-ak6NoX_4Aeg_462397282")]
[DisplayName("Investment Account")]
public record InvestmentAccount27
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_RyB8YNp-Ed-ak6NoX_4Aeg_462397308")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_RyB8Ydp-Ed-ak6NoX_4Aeg_462397342")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountStatus2Code Status { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_RyB8Ytp-Ed-ak6NoX_4Aeg_462397384")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_RyLGQNp-Ed-ak6NoX_4Aeg_462397419")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; }

    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_RyLGQdp-Ed-ak6NoX_4Aeg_462397462")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public FundCashAccount3Code? Type { get; init; }

    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_RyLGQtp-Ed-ak6NoX_4Aeg_462397497")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; }

    /// <summary>
    /// Ownership status of the account, eg, joint owners.
    /// </summary>
    [IsoId("_RyLGQ9p-Ed-ak6NoX_4Aeg_462397539")]
    [DisplayName("Ownership Type")]
    [IsoXmlTag("OwnrshTp")]
    public required AccountOwnershipType3Code OwnershipType { get; init; }

    /// <summary>
    /// Ownership status of the account, eg, joint owners.
    /// </summary>
    [IsoId("_RyLGRNp-Ed-ak6NoX_4Aeg_462397851")]
    [DisplayName("Extended Ownership Type")]
    [IsoXmlTag("XtndedOwnrshTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOwnershipType { get; init; }

    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_RyLGRdp-Ed-ak6NoX_4Aeg_463318115")]
    [DisplayName("Tax Exemption Reason")]
    [IsoXmlTag("TaxXmptnRsn")]
    public TaxExemptReason1Code? TaxExemptionReason { get; init; }

    /// <summary>
    /// Tax advantage specific to the account.
    /// </summary>
    [IsoId("_Ry7UMNp-Ed-ak6NoX_4Aeg_463318150")]
    [DisplayName("Extended Tax Exemption Reason")]
    [IsoXmlTag("XtndedTaxXmptnRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedTaxExemptionReason { get; init; }

    /// <summary>
    /// Regularity at which a statement is issued.
    /// </summary>
    [IsoId("_Ry7UMdp-Ed-ak6NoX_4Aeg_463318193")]
    [DisplayName("Statement Frequency")]
    [IsoXmlTag("StmtFrqcy")]
    public EventFrequency1Code? StatementFrequency { get; init; }

    /// <summary>
    /// Regularity at which a statement is issued.
    /// </summary>
    [IsoId("_Ry7UMtp-Ed-ak6NoX_4Aeg_1894511217")]
    [DisplayName("Extended Statement Frequency")]
    [IsoXmlTag("XtndedStmtFrqcy")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedStatementFrequency { get; init; }

    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_Ry7UM9p-Ed-ak6NoX_4Aeg_462397894")]
    [DisplayName("Reference Currency")]
    [IsoXmlTag("RefCcy")]
    public ActiveCurrencyCode? ReferenceCurrency { get; init; }

    /// <summary>
    /// Language for all communication concerning the account.
    /// </summary>
    [IsoId("_Ry7UNNp-Ed-ak6NoX_4Aeg_462397911")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_Ry7UNdp-Ed-ak6NoX_4Aeg_463317918")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Method by which the tax (withholding tax) is to be processed i.e. either withheld at source or tax information reported to tax authorities or tax information is reported due to the provision of a tax certificate.
    /// </summary>
    [IsoId("_RzEeINp-Ed-ak6NoX_4Aeg_463317995")]
    [DisplayName("Tax Withholding Method")]
    [IsoXmlTag("TaxWhldgMtd")]
    public TaxWithholdingMethod1Code? TaxWithholdingMethod { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_RzEeIdp-Ed-ak6NoX_4Aeg_463318038")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation rights program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_RzEeItp-Ed-ak6NoX_4Aeg_463318073")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Number of account owners or related parties required to authorise transactions on the account.
    /// </summary>
    [IsoId("_RzEeI9p-Ed-ak6NoX_4Aeg_463318487")]
    [DisplayName("Required Signatories Number")]
    [IsoXmlTag("ReqrdSgntriesNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RequiredSignatoriesNumber { get; init; }

    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_RzEeJNp-Ed-ak6NoX_4Aeg_463318522")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; }

    /// <summary>
    /// Parameters to be applied on deal amount for orders when the amount is a fractional number.
    /// </summary>
    [IsoId("_RzEeJdp-Ed-ak6NoX_4Aeg_463318566")]
    [DisplayName("Rounding Details")]
    [IsoXmlTag("RndgDtls")]
    public RoundingParameters1? RoundingDetails { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_RzEeJtp-Ed-ak6NoX_4Aeg_463319160")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_RzEeJ9p-Ed-ak6NoX_4Aeg_-1605146589")]
    [DisplayName("Funds Details")]
    [IsoXmlTag("FndsDtls")]
    public FinancialInstrument10? FundsDetails { get; init; }

    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_RzEeKNp-Ed-ak6NoX_4Aeg_463319497")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<CashAccount12> CashAccount { get; init; } = [];

    /// <summary>
    /// Part of the investment account to or from which securities entries are made.
    /// </summary>
    [IsoId("_RzEeKdp-Ed-ak6NoX_4Aeg_463319557")]
    [DisplayName("Securities Account")]
    [IsoXmlTag("SctiesAcct")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<SecuritiesAccount4> SecuritiesAccount { get; init; } = [];
}
