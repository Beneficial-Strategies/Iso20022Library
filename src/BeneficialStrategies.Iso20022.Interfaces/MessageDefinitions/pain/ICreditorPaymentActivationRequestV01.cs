// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents.
/// It is used to initiate a creditor payment activation request.
/// </summary>
[IsoId("_GWSDldEvEd-BzquC8wXy7w_-1753887518")]
public interface ICreditorPaymentActivationRequestV01 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_GWSDltEvEd-BzquC8wXy7w_668976179")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader45 GroupHeader { get; }

    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the creditor payment initiation.
    /// </summary>
    [IsoId("_GWSDl9EvEd-BzquC8wXy7w_1980087289")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    IPaymentInstruction5 PaymentInformation { get; }
}
