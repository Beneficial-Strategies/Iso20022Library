// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group Header113.
/// </summary>
[IsoId("_yfTmITEyEe6g-ffJsqGiSA")]
public interface IGroupHeader113 : IIsoComponent
{
    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// Batch Booking.
    /// </summary>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    BatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number Of Transactions.
    /// </summary>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    Max15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Control Sum.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    DecimalNumber? ControlSum { get; }

    /// <summary>
    /// Total Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; }

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Settlement Information.
    /// </summary>
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInstruction15 SettlementInformation { get; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Instructing Agent.
    /// </summary>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Instructed Agent.
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }
}
