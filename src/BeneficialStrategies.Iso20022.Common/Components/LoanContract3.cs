// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract by which an amount of money in exchange for future repayment of the principal amount along with interest or other finance charges.
/// </summary>
[IsoId("_2n360bGIEeuSTr8k0UEM8A")]
[DisplayName("Loan Contract")]
public record LoanContract3
{
    /// <summary>
    /// Contract document referenced from this loan agreement.
    /// </summary>
    [IsoId("_2o1kIbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public required DocumentIdentification22 ContractDocumentIdentification { get; init; }

    /// <summary>
    /// Type code of the loan contract.
    /// </summary>
    [IsoId("_o_ORYLb6Eeu9Cp6InX88Vw")]
    [DisplayName("Loan Type Identification")]
    [IsoXmlTag("LnTpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LoanTypeIdentification { get; init; }

    /// <summary>
    /// Party that is specified as the buyer for this loan agreement.
    /// </summary>
    [IsoId("_2o1kI7GIEeuSTr8k0UEM8A")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty5> Buyer { get; init; } = [];

    // ID for the above is _2o1kI7GIEeuSTr8k0UEM8A

    /// <summary>
    /// Party that is specified as the seller for this loan agreement.
    /// </summary>
    [IsoId("_2o1kJbGIEeuSTr8k0UEM8A")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty5> Seller { get; init; } = [];

    // ID for the above is _2o1kJbGIEeuSTr8k0UEM8A

    /// <summary>
    /// Loan amount as defined in the contract.
    /// </summary>
    [IsoId("_2o1kJ7GIEeuSTr8k0UEM8A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_2o1kKbGIEeuSTr8k0UEM8A")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// When absent, the flag meaning is NotApplicable.
    /// </summary>
    [IsoId("_2o1kK7GIEeuSTr8k0UEM8A")]
    [DisplayName("Prolongation Flag")]
    [IsoXmlTag("PrlngtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; }

    /// <summary>
    /// Start date of the loan contract.
    /// </summary>
    [IsoId("_2o1kLbGIEeuSTr8k0UEM8A")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Currency in which the loan is being settled.
    /// </summary>
    [IsoId("_2o1kL7GIEeuSTr8k0UEM8A")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Special conditions applicable when the amount is credited outside of the country.
    /// </summary>
    [IsoId("_2o1kMbGIEeuSTr8k0UEM8A")]
    [DisplayName("Special Conditions")]
    [IsoXmlTag("SpclConds")]
    public SpecialCondition1? SpecialConditions { get; init; }

    /// <summary>
    /// Loan duration in a coded form.
    /// </summary>
    [IsoId("_2o1kM7GIEeuSTr8k0UEM8A")]
    [DisplayName("Duration Code")]
    [IsoXmlTag("DrtnCd")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? DurationCode { get; init; }

    /// <summary>
    /// Interest rate for the loan.
    /// </summary>
    [IsoId("_2o1kNbGIEeuSTr8k0UEM8A")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate2Choice_? InterestRate { get; init; }

    /// <summary>
    /// One part or division of the loan, used to define the repayment.
    /// </summary>
    [IsoId("_2o1kN7GIEeuSTr8k0UEM8A")]
    [DisplayName("Tranche")]
    [IsoXmlTag("Trch")]
    public LoanContractTranche1? Tranche { get; init; }

    /// <summary>
    /// Schedule of the payments defined for the loan contract.
    /// </summary>
    [IsoId("_2o1kObGIEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule")]
    [IsoXmlTag("PmtSchdl")]
    public PaymentSchedule1? PaymentSchedule { get; init; }

    /// <summary>
    /// Schedule of the interest payments defined for the loan contract.
    /// </summary>
    [IsoId("_2o1kO7GIEeuSTr8k0UEM8A")]
    [DisplayName("Interest Schedule")]
    [IsoXmlTag("IntrstSchdl")]
    public InterestPaymentSchedule1? InterestSchedule { get; init; }

    /// <summary>
    /// Loan is an intra company loan.
    /// </summary>
    [IsoId("_2o1kPbGIEeuSTr8k0UEM8A")]
    [DisplayName("Intra Company Loan")]
    [IsoXmlTag("IntraCpnyLn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; }

    /// <summary>
    /// Details of the collateral for the loan.
    /// </summary>
    [IsoId("_2o1kP7GIEeuSTr8k0UEM8A")]
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public ContractCollateral1? Collateral { get; init; }

    /// <summary>
    /// Loan offered by a group of lenders (called a syndicate) who work together to provide funds for a single borrower.
    /// </summary>
    [IsoId("_2o1kQbGIEeuSTr8k0UEM8A")]
    [DisplayName("Syndicated Loan")]
    [IsoXmlTag("SndctdLn")]
    public SyndicatedLoan2? SyndicatedLoan { get; init; }

    /// <summary>
    /// Documents provided as attachments to the loan contract.
    /// </summary>
    [IsoId("_2o1kQ7GIEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public DocumentGeneralInformation5? Attachment { get; init; }
}
