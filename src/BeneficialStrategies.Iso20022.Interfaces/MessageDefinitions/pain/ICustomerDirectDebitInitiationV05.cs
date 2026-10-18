// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.008.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding agent or creditor agent. It is used to request single or bulk collection(s) of funds from one or various debtor&apos;s account(s) for a creditor.
/// Usage
/// The CustomerDirectDebitInitiation message can contain one or more direct debit instructions.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the creditor agent. The creditor agent is the account servicer of the creditor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerDirectDebitInitiation message to the creditor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerDirectDebitInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerDirectDebitInitiation may or may not contain mandate related information, i.e. extracts from a mandate, such as MandateIdentification or DateOfSignature. The CustomerDirectDebitInitiation message must not be considered as a mandate.
/// The CustomerDirectDebitInitiation message must not be used by the creditor agent to execute the direct debit instruction(s). The FIToFICustomerDirectDebit message must be used instead.
/// </summary>
[IsoId("_NasXOxPeEeSVo-TFVwFHvA")]
public interface ICustomerDirectDebitInitiationV05 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_NasXPxPeEeSVo-TFVwFHvA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader55 GroupHeader { get; }

    /// <summary>
    /// Set of characteristics that apply to the credit side of the payment transactions included in the direct debit transaction initiation.
    /// </summary>
    [IsoId("_NasXQRPeEeSVo-TFVwFHvA")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    IPaymentInstruction15 PaymentInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_NasXQxPeEeSVo-TFVwFHvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
