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
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_7kAjkFEUEe2YkcF60skG_A")]
[Description(@"Specifies the investigation reason, as published in an external investigation reason code set.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationReason1Code>))]
public readonly struct ExternalInvestigationReason1Code : IIsoExternalCode, IEquatable<ExternalInvestigationReason1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationReason1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationReason1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationReason1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationReason1Code"/>.</summary>
    public static implicit operator ExternalInvestigationReason1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationReason1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationReason1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationReason1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReason1Code a, ExternalInvestigationReason1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReason1Code a, ExternalInvestigationReason1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReason1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReason1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationReason1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationReason1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation relating to an account.</summary>
    [IsoId("___asGdYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to an account.")]
    public static readonly ExternalInvestigationReason1Code AccountRelatedInvestigation = new("ACCT");

    /// <summary>Request message relates to anti-money laundering.</summary>
    [IsoId("___ar99YUEe68t8Cw380-tA")]
    [Description(@"Request message relates to anti-money laundering.")]
    public static readonly ExternalInvestigationReason1Code AntiMoneyLaundering = new("AMLI");

    /// <summary>An amount element has triggered the investigation.</summary>
    [IsoId("___Q7R9YUEe68t8Cw380-tA")]
    [Description(@"An amount element has triggered the investigation.")]
    public static readonly ExternalInvestigationReason1Code Amount = new("AMNT");

    /// <summary>Payment type category purpose is incorrect, incomplete or missing.</summary>
    [IsoId("___Q7P9YUEe68t8Cw380-tA")]
    [Description(@"Payment type category purpose is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code CategoryPurpose = new("CAPU");

    /// <summary>Creditor claims non-receipt of payment.</summary>
    [IsoId("___asDdYUEe68t8Cw380-tA")]
    [Description(@"Creditor claims non-receipt of payment.")]
    public static readonly ExternalInvestigationReason1Code CreditorClaimNonReceipt = new("CCNR");

    /// <summary>Further information pertaining to the charge bearer is requested.</summary>
    [IsoId("___Q7X9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charge bearer is requested.")]
    public static readonly ExternalInvestigationReason1Code ChargeBearer = new("CHBE");

    /// <summary>Copy of cheque is requested.</summary>
    [IsoId("___ar89YUEe68t8Cw380-tA")]
    [Description(@"Copy of cheque is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestChequeCopy = new("CHCO");

    /// <summary>Further information pertaining to the charges information is requested.</summary>
    [IsoId("___Q7adYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the charges information is requested.")]
    public static readonly ExternalInvestigationReason1Code ChargesInformation = new("CHIN");

    /// <summary>Cheque not yet paid despite being sent to agent.</summary>
    [IsoId("___asBdYUEe68t8Cw380-tA")]
    [Description(@"Cheque not yet paid despite being sent to agent.")]
    public static readonly ExternalInvestigationReason1Code ChequeNotYetPaid = new("CHNP");

    /// <summary>Creditor agent claims non-receipt of cover or settlement.</summary>
    [IsoId("___asD9YUEe68t8Cw380-tA")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    public static readonly ExternalInvestigationReason1Code CreditorAgentClaimCoverNonReceipt = new("CONR");

    /// <summary>Further information pertaining to the creditor agent is requested.</summary>
    [IsoId("___Q7V9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor agent is requested.")]
    public static readonly ExternalInvestigationReason1Code CreditorAgent = new("CTAG");

    /// <summary>Further information pertaining to the creditor is requested.</summary>
    [IsoId("___Q7WdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the creditor is requested.")]
    public static readonly ExternalInvestigationReason1Code Creditor = new("CTOR");

    /// <summary>Copy of draft is requested.</summary>
    [IsoId("___ar9dYUEe68t8Cw380-tA")]
    [Description(@"Copy of draft is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestDraftCopy = new("DRCO");

    /// <summary>Further information pertaining to the debtor agent is requested.</summary>
    [IsoId("___Q7S9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor agent is requested.")]
    public static readonly ExternalInvestigationReason1Code DebtorAgent = new("DTAG");

    /// <summary>Further information pertaining to the debtor is requested.</summary>
    [IsoId("___Q7SdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the debtor is requested.")]
    public static readonly ExternalInvestigationReason1Code Debtor = new("DTOR");

    /// <summary>Investigation relates to financial crimes compliance.</summary>
    [IsoId("___Q7edYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to financial crimes compliance.")]
    public static readonly ExternalInvestigationReason1Code FinancialCrimeCompliance = new("FCCI");

    /// <summary>Instrument is confirmed as fraudulent.</summary>
    [IsoId("___Q7d9YUEe68t8Cw380-tA")]
    [Description(@"Instrument is confirmed as fraudulent.")]
    public static readonly ExternalInvestigationReason1Code FraudulentInstrument = new("FRAD");

    /// <summary>Investigation relates to funds transfer regulation or wire transfer regulation.</summary>
    [IsoId("___ar8dYUEe68t8Cw380-tA")]
    [Description(@"Investigation relates to funds transfer regulation or wire transfer regulation.")]
    public static readonly ExternalInvestigationReason1Code FundsTransferRegulationOrWireTransferRegulation = new("FWTR");

    /// <summary>Incorrect accrued interest balance.</summary>
    [IsoId("_U4afQ_XXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect accrued interest balance.")]
    public static readonly ExternalInvestigationReason1Code IncorrectAccruedInterest = new("IAIB");

    /// <summary>Incorrect daily accrued interest amount.</summary>
    [IsoId("_U4afRfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect daily accrued interest amount.")]
    public static readonly ExternalInvestigationReason1Code IncorrectDailyAccruedInterest = new("IDAI");

    /// <summary>Further information pertaining to the instructed reimbursement agent is requested.</summary>
    [IsoId("___Q7T9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructed reimbursement agent is requested.")]
    public static readonly ExternalInvestigationReason1Code InstructedReimbursementAgent = new("IDRA");

    /// <summary>Further information pertaining to the instructing reimbursement agent is requested.</summary>
    [IsoId("___Q7TdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instructing reimbursement agent is requested.")]
    public static readonly ExternalInvestigationReason1Code InstructingReimbursementAgent = new("IGRA");

    /// <summary>Invalid interest rate.</summary>
    [IsoId("_U4Z4NfXXEe-Ig-GynGPh9A")]
    [Description(@"Invalid interest rate.")]
    public static readonly ExternalInvestigationReason1Code InvalidInterestRateType = new("IIRT");

    /// <summary>Further information pertaining to an intermediary agent is requested.</summary>
    [IsoId("___Q7U9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to an intermediary agent is requested.")]
    public static readonly ExternalInvestigationReason1Code IntermediaryAgent = new("INAG");

    /// <summary>Further information pertaining to the instruction for creditor agent is requested.</summary>
    [IsoId("___Q7Y9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for creditor agent is requested.")]
    public static readonly ExternalInvestigationReason1Code InstructionForCreditorAgent = new("INCA");

    /// <summary>Incorrect closing balance.</summary>
    [IsoId("_U4afQfXXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect closing balance.")]
    public static readonly ExternalInvestigationReason1Code IncorrectClosingBalance = new("INCB");

    /// <summary>Further information pertaining to the instruction for next agent is requested.</summary>
    [IsoId("___Q7YdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the instruction for next agent is requested.")]
    public static readonly ExternalInvestigationReason1Code InstructionForNextAgent = new("INNA");

    /// <summary>Further information pertaining to the initiating party is requested.</summary>
    [IsoId("___Q7cdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the initiating party is requested.")]
    public static readonly ExternalInvestigationReason1Code InitiatingParty = new("INPA");

    /// <summary>Incorrect transaction amount.</summary>
    [IsoId("_U4afR_XXEe-Ig-GynGPh9A")]
    [Description(@"Incorrect transaction amount.")]
    public static readonly ExternalInvestigationReason1Code IncorrectTransactionAmount = new("INTA");

    /// <summary>Interbank settlement amount is incorrect.</summary>
    [IsoId("___Q7RdYUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement amount is incorrect.")]
    public static readonly ExternalInvestigationReason1Code InterbankSettlementAmount = new("ISAM");

    /// <summary>Interbank settlement date is incorrect.</summary>
    [IsoId("___Q7Q9YUEe68t8Cw380-tA")]
    [Description(@"Interbank settlement date is incorrect.")]
    public static readonly ExternalInvestigationReason1Code InterbankSettlementDate = new("ISDT");

    /// <summary>Missing credit amount on statement.</summary>
    [IsoId("_U4Z4MfXXEe-Ig-GynGPh9A")]
    [Description(@"Missing credit amount on statement.")]
    public static readonly ExternalInvestigationReason1Code MissingCreditAmount = new("MCAT");

    /// <summary>Missing debit amount on statement.</summary>
    [IsoId("_U4Z4M_XXEe-Ig-GynGPh9A")]
    [Description(@"Missing debit amount on statement.")]
    public static readonly ExternalInvestigationReason1Code MissingDebitAmount = new("MDAT");

    /// <summary>See AdditionalRequestData element for additional information</summary>
    [IsoId("___asB9YUEe68t8Cw380-tA")]
    [Description(@"See AdditionalRequestData element for additional information")]
    public static readonly ExternalInvestigationReason1Code Narrative = new("NARR");

    /// <summary>Payment initiation has not been settled or confirmed.</summary>
    [IsoId("___asEdYUEe68t8Cw380-tA")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    public static readonly ExternalInvestigationReason1Code PaymentInitiationNotConfirmed = new("PINC");

    /// <summary>Further information pertaining to the purpose is requested.</summary>
    [IsoId("___Q7b9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the purpose is requested.")]
    public static readonly ExternalInvestigationReason1Code Purpose = new("PURP");

    /// <summary>Payment type clearing channel is incorrect, incomplete or missing.</summary>
    [IsoId("___Q7VdYUEe68t8Cw380-tA")]
    [Description(@"Payment type clearing channel is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code PaymentClearingChannel = new("PYCC");

    /// <summary>Transaction payment purpose is incorrect, incomplete or missing.</summary>
    [IsoId("___Q7XdYUEe68t8Cw380-tA")]
    [Description(@"Transaction payment purpose is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code PaymentPurpose = new("PYPU");

    /// <summary>Requested execution date is incorrect or missing.</summary>
    [IsoId("___Q7QdYUEe68t8Cw380-tA")]
    [Description(@"Requested execution date is incorrect or missing.")]
    public static readonly ExternalInvestigationReason1Code RequestedExecutionDate = new("REDT");

    /// <summary>Regulatory reporting is incomplete or missing.</summary>
    [IsoId("___Q7c9YUEe68t8Cw380-tA")]
    [Description(@"Regulatory reporting is incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code RegulatoryReporting = new("REGR");

    /// <summary>Remittance information is incorrect, incomplete or missing.</summary>
    [IsoId("___Q7W9YUEe68t8Cw380-tA")]
    [Description(@"Remittance information is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code RemittanceInformation = new("REIN");

    /// <summary>Related transaction reference is incorrect, incomplete or missing.</summary>
    [IsoId("___Q7O9YUEe68t8Cw380-tA")]
    [Description(@"Related transaction reference is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code RelatedReference = new("RERE");

    /// <summary>Request from International Monetary Fund.</summary>
    [IsoId("___asHdYUEe68t8Cw380-tA")]
    [Description(@"Request from International Monetary Fund.")]
    public static readonly ExternalInvestigationReason1Code RequestFromIMF = new("RIMF");

    /// <summary>Account closure date is requested.</summary>
    [IsoId("___asCdYUEe68t8Cw380-tA")]
    [Description(@"Account closure date is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestAccountClosureDate = new("RQCD");

    /// <summary>Investigation relating to charges that have been taken or are unpaid.</summary>
    [IsoId("___asG9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to charges that have been taken or are unpaid.")]
    public static readonly ExternalInvestigationReason1Code RequestRelatedToCharges = new("RQCH");

    /// <summary>Debit authorisation on an entry is requested.</summary>
    [IsoId("___asF9YUEe68t8Cw380-tA")]
    [Description(@"Debit authorisation on an entry is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestDebitAuthorisation = new("RQDA");

    /// <summary>Documentation relating to the transaction is requested.</summary>
    [IsoId("___asA9YUEe68t8Cw380-tA")]
    [Description(@"Documentation relating to the transaction is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestDocumentation = new("RQDO");

    /// <summary>Clarification over when goods or services were exchanged is requested.</summary>
    [IsoId("___asAdYUEe68t8Cw380-tA")]
    [Description(@"Clarification over when goods or services were exchanged is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestServicesOrGoodsExchangeDate = new("RQED");

    /// <summary>Clarification over location details is requested.</summary>
    [IsoId("___ar_dYUEe68t8Cw380-tA")]
    [Description(@"Clarification over location details is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestLocationDetails = new("RQLD");

    /// <summary>Clarification over a party relationship is requested.</summary>
    [IsoId("___ar-dYUEe68t8Cw380-tA")]
    [Description(@"Clarification over a party relationship is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestPartyRelationship = new("RQPR");

    /// <summary>Clarification over goods or services involved is requested.</summary>
    [IsoId("___ar_9YUEe68t8Cw380-tA")]
    [Description(@"Clarification over goods or services involved is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestServicesOrGoodsDetails = new("RQSG");

    /// <summary>Use of funds on an entry is requested.</summary>
    [IsoId("___asFdYUEe68t8Cw380-tA")]
    [Description(@"Use of funds on an entry is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestUseOfFunds = new("RQUF");

    /// <summary>Revaluation of an entry is requested.</summary>
    [IsoId("___asE9YUEe68t8Cw380-tA")]
    [Description(@"Revaluation of an entry is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestValueDateAdjustment = new("RQVA");

    /// <summary>Clarification over a vessel or aircraft is requested.</summary>
    [IsoId("___ar-9YUEe68t8Cw380-tA")]
    [Description(@"Clarification over a vessel or aircraft is requested.")]
    public static readonly ExternalInvestigationReason1Code RequestVesselOrAircraftDetails = new("RQVD");

    /// <summary>Further information pertaining to the settlement account is requested.</summary>
    [IsoId("___Q7Z9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the settlement account is requested.")]
    public static readonly ExternalInvestigationReason1Code SettlementAccount = new("SEAC");

    /// <summary>Further information pertaining to a statement entry is requested.</summary>
    [IsoId("___Q7ZdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to a statement entry is requested.")]
    public static readonly ExternalInvestigationReason1Code StatementEntry = new("STET");

    /// <summary>Payment type service level is incorrect, incomplete or missing.</summary>
    [IsoId("___Q7PdYUEe68t8Cw380-tA")]
    [Description(@"Payment type service level is incorrect, incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code PaymentServiceLevel = new("SVLV");

    /// <summary>Tax data is incomplete or missing.</summary>
    [IsoId("___Q7ddYUEe68t8Cw380-tA")]
    [Description(@"Tax data is incomplete or missing.")]
    public static readonly ExternalInvestigationReason1Code Tax = new("TAXD");

    /// <summary>Further information pertaining to the third reimbursement agent is requested.</summary>
    [IsoId("___Q7UdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the third reimbursement agent is requested.")]
    public static readonly ExternalInvestigationReason1Code ThirdReimbursementAgent = new("TDRA");

    /// <summary>Further information pertaining to the ultimate creditor is requested.</summary>
    [IsoId("___Q7bdYUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate creditor is requested.")]
    public static readonly ExternalInvestigationReason1Code UltimateCreditor = new("ULTC");

    /// <summary>Further information pertaining to the ultimate debtor is requested.</summary>
    [IsoId("___Q7a9YUEe68t8Cw380-tA")]
    [Description(@"Further information pertaining to the ultimate debtor is requested.")]
    public static readonly ExternalInvestigationReason1Code UltimateDebtor = new("ULTD");

    /// <summary>A booked entry cannot be applied by the creditor.</summary>
    [IsoId("___asC9YUEe68t8Cw380-tA")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    public static readonly ExternalInvestigationReason1Code UnableToApplyByCreditor = new("UTAP");
}
