// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingContract2Choice
{
    /// <summary>
    /// Underlying registered contract is a loan.
    /// </summary>
    [IsoId("_JgnYgW49EeiU9cctagi5ow")]
    [DisplayName("Loan")]
    public record Loan : UnderlyingContract2Choice_
    {
        /// <summary>
        /// Contract document referenced from this loan agreement.
        /// </summary>
        [IsoId("_JtldgW49EeiU9cctagi5ow")]
        [DisplayName("Contract Document Identification")]
        [IsoXmlTag("CtrctDocId")]
        public required DocumentIdentification22 ContractDocumentIdentification { get; init; }

        /// <summary>
        /// Party that is specified as the buyer for this loan agreement.
        /// </summary>
        [IsoId("_Jtldg249EeiU9cctagi5ow")]
        [DisplayName("Buyer")]
        [IsoXmlTag("Buyr")]
        public ValueList<TradeParty5> Buyer { get; init; } = [];

        // ID for the above is _Jtldg249EeiU9cctagi5ow

        /// <summary>
        /// Party that is specified as the seller for this loan agreement.
        /// </summary>
        [IsoId("_JtldhW49EeiU9cctagi5ow")]
        [DisplayName("Seller")]
        [IsoXmlTag("Sellr")]
        public ValueList<TradeParty5> Seller { get; init; } = [];

        // ID for the above is _JtldhW49EeiU9cctagi5ow

        /// <summary>
        /// Loan amount as defined in the contract.
        /// </summary>
        [IsoId("_Jtldh249EeiU9cctagi5ow")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Planned final repayment date at the time of issuance.
        /// </summary>
        [IsoId("_JtldiW49EeiU9cctagi5ow")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; }

        /// <summary>
        /// Indicates whether the contract duration is extended or not.
        /// </summary>
        [IsoId("_Jtldi249EeiU9cctagi5ow")]
        [DisplayName("Prolongation Flag")]
        [IsoXmlTag("PrlngtnFlg")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator ProlongationFlag { get; init; }

        /// <summary>
        /// Start date of the loan contract.
        /// </summary>
        [IsoId("_JtldjW49EeiU9cctagi5ow")]
        [DisplayName("Start Date")]
        [IsoXmlTag("StartDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate StartDate { get; init; }

        /// <summary>
        /// Currency in which the loan is being settled.
        /// </summary>
        [IsoId("_Jtldj249EeiU9cctagi5ow")]
        [DisplayName("Settlement Currency")]
        [IsoXmlTag("SttlmCcy")]
        public required ActiveCurrencyCode SettlementCurrency { get; init; }

        /// <summary>
        /// Special conditions applicable when the amount is credited outside of the country.
        /// </summary>
        [IsoId("_JtldkW49EeiU9cctagi5ow")]
        [DisplayName("Special Conditions")]
        [IsoXmlTag("SpclConds")]
        public SpecialCondition1? SpecialConditions { get; init; }

        /// <summary>
        /// Loan duration in a coded form.
        /// </summary>
        [IsoId("_Jtldk249EeiU9cctagi5ow")]
        [DisplayName("Duration Code")]
        [IsoXmlTag("DrtnCd")]
        [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
        public required IsoExact1NumericText DurationCode { get; init; }

        /// <summary>
        /// Interest rate for the loan.
        /// </summary>
        [IsoId("_JtldlW49EeiU9cctagi5ow")]
        [DisplayName("Interest Rate")]
        [IsoXmlTag("IntrstRate")]
        public required InterestRate2Choice_ InterestRate { get; init; }

        /// <summary>
        /// One part or division of the loan, used to define the repayment.
        /// </summary>
        [IsoId("_Jtldl249EeiU9cctagi5ow")]
        [DisplayName("Tranche")]
        [IsoXmlTag("Trch")]
        public LoanContractTranche1? Tranche { get; init; }

        /// <summary>
        /// Schedule of the payments defined for the loan contract.
        /// </summary>
        [IsoId("_JtldmW49EeiU9cctagi5ow")]
        [DisplayName("Payment Schedule")]
        [IsoXmlTag("PmtSchdl")]
        public PaymentSchedule1Choice_? PaymentSchedule { get; init; }

        /// <summary>
        /// Schedule of the interest payments defined for the loan contract.
        /// </summary>
        [IsoId("_Jtldm249EeiU9cctagi5ow")]
        [DisplayName("Interest Schedule")]
        [IsoXmlTag("IntrstSchdl")]
        public required InterestPaymentSchedule1Choice_ InterestSchedule { get; init; }

        /// <summary>
        /// Loan is an intra company loan.
        /// </summary>
        [IsoId("_JtldnW49EeiU9cctagi5ow")]
        [DisplayName("Intra Company Loan")]
        [IsoXmlTag("IntraCpnyLn")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; }

        /// <summary>
        /// Details of the collateral for the loan.
        /// </summary>
        [IsoId("_Jtldn249EeiU9cctagi5ow")]
        [DisplayName("Collateral")]
        [IsoXmlTag("Coll")]
        public ContractCollateral1? Collateral { get; init; }

        /// <summary>
        /// Loan offered by a group of lenders (called a syndicate) who work together to provide funds for a single borrower.
        /// </summary>
        [IsoId("_JtldoW49EeiU9cctagi5ow")]
        [DisplayName("Syndicated Loan")]
        [IsoXmlTag("SndctdLn")]
        public SyndicatedLoan2? SyndicatedLoan { get; init; }

        /// <summary>
        /// Documents provided as attachments to the loan contract.
        /// </summary>
        [IsoId("_Jtldo249EeiU9cctagi5ow")]
        [DisplayName("Attachment")]
        [IsoXmlTag("Attchmnt")]
        public DocumentGeneralInformation3? Attachment { get; init; }
    }
}
