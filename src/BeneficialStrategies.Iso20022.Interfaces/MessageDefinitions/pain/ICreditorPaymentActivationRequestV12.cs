// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.013.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("d2b0673a-1f10-4086-ad39-b4f95fef2cb5")]
public interface ICreditorPaymentActivationRequestV12 : IOuterRecord
{
    /// <summary>
    /// Group Header.
    /// </summary>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader112 GroupHeader { get; }

    /// <summary>
    /// Payment Information.
    /// </summary>
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    IEnumerable<IPaymentInstruction48> PaymentInformation { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
