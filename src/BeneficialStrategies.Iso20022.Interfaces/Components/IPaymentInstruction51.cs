// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the debit side of the payment transactions included in the credit transfer initiation.
/// </summary>
[IsoId("a376f506-35bc-4f88-9925-eceabe35beea")]
public interface IPaymentInstruction51 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("dfeb6565-c0a1-4f42-98be-7280338a0602")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    IsoMax35Text PaymentInformationIdentification { get; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("25277459-8fd6-4b15-9818-eb4466437d8e")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    PaymentMethod3Code PaymentMethod { get; }

    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    [IsoId("792e197b-8059-4633-822e-c2e08e2c9eab")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    IAdviceType1? RequestedAdviceType { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.
    /// </summary>
    [IsoId("0dcd68c1-4680-4ea8-979f-db22db1ea892")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [IsoId("5bb724bf-3b06-4052-abd4-6bbd3bc3c929")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText? NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [IsoId("9ea5345e-08d4-42ac-8ba6-19b791caf194")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("5702cc97-50ec-42e4-a6a0-e7990c68e96b")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation26? PaymentTypeInformation { get; }

    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment.
    /// </summary>
    [IsoId("fabfdc67-f1b0-4093-9749-ae4a9a37d218")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    IDateAndDateTime2Choice RequestedExecutionDate { get; }

    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    [IsoId("7f3ee28b-3e13-410c-ae42-32bf1a03e034")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    IsoISODate? PoolingAdjustmentDate { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("8cbc1d76-4752-4b60-ad06-cf654d5ed8c4")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification272 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("77c33575-9d67-40bf-91c0-444673414068")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40 DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("9519236d-4e5b-43c9-ba39-5350f6c5b21b")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("e1b92d70-b384-4ab7-a835-41fb9e651750")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount40? DebtorAgentAccount { get; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent.
    /// </summary>
    [IsoId("7741a44b-38b8-4773-8179-da314dc13e6c")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    IsoMax140Text? InstructionForDebtorAgent { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("df870f37-ef4b-4f2b-9460-eed769150513")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification272? UltimateDebtor { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("195dd6c9-842b-4fbc-8e9f-ce671def233c")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Account used to process charges associated with a transaction.
    /// </summary>
    [IsoId("96a6d108-ae5c-49fc-9583-f4a1df602599")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    ICashAccount40? ChargesAccount { get; }

    /// <summary>
    /// Agent that services a charges account.
    /// </summary>
    [IsoId("3d017737-58db-4aa5-8b3f-001b8c73293b")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    IBranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; }

    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("efdc5154-cbfe-46ef-a00b-941804dc87a5")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    IEnumerable<ICreditTransferTransaction76> CreditTransferTransactionInformation { get; }
}
