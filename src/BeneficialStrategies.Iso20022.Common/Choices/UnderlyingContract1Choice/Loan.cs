// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingContract1Choice
{
    /// <summary>
    /// Underlying registered contract is a loan.
    /// </summary>
    [IsoId("_tf9isNLJEeSdq5yU2aaSNw")]
    [DisplayName("Loan")]
    public record Loan : UnderlyingContract1Choice_
    {
        /// <summary>
        /// Contract document referenced from this loan agreement.
        /// </summary>
        [IsoId("_PSp2JdNDEeSDLevdaFPXHw")]
        [DisplayName("Contract Document Identification")]
        [IsoXmlTag("CtrctDocId")]
        public required DocumentIdentification22 ContractDocumentIdentification { get; init; }

        /// <summary>
        /// Party that is specified as the buyer for this loan agreement.
        /// </summary>
        [IsoId("_PSp2I9NDEeSDLevdaFPXHw")]
        [DisplayName("Buyer")]
        [IsoXmlTag("Buyr")]
        public ValueList<TradeParty2> Buyer { get; init; } = [];

        // ID for the above is _PSp2I9NDEeSDLevdaFPXHw

        /// <summary>
        /// Party that is specified as the seller for this loan agreement.
        /// </summary>
        [IsoId("_PSp2JNNDEeSDLevdaFPXHw")]
        [DisplayName("Seller")]
        [IsoXmlTag("Sellr")]
        public ValueList<TradeParty2> Seller { get; init; } = [];

        // ID for the above is _PSp2JNNDEeSDLevdaFPXHw

        /// <summary>
        /// Loan amount as defined in the contract.
        /// </summary>
        [IsoId("_1NQTMdNFEeSDLevdaFPXHw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Planned final repayment date at the time of issuance.
        /// </summary>
        [IsoId("_eSC7tNNFEeSDLevdaFPXHw")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; }

        /// <summary>
        /// Indicates whether the contract duration is extended or not.
        /// </summary>
        [IsoId("_eSC7tdNFEeSDLevdaFPXHw")]
        [DisplayName("Prolongation Flag")]
        [IsoXmlTag("PrlngtnFlg")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator ProlongationFlag { get; init; }

        /// <summary>
        /// Start date of the loan contract.
        /// </summary>
        [IsoId("_eSC7ttNFEeSDLevdaFPXHw")]
        [DisplayName("Start Date")]
        [IsoXmlTag("StartDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate StartDate { get; init; }

        /// <summary>
        /// Currency in which the loan is being settled.
        /// </summary>
        [IsoId("_eSC7t9NFEeSDLevdaFPXHw")]
        [DisplayName("Settlement Currency")]
        [IsoXmlTag("SttlmCcy")]
        public required ActiveCurrencyCode SettlementCurrency { get; init; }

        /// <summary>
        /// When the amount is credited outside of the country, special conditions are applicable.
        /// </summary>
        [IsoId("_z85K09OCEeSQ_-lmj1tzfw")]
        [DisplayName("Special Conditions")]
        [IsoXmlTag("SpclConds")]
        public SpecialCondition1? SpecialConditions { get; init; }

        /// <summary>
        /// Loan duration in a coded form.
        /// </summary>
        [IsoId("_xGFgUNODEeSQ_-lmj1tzfw")]
        [DisplayName("Duration Code")]
        [IsoXmlTag("DrtnCd")]
        [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
        public required IsoExact1NumericText DurationCode { get; init; }

        /// <summary>
        /// Interest rate for the loan.
        /// </summary>
        [IsoId("_i_afMNNEEeSDLevdaFPXHw")]
        [DisplayName("Interest Rate")]
        [IsoXmlTag("IntrstRate")]
        public required InterestRate2Choice_ InterestRate { get; init; }

        /// <summary>
        /// One part or division of the loan, used to define the repayment.
        /// </summary>
        [IsoId("_QOgk8tNEEeSDLevdaFPXHw")]
        [DisplayName("Tranche")]
        [IsoXmlTag("Trch")]
        public LoanContractTranche1? Tranche { get; init; }

        /// <summary>
        /// Schedule of the payments defined for the loan contract.
        /// </summary>
        [IsoId("_bGxH8NNEEeSDLevdaFPXHw")]
        [DisplayName("Payment Schedule")]
        [IsoXmlTag("PmtSchdl")]
        public PaymentSchedule1Choice_? PaymentSchedule { get; init; }

        /// <summary>
        /// Schedule of the interest payments defined for the loan contract.
        /// </summary>
        [IsoId("_ipBAgdOIEeSQ_-lmj1tzfw")]
        [DisplayName("Interest Schedule")]
        [IsoXmlTag("IntrstSchdl")]
        public required InterestPaymentSchedule1Choice_ InterestSchedule { get; init; }

        /// <summary>
        /// Loan is an intra company loan.
        /// </summary>
        [IsoId("_qhLCcDm4EeWDb47rJ6ki4Q")]
        [DisplayName("Intra Company Loan")]
        [IsoXmlTag("IntraCpnyLn")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; }

        /// <summary>
        /// Details of the collateral for the loan.
        /// </summary>
        [IsoId("_guNRkNNEEeSDLevdaFPXHw")]
        [DisplayName("Collateral")]
        [IsoXmlTag("Coll")]
        public ContractCollateral1? Collateral { get; init; }

        /// <summary>
        /// Loan offered by a group of lenders (called a syndicate) who work together to provide funds for a single borrower.
        /// </summary>
        [IsoId("_KEsEMNOKEeSQ_-lmj1tzfw")]
        [DisplayName("Syndicated Loan")]
        [IsoXmlTag("SndctdLn")]
        public SyndicatedLoan1? SyndicatedLoan { get; init; }

        /// <summary>
        /// Documents provided as attachments to the loan contract.
        /// </summary>
        [IsoId("_HKFzkdNDEeSDLevdaFPXHw")]
        [DisplayName("Attachment")]
        [IsoXmlTag("Attchmnt")]
        public DocumentGeneralInformation3? Attachment { get; init; }
    }
}
