// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("e15446f0-c889-481e-8637-86a6b94f25e8")]
[Description(
    @"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing."
)]
[Derivations(typeof(PendingReason33Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingFailingReasonV3Code>))]
public enum PendingFailingReasonV3Code
{
    /// <summary>
    /// Account must already be opened in order to process the transfer.
    /// Encoded/decoded by serializers as &quot;ACOP&quot;.
    /// </summary>
    [EnumMember(Value = "ACOP")]
    [IsoId("4e9c830b-e10d-4c1b-b970-be0d9901eac2")]
    [Description(@"Account must already be opened in order to process the transfer.")]
    AccountNotOpen,

    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("74f57479-d0c0-460a-bea7-38ffc8ba09c5")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Additional documents have been requested by the transfer agent.
    /// Encoded/decoded by serializers as &quot;ADRQ&quot;.
    /// </summary>
    [EnumMember(Value = "ADRQ")]
    [IsoId("cae1591f-2d4f-435e-8247-7eec06eab11c")]
    [Description(@"Additional documents have been requested by the transfer agent.")]
    AdditionalDocumentsRequested,

    /// <summary>
    /// Additional documents have been sent.
    /// Encoded/decoded by serializers as &quot;ADS1&quot;.
    /// </summary>
    [EnumMember(Value = "ADS1")]
    [IsoId("a154527c-0303-4057-b012-0de8498c6082")]
    [Description(@"Additional documents have been sent.")]
    AdditionalDocumentsSent1,

    /// <summary>
    /// Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place.
    /// Encoded/decoded by serializers as &quot;ADS2&quot;.
    /// </summary>
    [EnumMember(Value = "ADS2")]
    [IsoId("93dd0b1a-f8bf-4413-9187-65d35ac6d286")]
    [Description(
        @"Upon request of the transfer agent, the intermediary has sent additional documents. The transfer agent has confirmed that all the necessary information is now in place."
    )]
    AdditionalDocumentsSent2,

    /// <summary>
    /// Application form has been sent to the transfer agent.
    /// Encoded/decoded by serializers as &quot;AFST&quot;.
    /// </summary>
    [EnumMember(Value = "AFST")]
    [IsoId("0ab26773-1129-4840-9ab9-d00394563403")]
    [Description(@"Application form has been sent to the transfer agent.")]
    ApplicationFormSent,

    /// <summary>
    /// Transfer agent is investigating.
    /// Encoded/decoded by serializers as &quot;AINV&quot;.
    /// </summary>
    [EnumMember(Value = "AINV")]
    [IsoId("1df371e7-70b6-4a45-bd5b-b5d6f7d9d873")]
    [Description(@"Transfer agent is investigating.")]
    UnderTransferAgentInvestigation,

    /// <summary>
    /// At your request, the Intermediary is checking the status of your instruction with the transfer agent.
    /// Encoded/decoded by serializers as &quot;ASTA&quot;.
    /// </summary>
    [EnumMember(Value = "ASTA")]
    [IsoId("c3e67dee-57e9-4e82-ab2b-38e38c415c23")]
    [Description(
        @"At your request, the Intermediary is checking the status of your instruction with the transfer agent."
    )]
    AwaitingStatus,

    /// <summary>
    /// Tax reclaim has been sent to the tax authorities.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("2ab42ef4-45e3-404d-911a-b265cda3fa78")]
    [Description(@"Tax reclaim has been sent to the tax authorities.")]
    SentToTaxAuthorities,

    /// <summary>
    /// Financial instruments are delivered, but still awaiting money from counterparty.
    /// Encoded/decoded by serializers as &quot;AWMO&quot;.
    /// </summary>
    [EnumMember(Value = "AWMO")]
    [IsoId("b9971465-41d8-4b08-9a63-52c59508a9ac")]
    [Description(@"Financial instruments are delivered, but still awaiting money from counterparty.")]
    AwaitingMoney,

    /// <summary>
    /// Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("c066662c-2d7d-4da1-b0d9-0e2ce0bdd3bf")]
    [Description(
        @"Financial instruments have not yet been received from the counterparty (if receive against payment trade), the money has been delivered."
    )]
    AwaitingSecuritiesFromCounterparty,

    /// <summary>
    /// Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight.
    /// Encoded/decoded by serializers as &quot;BATC&quot;.
    /// </summary>
    [EnumMember(Value = "BATC")]
    [IsoId("22c2565b-d500-402b-a120-aacab1df3302")]
    [Description(
        @"Processing batch differs in the counterparty's instruction, for example, daytime/real-time versus overnight."
    )]
    ProcessingBatchDifference,

    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("ef5aea37-86c8-43fb-9434-072ddea278ca")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement,

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("09607107-25a7-404d-b604-bff1483a9c30")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked,

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("a79ef839-5430-46fe-94b7-7d804f5b6cda")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails,

    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("81e5abdc-f5ae-4e67-9526-6cd7fa41de89")]
    [Description(
        @"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode."
    )]
    BothInstructionsOnHold,

    /// <summary>
    /// Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery).
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("7b2392ef-c4e6-4db2-8b72-364580986a10")]
    [Description(
        @"Buy-in procedure has started on the market (on your behalf if your instruction is a receipt, by the counterparty if your instruction is a delivery)."
    )]
    BuyInProcedure,

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("e9500905-a640-4424-9d66-09319bcf80fd")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities,

    /// <summary>
    /// Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required.
    /// Encoded/decoded by serializers as &quot;CANR&quot;.
    /// </summary>
    [EnumMember(Value = "CANR")]
    [IsoId("af641d8c-fe20-455f-ad1c-a3c38c5b8177")]
    [Description(
        @"Instruction was in suspense. Suspense period is finished so your cancellation or confirmation of instruction is required."
    )]
    CancellationConfirmationRequested,

    /// <summary>
    /// Awaiting cancellation of one of the party.
    /// Encoded/decoded by serializers as &quot;CDAC&quot;.
    /// </summary>
    [EnumMember(Value = "CDAC")]
    [IsoId("d30061b0-5853-430d-95fd-d25d53d2d486")]
    [Description(@"Awaiting cancellation of one of the party.")]
    ConditionalDeliveryAwaitingCancellation,

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("7ea27af9-e78f-471f-b2b0-0cc33593aec0")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery.
    /// Encoded/decoded by serializers as &quot;CDEL&quot;.
    /// </summary>
    [EnumMember(Value = "CDEL")]
    [IsoId("b171008b-e4c6-4f61-ba29-629894989edb")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery."
    )]
    ConditionalDelivery,

    /// <summary>
    /// Conditional Delivery is still pending awaiting the cancellation from at least another party.
    /// Encoded/decoded by serializers as &quot;CDLC&quot;.
    /// </summary>
    [EnumMember(Value = "CDLC")]
    [IsoId("883f9739-3957-4d3e-884f-0a8d4db27020")]
    [Description(
        @"Conditional Delivery is still pending awaiting the cancellation from at least another party."
    )]
    ConditionalDeliveryCancellationPending,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as &quot;CDLR&quot;.
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("cce415a2-d66a-4e2c-b734-6a7bebc359fe")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release."
    )]
    ConditionalDeliveryAwaitingRelease,

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("245fd0e2-504d-4f6f-85ac-1023002baa0f")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement,

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("e0e6867e-033a-45c1-b708-ba78dd1e72a8")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar,

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("59b9db1a-88aa-49e8-898a-12d47e3dca8d")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers,

    /// <summary>
    /// A chaser/enquiry has been sent.
    /// Encoded/decoded by serializers as &quot;CHAS&quot;.
    /// </summary>
    [EnumMember(Value = "CHAS")]
    [IsoId("5c9af186-8ef2-49ca-b29f-7bc7d8c1c010")]
    [Description(@"A chaser/enquiry has been sent.")]
    EnquirySent,

    /// <summary>
    /// Client has been informed of a problem and is investigating.
    /// Encoded/decoded by serializers as &quot;CINV&quot;.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("4eaeea3a-1bdc-4a77-8229-fe05c1b82df1")]
    [Description(@"Client has been informed of a problem and is investigating.")]
    UnderClientInvestigation,

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("01fb97db-a986-4934-9661-424740318e85")]
    [Description(
        @"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments."
    )]
    CounterpartyInsufficientSecurities,

    /// <summary>
    /// Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late.
    /// Encoded/decoded by serializers as &quot;CLAT&quot;.
    /// </summary>
    [EnumMember(Value = "CLAT")]
    [IsoId("04ad0440-e132-4cf0-9ac5-3a37a0d97fec")]
    [Description(
        @"Counterparty's instruction was too late for settlement, that is the matching or settlement problems was solved too late."
    )]
    CounterpartyTooLateForSettlement,

    /// <summary>
    /// Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India.
    /// Encoded/decoded by serializers as &quot;CLHT&quot;.
    /// </summary>
    [EnumMember(Value = "CLHT")]
    [IsoId("d5ada305-8331-465f-9953-b276b10ff066")]
    [Description(
        @"Instructed settlement date does not agree with the settlement date on the clearing house trade, that is, a specific type of trade in India."
    )]
    ClearingHouseTrade,

    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("49c94ae6-ad59-4143-a65c-78aa4b874673")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney,

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("28de153a-eb62-4a2d-9519-9c7df9aa4c5c")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral,

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("dfcdbc24-fbab-4d19-af07-75453c19f764")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation,

    /// <summary>
    /// Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business).
    /// Encoded/decoded by serializers as &quot;CPEC&quot;.
    /// </summary>
    [EnumMember(Value = "CPEC")]
    [IsoId("80704206-abfb-44b2-ac0f-1298627a5f22")]
    [Description(
        @"Counterparty is in receivership (form of bankruptcy where a court appointed person - the receiver - manages the affairs of the business)."
    )]
    CounterpartyInReceivership,

    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("4603f80d-1cc3-4d6b-8307-21d70a313383")]
    [Description(
        @"Central securities depository sets the instruction in a hold/frozen/preadvice mode."
    )]
    CSDHold,

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("b89ad563-14aa-442c-a184-b018281bd55c")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
    )]
    CSDValidation,

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("1a376167-96b1-4b11-b602-ee6c5b0759d5")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle,

    /// <summary>
    /// Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty.
    /// Encoded/decoded by serializers as &quot;CYDV&quot;.
    /// </summary>
    [EnumMember(Value = "CYDV")]
    [IsoId("ade3814c-3ba3-4e0f-897e-e4e05c7f79d3")]
    [Description(
        @"Counterparty has not sent an instruction to deliver or delivered the shares. Check with counterparty."
    )]
    AwaitingCounterpartyDelivery,

    /// <summary>
    /// Counterparty has not sent an instruction to receive. Check with counterparty.
    /// Encoded/decoded by serializers as &quot;CYIN&quot;.
    /// </summary>
    [EnumMember(Value = "CYIN")]
    [IsoId("536f32de-b351-4682-969b-87aaf4dc9d54")]
    [Description(@"Counterparty has not sent an instruction to receive. Check with counterparty.")]
    AwaitingCounterpartyReceipt,

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("7adc98bb-7977-42e4-95ac-e532e742be3c")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity,

    /// <summary>
    /// Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("225a894d-96a6-45e6-a0af-280fd256ae7e")]
    [Description(
        @"Deposit of shares for the issuing of depositary receipts has been refused. The allotment granted by the issuer is exceeded by your transaction."
    )]
    RefusedDepositForIssueOfDepositaryReceipts,

    /// <summary>
    /// Exceptional closing of all financial institutions due to natural disaster, for example, earthquake.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("5ca599f9-26eb-40c5-ba62-7334c5aba4ed")]
    [Description(
        @"Exceptional closing of all financial institutions due to natural disaster, for example, earthquake."
    )]
    NaturalDisaster,

    /// <summary>
    /// Counterparty has returned or refuses the securities.
    /// Encoded/decoded by serializers as &quot;DKNY&quot;.
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("99d59b54-b4eb-4a45-afa8-93a141ed784d")]
    [Description(@"Counterparty has returned or refuses the securities.")]
    CounterpartyReturnedShares,

    /// <summary>
    /// Awaiting documents or endorsements from counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("7ccb4b19-74fd-4139-909c-3fbf4fab39c7")]
    [Description(@"Awaiting documents or endorsements from counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty,

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("dd32f1b7-ef31-471f-9d69-b11b6d39b77d")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou,

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("0bf24d70-73d3-4050-92df-eaad619614d5")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement,

    /// <summary>
    /// Documents are rejected by the transfer agent.
    /// Encoded/decoded by serializers as &quot;DRJC&quot;.
    /// </summary>
    [EnumMember(Value = "DRJC")]
    [IsoId("93491b48-49ce-4185-8d31-5c7aec6d4b0b")]
    [Description(@"Documents are rejected by the transfer agent.")]
    DocumentsRejected,

    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("5236e8ee-e2e1-4ef6-8559-74a9846458d4")]
    [Description(@"Special follow-up is taking place.")]
    Escalation,

    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("21bd6902-5232-4ade-b92a-c6c231563b76")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached,

    /// <summary>
    /// Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event.
    /// Encoded/decoded by serializers as &quot;FROZ&quot;.
    /// </summary>
    [EnumMember(Value = "FROZ")]
    [IsoId("85006f30-f961-4540-bdab-942af912078f")]
    [Description(
        @"Financial instruments are blocked at the Central Security Depository (CSD) following a corporate event."
    )]
    SecuritiesFrozenAtCSD,

    /// <summary>
    /// Awaiting settlement date. No settlement problems to be reported.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("6138057a-d759-4ad9-83c7-2130d167e389")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate,

    /// <summary>
    /// Confirmed but finality is to be verified.
    /// Encoded/decoded by serializers as &quot;FVER&quot;.
    /// </summary>
    [EnumMember(Value = "FVER")]
    [IsoId("b99117d0-085e-4b90-b87c-2236ed4a4dfe")]
    [Description(@"Confirmed but finality is to be verified.")]
    FinalVerification,

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("f6227cff-2b78-41b5-9678-b0d1d2ebe9c8")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities,

    /// <summary>
    /// Guaranteed delivery indicator differs in the counterparty's instruction.
    /// Encoded/decoded by serializers as &quot;GUAD&quot;.
    /// </summary>
    [EnumMember(Value = "GUAD")]
    [IsoId("7f8a3b32-9719-4ee9-bed4-eb1c76d846e1")]
    [Description(@"Guaranteed delivery indicator differs in the counterparty's instruction.")]
    GuaranteedDeliveryIndicatorDifference,

    /// <summary>
    /// Pending reason being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("218f5f3b-fdff-4039-8bf7-d1818e918e02")]
    [Description(@"Pending reason being investigated.")]
    StatusReasonInvestigation,

    /// <summary>
    /// Intermediary is investigating the reason why the transfer is pending.
    /// Encoded/decoded by serializers as &quot;IINV&quot;.
    /// </summary>
    [EnumMember(Value = "IINV")]
    [IsoId("05a4ffb7-82c7-45a9-8bc9-ef4b532aa07a")]
    [Description(@"Intermediary is investigating the reason why the transfer is pending.")]
    UnderInvestigation,

    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("54cd4787-d874-4038-92cd-508c78c52080")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount,

    /// <summary>
    /// Financial instruments require income adjustment, for example, dividend or interest.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("aa2c0fec-ed9c-4cca-abe0-a92c5c71035c")]
    [Description(
        @"Financial instruments require income adjustment, for example, dividend or interest."
    )]
    IncomeAdjustementRequired,

    /// <summary>
    /// Instruction has been processed and cannot be cancelled.
    /// Encoded/decoded by serializers as &quot;IPNC&quot;.
    /// </summary>
    [EnumMember(Value = "IPNC")]
    [IsoId("0888f085-4eec-4f3a-818a-6c6853734262")]
    [Description(@"Instruction has been processed and cannot be cancelled.")]
    CancelNotPossible,

    /// <summary>
    /// Awaiting settlement of a purchase to cover failing positions.
    /// Encoded/decoded by serializers as &quot;LAAW&quot;.
    /// </summary>
    [EnumMember(Value = "LAAW")]
    [IsoId("3d86bf95-70c2-44df-8eb2-3c6ebb035920")]
    [Description(@"Awaiting settlement of a purchase to cover failing positions.")]
    AwaitingOtherTransaction,

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("12ac1cf5-1872-4b79-b151-78717e2e2b9a")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities,

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("702676e3-7741-451d-aac6-f7e103c86b41")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut,

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("9ba13d4a-6501-499a-ae67-19b4604f9875")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("c85a3383-f131-46a6-a81d-5b36b54d6659")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction,

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("ef65ad35-c1df-4bfc-9739-aa869bb3eb76")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity,

    /// <summary>
    /// Longer processing timeframe for this type of transfer, due to documentation requirements.
    /// Encoded/decoded by serializers as &quot;LPRO&quot;.
    /// </summary>
    [EnumMember(Value = "LPRO")]
    [IsoId("6aa80767-d404-4144-8793-85e2119be82b")]
    [Description(
        @"Longer processing timeframe for this type of transfer, due to documentation requirements."
    )]
    LongerProcessing,

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("3b7c22af-b7c4-47a5-a3c4-0f257cbcd167")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification,

    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as &quot;MINF&quot;.
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("40b30b35-4d80-4b64-88a2-718a3d3d4f9a")]
    [Description(@"Information, for example, telephone number, contact person, is missing.")]
    MissingInformation,

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("6070ae61-833c-4ff8-857e-f3de7a430bed")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount,

    /// <summary>
    /// Covering money/financial instruments were received too late for completing settlement on a same day basis.
    /// Encoded/decoded by serializers as &quot;MLAT&quot;.
    /// </summary>
    [EnumMember(Value = "MLAT")]
    [IsoId("a561c0c2-abca-42ea-9af9-2a2b4d83950b")]
    [Description(
        @"Covering money/financial instruments were received too late for completing settlement on a same day basis."
    )]
    MoneySecuritiesTooLateForSettlement,

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("0dd311e7-3b52-42c5-ab8c-fbc77e174145")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney,

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("23cd28dc-dcb2-4de4-a9bb-972139360e81")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount,

    /// <summary>
    /// Confirmation of settlement has not yet been received.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("ca0be480-0a8a-4a17-b78a-f067e9f80ee3")]
    [Description(@"Confirmation of settlement has not yet been received.")]
    ConfirmationNotReceived,

    /// <summary>
    /// Financial instrument is a new issue and not yet available/tradable.
    /// Encoded/decoded by serializers as &quot;NEWI&quot;.
    /// </summary>
    [EnumMember(Value = "NEWI")]
    [IsoId("cc3560a7-2a43-42b1-bcd4-976aece54aa8")]
    [Description(@"Financial instrument is a new issue and not yet available/tradable.")]
    NewIssues,

    /// <summary>
    /// Next process is launched. No processing pending problems to be reported.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("29f4b232-f874-4fca-92bd-a62de5eb89db")]
    [Description(@"Next process is launched. No processing pending problems to be reported.")]
    NextProcess,

    /// <summary>
    /// Instruction has not been matched; matching process is not required.
    /// Encoded/decoded by serializers as &quot;NMAS&quot;.
    /// </summary>
    [EnumMember(Value = "NMAS")]
    [IsoId("e73192f6-74f1-406f-9181-5e16ed8c13ad")]
    [Description(@"Instruction has not been matched; matching process is not required.")]
    NoMatchingRequired,

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("2588574e-91b1-4287-b41b-5dfc3fd781f1")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction,

    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as &quot;NPAY&quot;.
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("9ac5dd67-c2eb-4baa-871c-79346282a407")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment,

    /// <summary>
    /// Transfer agent claims non-receipt of physical shares.
    /// Encoded/decoded by serializers as &quot;NRCP&quot;.
    /// </summary>
    [EnumMember(Value = "NRCP")]
    [IsoId("c19f067b-1526-491c-8048-b39c7c3a6d76")]
    [Description(@"Transfer agent claims non-receipt of physical shares.")]
    TransferAgentNonReceipt,

    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as &quot;NSEC&quot;.
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("e5d0d983-8a23-4c38-a3c5-e01035cfbf66")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered,

    /// <summary>
    /// Financial instruments are, for example, stolen, in dispute, under objection.
    /// Encoded/decoded by serializers as &quot;OBJT&quot;.
    /// </summary>
    [EnumMember(Value = "OBJT")]
    [IsoId("d98c8914-bcfd-418c-985d-acce6a231b84")]
    [Description(@"Financial instruments are, for example, stolen, in dispute, under objection.")]
    UnderObjection,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("8efc3458-5de5-4520-b7db-de388c1ed79f")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// The instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("76576fc3-5c0d-46fb-ad0f-97e206fd4727")]
    [Description(@"The instructed position exceeds the eligible balance.")]
    NormalProcessingPeriodLapsed,

    /// <summary>
    /// Trade will settle in partials.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("05a45b97-afbf-4237-a69b-038137d6dc3b")]
    [Description(@"Trade will settle in partials.")]
    TradeSettlesInPartials,

    /// <summary>
    /// Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement.
    /// Encoded/decoded by serializers as &quot;PCAP&quot;.
    /// </summary>
    [EnumMember(Value = "PCAP")]
    [IsoId("18ea1d6d-8c87-47ed-b766-dfb876907dd5")]
    [Description(
        @"Payment is pending, and does not settle because the actual use of the risk management limit on the counterpart (bilateral limit) prevents settlement."
    )]
    PendingCAP,

    /// <summary>
    /// Prior payment credited to account based contractual income collection agreement has been collected from issuer.
    /// Encoded/decoded by serializers as &quot;PCNF&quot;.
    /// </summary>
    [EnumMember(Value = "PCNF")]
    [IsoId("b98f90ee-1f98-4444-86e8-0d3ab6cde0c9")]
    [Description(
        @"Prior payment credited to account based contractual income collection agreement has been collected from issuer."
    )]
    ConfirmationOfPayment,

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("c88da8bf-5c10-41aa-8ba1-629f67f4d6b1")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase, loan etc."
    )]
    PendingReceipt,

    /// <summary>
    /// Physical financial instruments have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("d5e96a11-ef98-4aaf-a723-d39fa5fc57da")]
    [Description(
        @"Physical financial instruments have been received and are being checked for authenticity."
    )]
    PhysicalSecuritiesVerification,

    /// <summary>
    /// Settlement is physical. Financial instruments are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("5265b8f6-bc31-4035-b584-92af0390c1b9")]
    [Description(@"Settlement is physical. Financial instruments are being delivered.")]
    PhysicalDeliveryDelay,

    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("3e7c4b47-f838-41ad-aad5-c06a8c4718e7")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold,

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("cc5547fd-b1cb-4d1c-956e-5a9e208d56ef")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold,

    /// <summary>
    /// Transaction was put on hold/frozen by the system.
    /// Encoded/decoded by serializers as &quot;PRSY&quot;.
    /// </summary>
    [EnumMember(Value = "PRSY")]
    [IsoId("f4366eb1-ee3e-4a19-b178-d05c49072da5")]
    [Description(@"Transaction was put on hold/frozen by the system.")]
    SystemOnHold,

    /// <summary>
    /// Delivery/receipt was refused because physical financial instruments are not in good order.
    /// Encoded/decoded by serializers as &quot;REFS&quot;.
    /// </summary>
    [EnumMember(Value = "REFS")]
    [IsoId("f07884f1-2e88-4678-b5ae-5806a4e4f12e")]
    [Description(
        @"Delivery/receipt was refused because physical financial instruments are not in good order."
    )]
    NotInGoodOrder,

    /// <summary>
    /// Instruction has been refused or not recognised and is represented automatically.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("0334f14b-9d3f-4555-8554-8691dee53c28")]
    [Description(
        @"Instruction has been refused or not recognised and is represented automatically."
    )]
    InstructionRefusedOrNotRecognised,

    /// <summary>
    /// Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached.
    /// Encoded/decoded by serializers as &quot;REGT&quot;.
    /// </summary>
    [EnumMember(Value = "REGT")]
    [IsoId("3d3f7121-ebe1-438d-b0d7-54cdfaa45ad0")]
    [Description(
        @"Certificates have been lodged with the registrar but rejected due to incomplete documentation or foreign ownership limitation reached."
    )]
    CertificatesRejected,

    /// <summary>
    /// Financial instruments are blocked due to, for example, a corporate action event, realignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("a419328d-51b6-4a9f-b3e7-65c6e573bcab")]
    [Description(
        @"Financial instruments are blocked due to, for example, a corporate action event, realignment."
    )]
    SecuritiesBlocked,

    /// <summary>
    /// Stamp duty information is missing.
    /// Encoded/decoded by serializers as &quot;SDUT&quot;.
    /// </summary>
    [EnumMember(Value = "SDUT")]
    [IsoId("1384b381-69ff-4443-bc50-05e2a8216dd6")]
    [Description(@"Stamp duty information is missing.")]
    LackOfStampDutyInformation,

    /// <summary>
    /// Settlement system/method has been modified at central securities depository to allow settlement.
    /// Encoded/decoded by serializers as &quot;SETS&quot;.
    /// </summary>
    [EnumMember(Value = "SETS")]
    [IsoId("494561ce-ced8-47a0-a04c-ff68f96db04d")]
    [Description(
        @"Settlement system/method has been modified at central securities depository to allow settlement."
    )]
    SettlementSystemMethodModified,

    /// <summary>
    /// Discrepancy in the settlement confirmation.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("2f126a08-4358-4f9a-b1d0-5dc054f267d0")]
    [Description(@"Discrepancy in the settlement confirmation.")]
    ConfirmationDiscrepency,

    /// <summary>
    /// Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent.
    /// Encoded/decoded by serializers as &quot;STST&quot;.
    /// </summary>
    [EnumMember(Value = "STST")]
    [IsoId("d8cb6127-f60d-418d-9123-96f05d512757")]
    [Description(
        @"Stock transfer form has been sent to the counterparty to sign and forward to the transfer agent."
    )]
    StockTransferFormSent,

    /// <summary>
    /// Trade is being amended in the market.
    /// Encoded/decoded by serializers as &quot;TAMM&quot;.
    /// </summary>
    [EnumMember(Value = "TAMM")]
    [IsoId("2e33e1af-d273-48c5-8ea0-068ca073d4e3")]
    [Description(@"Trade is being amended in the market.")]
    TradeAmendedInMarket,

    /// <summary>
    /// Transfer is being processed by transfer agent.
    /// Encoded/decoded by serializers as &quot;TAPR&quot;.
    /// </summary>
    [EnumMember(Value = "TAPR")]
    [IsoId("1f54516a-e029-4e7c-9fe3-c05ce3a77c0d")]
    [Description(@"Transfer is being processed by transfer agent.")]
    TransferAgentProcessing,

    /// <summary>
    /// Usual transfer agent's processing timeframe.
    /// Encoded/decoded by serializers as &quot;USUA&quot;.
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("a4cc0c54-050d-48da-8d37-8e69fdc84ecd")]
    [Description(@"Usual transfer agent's processing timeframe.")]
    UsualTransactionTime,

    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;VLDA&quot;.
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("d33192a1-e751-444e-ba9f-d4ad932deac3")]
    [Description(
        @"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities."
    )]
    ValidForTaxAuthorities,

    /// <summary>
    /// Wrong counterparty account details.
    /// Encoded/decoded by serializers as &quot;WCPA&quot;.
    /// </summary>
    [EnumMember(Value = "WCPA")]
    [IsoId("e5c7dd01-53a8-451d-8209-be643c8dc1cb")]
    [Description(@"Wrong counterparty account details.")]
    WrongCounterpartyAccount,

    /// <summary>
    /// Transfer is being processed by the transfer agent, awaiting status from transfer agent.
    /// Encoded/decoded by serializers as &quot;WTRF&quot;.
    /// </summary>
    [EnumMember(Value = "WTRF")]
    [IsoId("26b4d8c1-4c58-4cec-b991-a1b0d5f55572")]
    [Description(
        @"Transfer is being processed by the transfer agent, awaiting status from transfer agent."
    )]
    AwaitingTransferAgentStatus,

    /// <summary>
    /// Confirmation is expected from transfer agent.
    /// Encoded/decoded by serializers as &quot;XCNF&quot;.
    /// </summary>
    [EnumMember(Value = "XCNF")]
    [IsoId("4e37d519-5a5b-49cb-8401-caf01aecb949")]
    [Description(@"Confirmation is expected from transfer agent.")]
    ExpectedConfirmation,

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("0315df31-3f55-4a5e-af75-719778c645e2")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage,
}
