// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.014.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a party to the next party in the creditor payment activation request chain.
/// It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).
/// </summary>
[IsoId("_r_AYEFkyEeGeoaLUQk__nA_-2103829610")]
public interface ICreditorPaymentActivationRequestStatusReportV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_r_JiAFkyEeGeoaLUQk__nA_1174820972")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader46 GroupHeader { get; }

    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_r_TTAFkyEeGeoaLUQk__nA_177748619")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    IOriginalGroupInformation25 OriginalGroupInformationAndStatus { get; }

    /// <summary>
    /// Information concerning the original payment information, to which the status report message refers.
    /// </summary>
    [IsoId("_r_TTAVkyEeGeoaLUQk__nA_-819323734")]
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    IOriginalPaymentInstruction5? OriginalPaymentInformationAndStatus { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_r_dEAFkyEeGeoaLUQk__nA_1886276423")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
