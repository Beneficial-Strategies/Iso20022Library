// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
[IsoId("_F8Sz8cguEeuGrNSsxk3B0A")]
[DisplayName("Loan Data")]
public record LoanData134
{
    /// <summary>
    /// Identification of the type of the transaction.
    /// </summary>
    [IsoId("_F9r7E8guEeuGrNSsxk3B0A")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public ExposureType10Code? ContractType { get; init; }

    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_F9r7FcguEeuGrNSsxk3B0A")]
    [DisplayName("Cleared")]
    [IsoXmlTag("Clrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Cleared { get; init; }

    /// <summary>
    /// Unique code determined by the reporting counterparty identifying the portfolio.
    /// </summary>
    [IsoId("_F9r7F8guEeuGrNSsxk3B0A")]
    [DisplayName("Portfolio Code")]
    [IsoXmlTag("PrtflCd")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? PortfolioCode { get; init; }

    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_F9r7GcguEeuGrNSsxk3B0A")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public TradingVenueType1Choice_? TradingVenue { get; init; }

    /// <summary>
    /// Type of agreement expressed as a code set. Reference to the master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_F9r7G8guEeuGrNSsxk3B0A")]
    [DisplayName("Master Agreement Type")]
    [IsoXmlTag("MstrAgrmtTp")]
    public ExternalAgreementType1Code? MasterAgreementType { get; init; }

    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
    /// </summary>
    [IsoId("_F9r7HcguEeuGrNSsxk3B0A")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
    /// </summary>
    [IsoId("_F9r7H8guEeuGrNSsxk3B0A")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; }

    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term.
    /// </summary>
    [IsoId("_F9r7IcguEeuGrNSsxk3B0A")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ContractTerm6Choice_? Term { get; init; }

    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_F9r7I8guEeuGrNSsxk3B0A")]
    [DisplayName("Rates")]
    [IsoXmlTag("Rates")]
    public Rates1Choice_? Rates { get; init; }

    /// <summary>
    /// Medium of exchange of currency.
    /// </summary>
    [IsoId("_F9r7JcguEeuGrNSsxk3B0A")]
    [DisplayName("Principal Amount Currency")]
    [IsoXmlTag("PrncplAmtCcy")]
    public ActiveOrHistoricCurrencyCode? PrincipalAmountCurrency { get; init; }

    /// <summary>
    /// Currency in which the the security or commodity price is denominated.
    /// </summary>
    [IsoId("_F9r7J8guEeuGrNSsxk3B0A")]
    [DisplayName("Price Currency")]
    [IsoXmlTag("PricCcy")]
    public ActiveOrHistoricCurrencyCode? PriceCurrency { get; init; }

    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_F9r7KcguEeuGrNSsxk3B0A")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security49? Security { get; init; }

    /// <summary>
    /// Margin loans in base currency.
    /// </summary>
    [IsoId("_F9r7K8guEeuGrNSsxk3B0A")]
    [DisplayName("Outstanding Margin Loan Currency")]
    [IsoXmlTag("OutsdngMrgnLnCcy")]
    public ActiveOrHistoricCurrencyCode? OutstandingMarginLoanCurrency { get; init; }
}
