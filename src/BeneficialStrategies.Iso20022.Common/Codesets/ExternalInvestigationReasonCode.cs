// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation reason, as published in an external investigation reason code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_2lb_8ElBEe2sNe7Wx9q_CQ")]
[Description(@"Specifies the investigation reason, as published in an external investigation reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationReasonCode>))]
public readonly struct ExternalInvestigationReasonCode : IIsoExternalCode, IEquatable<ExternalInvestigationReasonCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationReasonCode"/>.</summary>
    public static implicit operator ExternalInvestigationReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReasonCode a, ExternalInvestigationReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReasonCode a, ExternalInvestigationReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationReasonCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation relating to an account.</summary>
    [IsoId("__-hUEdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to an account.")]
    public static readonly ExternalInvestigationReasonCode AccountRelatedInvestigation = new("ACCT");

    /// <summary>Request message relates to anti-money laundering.</summary>
    [IsoId("__-YKZ9YUEe68t8Cw380-tA")]
    [Description(@"Request message relates to anti-money laundering.")]
    public static readonly ExternalInvestigationReasonCode AntiMoneyLaundering = new("AMLI");

    /// <summary>An amount element has triggered the investigation.</summary>
    [IsoId("__-YKStYUEe68t8Cw380-tA")]
    [Description(@"An amount element has triggered the investigation.")]
    public static readonly ExternalInvestigationReasonCode Amount = new("AMNT");

    /// <summary>Payment type category purpose is incorrect, incomplete or missing.</summary>
    [IsoId("__-YKRtYUEe68t8Cw380-tA")]
    [Description(@"Payment type category purpose is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode CategoryPurpose = new("CAPU");

    /// <summary>Creditor claims non-receipt of payment.</summary>
    [IsoId("__-YKctYUEe68t8Cw380-tA")]
    [Description(@"Creditor claims non-receipt of payment.")]
    public static readonly ExternalInvestigationReasonCode CreditorClaimNonReceipt = new("CCNR");

    /// <summary>Further information pertaining to the charge bearer is requested.</summary>
    [IsoId("__-YKVtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charge bearer is requested.")]
    public static readonly ExternalInvestigationReasonCode ChargeBearer = new("CHBE");

    /// <summary>Copy of cheque is requested.</summary>
    [IsoId("__-YKZdYUEe68t8Cw380-tA")]
    [Description(@"Copy of cheque is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestChequeCopy = new("CHCO");

    /// <summary>Further information pertaining to the charges information is requested.</summary>
    [IsoId("__-YKW9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charges information is requested.")]
    public static readonly ExternalInvestigationReasonCode ChargesInformation = new("CHIN");

    /// <summary>Cheque not yet paid despite being sent to agent.</summary>
    [IsoId("__-YKbtYUEe68t8Cw380-tA")]
    [Description(@"Cheque not yet paid despite being sent to agent.")]
    public static readonly ExternalInvestigationReasonCode ChequeNotYetPaid = new("CHNP");

    /// <summary>Creditor agent claims non-receipt of cover or settlement.</summary>
    [IsoId("__-YKc9YUEe68t8Cw380-tA")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    public static readonly ExternalInvestigationReasonCode CreditorAgentClaimCoverNonReceipt = new("CONR");

    /// <summary>Further information pertaining to the creditor agent is requested.</summary>
    [IsoId("__-YKUtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor agent is requested.")]
    public static readonly ExternalInvestigationReasonCode CreditorAgent = new("CTAG");

    /// <summary>Further information pertaining to the creditor is requested.</summary>
    [IsoId("__-YKU9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor is requested.")]
    public static readonly ExternalInvestigationReasonCode Creditor = new("CTOR");

    /// <summary>Copy of draft is requested.</summary>
    [IsoId("__-YKZtYUEe68t8Cw380-tA")]
    [Description(@"Copy of draft is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestDraftCopy = new("DRCO");

    /// <summary>Further information pertaining to the debtor agent is requested.</summary>
    [IsoId("__-YKTNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor agent is requested.")]
    public static readonly ExternalInvestigationReasonCode DebtorAgent = new("DTAG");

    /// <summary>Further information pertaining to the debtor is requested.</summary>
    [IsoId("__-YKS9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor is requested.")]
    public static readonly ExternalInvestigationReasonCode Debtor = new("DTOR");

    /// <summary>Investigation relates to financial crimes compliance.</summary>
    [IsoId("__-YKY9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    public static readonly ExternalInvestigationReasonCode FinancialCrimeCompliance = new("FCCI");

    /// <summary>Instrument is confirmed as fraudulent.</summary>
    [IsoId("__-YKYtYUEe68t8Cw380-tA")]
    [Description(@"Instrument is confirmed as fraudulent.")]
    public static readonly ExternalInvestigationReasonCode FraudulentInstrument = new("FRAD");

    /// <summary>Investigation relates to funds transfer regulation or wire transfer regulation.</summary>
    [IsoId("__-YKZNYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds transfer regulation or wire transfer regulation.")]
    public static readonly ExternalInvestigationReasonCode FundsTransferRegulationOrWireTransferRegulation = new("FWTR");

    /// <summary>Incorrect accrued interest balance.</summary>
    [IsoId("_U3OMcfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect accrued interest balance.")]
    public static readonly ExternalInvestigationReasonCode IncorrectAccruedInterest = new("IAIB");

    /// <summary>Incorrect daily accrued interest amount.</summary>
    [IsoId("_U3OzgPXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect daily accrued interest amount.")]
    public static readonly ExternalInvestigationReasonCode IncorrectDailyAccruedInterest = new("IDAI");

    /// <summary>Further information pertaining to the instructed reimbursement agent is requested.</summary>
    [IsoId("__-YKTtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructed reimbursement agent is requested.")]
    public static readonly ExternalInvestigationReasonCode InstructedReimbursementAgent = new("IDRA");

    /// <summary>Further information pertaining to the instructing reimbursement agent is requested.</summary>
    [IsoId("__-YKTdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructing reimbursement agent is requested.")]
    public static readonly ExternalInvestigationReasonCode InstructingReimbursementAgent = new("IGRA");

    /// <summary>Invalid interest rate.</summary>
    [IsoId("_U3NlYPXXEe-Ig-GynGPh9A")]
    [Description(@"Invalid interest rate.")]
    public static readonly ExternalInvestigationReasonCode InvalidInterestRateType = new("IIRT");

    /// <summary>Further information pertaining to an intermediary agent is requested.</summary>
    [IsoId("__-YKUNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to an intermediary agent is requested.")]
    public static readonly ExternalInvestigationReasonCode IntermediaryAgent = new("INAG");

    /// <summary>Further information pertaining to the instruction for creditor agent is requested.</summary>
    [IsoId("__-YKWNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for creditor agent is requested.")]
    public static readonly ExternalInvestigationReasonCode InstructionForCreditorAgent = new("INCA");

    /// <summary>Incorrect closing balance.</summary>
    [IsoId("_U3OMcPXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect closing balance.")]
    public static readonly ExternalInvestigationReasonCode IncorrectClosingBalance = new("INCB");

    /// <summary>Further information pertaining to the instruction for next agent is requested.</summary>
    [IsoId("__-YKV9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for next agent is requested.")]
    public static readonly ExternalInvestigationReasonCode InstructionForNextAgent = new("INNA");

    /// <summary>Further information pertaining to the initiating party is requested.</summary>
    [IsoId("__-YKX9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the initiating party is requested.")]
    public static readonly ExternalInvestigationReasonCode InitiatingParty = new("INPA");

    /// <summary>Incorrect transaction amount.</summary>
    [IsoId("_U3OzgfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect transaction amount.")]
    public static readonly ExternalInvestigationReasonCode IncorrectTransactionAmount = new("INTA");

    /// <summary>Interbank settlement amount is incorrect.</summary>
    [IsoId("__-YKSdYUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement amount is incorrect.")]
    public static readonly ExternalInvestigationReasonCode InterbankSettlementAmount = new("ISAM");

    /// <summary>Interbank settlement date is incorrect.</summary>
    [IsoId("__-YKSNYUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement date is incorrect.")]
    public static readonly ExternalInvestigationReasonCode InterbankSettlementDate = new("ISDT");

    /// <summary>Missing credit amount on statement.</summary>
    [IsoId("_U3M-UPXXEe-Ig-GynGPh9A")]
    [Description(@"Missing credit amount on statement.")]
    public static readonly ExternalInvestigationReasonCode MissingCreditAmount = new("MCAT");

    /// <summary>Missing debit amount on statement.</summary>
    [IsoId("_U3M-UfXXEe-Ig-GynGPh9A")]
    [Description(@"Missing debit amount on statement.")]
    public static readonly ExternalInvestigationReasonCode MissingDebitAmount = new("MDAT");

    /// <summary>See AdditionalRequestData element for additional information</summary>
    [IsoId("__-YKb9YUEe68t8Cw380-tA")]
    [Description(@"See AdditionalRequestData element for additional information")]
    public static readonly ExternalInvestigationReasonCode Narrative = new("NARR");

    /// <summary>Payment initiation has not been settled or confirmed.</summary>
    [IsoId("__-YKdNYUEe68t8Cw380-tA")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    public static readonly ExternalInvestigationReasonCode PaymentInitiationNotConfirmed = new("PINC");

    /// <summary>Further information pertaining to the purpose is requested.</summary>
    [IsoId("__-YKXtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the purpose is requested.")]
    public static readonly ExternalInvestigationReasonCode Purpose = new("PURP");

    /// <summary>Payment type clearing channel is incorrect, incomplete or missing.</summary>
    [IsoId("__-YKUdYUEe68t8Cw380-tA")]
    [Description(@"Payment type clearing channel is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode PaymentClearingChannel = new("PYCC");

    /// <summary>Transaction payment purpose is incorrect, incomplete or missing.</summary>
    [IsoId("__-YKVdYUEe68t8Cw380-tA")]
    [Description(@"Transaction payment purpose is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode PaymentPurpose = new("PYPU");

    /// <summary>Requested execution date is incorrect or missing.</summary>
    [IsoId("__-YKR9YUEe68t8Cw380-tA")]
    [Description(@"Requested execution date is incorrect or missing.")]
    public static readonly ExternalInvestigationReasonCode RequestedExecutionDate = new("REDT");

    /// <summary>Regulatory reporting is incomplete or missing.</summary>
    [IsoId("__-YKYNYUEe68t8Cw380-tA")]
    [Description(@"Regulatory reporting is incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode RegulatoryReporting = new("REGR");

    /// <summary>Remittance information is incorrect, incomplete or missing.</summary>
    [IsoId("__-YKVNYUEe68t8Cw380-tA")]
    [Description(@"Remittance information is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode RemittanceInformation = new("REIN");

    /// <summary>Related transaction reference is incorrect, incomplete or missing.</summary>
    [IsoId("__-YKRNYUEe68t8Cw380-tA")]
    [Description(@"Related transaction reference is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode RelatedReference = new("RERE");

    /// <summary>Request from International Monetary Fund.</summary>
    [IsoId("__-hUE9YUEe68t8Cw380-tA")]
    [Description(@"Request from International Monetary Fund.")]
    public static readonly ExternalInvestigationReasonCode RequestFromIMF = new("RIMF");

    /// <summary>Account closure date is requested.</summary>
    [IsoId("__-YKcNYUEe68t8Cw380-tA")]
    [Description(@"Account closure date is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestAccountClosureDate = new("RQCD");

    /// <summary>Investigation relating to charges that have been taken or are unpaid.</summary>
    [IsoId("__-hUEtYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to charges that have been taken or are unpaid.")]
    public static readonly ExternalInvestigationReasonCode RequestRelatedToCharges = new("RQCH");

    /// <summary>Debit authorisation on an entry is requested.</summary>
    [IsoId("__-hUENYUEe68t8Cw380-tA")]
    [Description(@"Debit authorisation on an entry is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestDebitAuthorisation = new("RQDA");

    /// <summary>Documentation relating to the transaction is requested.</summary>
    [IsoId("__-YKbdYUEe68t8Cw380-tA")]
    [Description(@"Documentation relating to the transaction is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestDocumentation = new("RQDO");

    /// <summary>Clarification over when goods or services were exchanged is requested.</summary>
    [IsoId("__-YKbNYUEe68t8Cw380-tA")]
    [Description(@"Clarification over when goods or services were exchanged is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestServicesOrGoodsExchangeDate = new("RQED");

    /// <summary>Clarification over location details is requested.</summary>
    [IsoId("__-YKatYUEe68t8Cw380-tA")]
    [Description(@"Clarification over location details is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestLocationDetails = new("RQLD");

    /// <summary>Clarification over a party relationship is requested.</summary>
    [IsoId("__-YKaNYUEe68t8Cw380-tA")]
    [Description(@"Clarification over a party relationship is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestPartyRelationship = new("RQPR");

    /// <summary>Clarification over goods or services involved is requested.</summary>
    [IsoId("__-YKa9YUEe68t8Cw380-tA")]
    [Description(@"Clarification over goods or services involved is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestServicesOrGoodsDetails = new("RQSG");

    /// <summary>Use of funds on an entry is requested.</summary>
    [IsoId("__-YKdtYUEe68t8Cw380-tA")]
    [Description(@"Use of funds on an entry is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestUseOfFunds = new("RQUF");

    /// <summary>Revaluation of an entry is requested.</summary>
    [IsoId("__-YKddYUEe68t8Cw380-tA")]
    [Description(@"Revaluation of an entry is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestValueDateAdjustment = new("RQVA");

    /// <summary>Clarification over a vessel or aircraft is requested.</summary>
    [IsoId("__-YKadYUEe68t8Cw380-tA")]
    [Description(@"Clarification over a vessel or aircraft is requested.")]
    public static readonly ExternalInvestigationReasonCode RequestVesselOrAircraftDetails = new("RQVD");

    /// <summary>Further information pertaining to the settlement account is requested.</summary>
    [IsoId("__-YKWtYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the settlement account is requested.")]
    public static readonly ExternalInvestigationReasonCode SettlementAccount = new("SEAC");

    /// <summary>Further information pertaining to a statement entry is requested.</summary>
    [IsoId("__-YKWdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to a statement entry is requested.")]
    public static readonly ExternalInvestigationReasonCode StatementEntry = new("STET");

    /// <summary>Payment type service level is incorrect, incomplete or missing.</summary>
    [IsoId("__-YKRdYUEe68t8Cw380-tA")]
    [Description(@"Payment type service level is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode PaymentServiceLevel = new("SVLV");

    /// <summary>Tax data is incomplete or missing.</summary>
    [IsoId("__-YKYdYUEe68t8Cw380-tA")]
    [Description(@"Tax data is incomplete or missing.")]
    public static readonly ExternalInvestigationReasonCode Tax = new("TAXD");

    /// <summary>Further information pertaining to the third reimbursement agent is requested.</summary>
    [IsoId("__-YKT9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the third reimbursement agent is requested.")]
    public static readonly ExternalInvestigationReasonCode ThirdReimbursementAgent = new("TDRA");

    /// <summary>Further information pertaining to the ultimate creditor is requested.</summary>
    [IsoId("__-YKXdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate creditor is requested.")]
    public static readonly ExternalInvestigationReasonCode UltimateCreditor = new("ULTC");

    /// <summary>Further information pertaining to the ultimate debtor is requested.</summary>
    [IsoId("__-YKXNYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate debtor is requested.")]
    public static readonly ExternalInvestigationReasonCode UltimateDebtor = new("ULTD");

    /// <summary>A booked entry cannot be applied by the creditor.</summary>
    [IsoId("__-YKcdYUEe68t8Cw380-tA")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    public static readonly ExternalInvestigationReasonCode UnableToApplyByCreditor = new("UTAP");
}
