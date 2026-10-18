// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbwF6dp-Ed-ak6NoX_4Aeg_666058434")]
public interface ICheque6 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of cheque to be issued.
    /// </summary>
    [IsoId("_QbwF6tp-Ed-ak6NoX_4Aeg_666058436")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    ChequeType2Code? ChequeType { get; }

    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_Qb524Np-Ed-ak6NoX_4Aeg_666058713")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    IsoMax35Text? ChequeNumber { get; }

    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    [IsoId("_Qb524dp-Ed-ak6NoX_4Aeg_-1889220517")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    INameAndAddress10? ChequeFrom { get; }

    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_Qb524tp-Ed-ak6NoX_4Aeg_666059292")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    IChequeDeliveryMethod1Choice? DeliveryMethod { get; }

    /// <summary>
    /// Party to whom the debtor&apos;s agent needs to send the cheque.
    /// </summary>
    [IsoId("_QcpdwNp-Ed-ak6NoX_4Aeg_1987389380")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    INameAndAddress10? DeliverTo { get; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_Qcpdwdp-Ed-ak6NoX_4Aeg_666058743")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Date when the draft becomes payable and the debtor&apos;s account is debited.
    /// </summary>
    [IsoId("_Qcpdwtp-Ed-ak6NoX_4Aeg_666058797")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    IsoISODate? ChequeMaturityDate { get; }

    /// <summary>
    /// Identifies, in a coded form, the cheque layout, company logo and digitised signature to be used to print the cheque, as agreed between the initiating party and the debtor&apos;s agent.
    /// </summary>
    [IsoId("_Qcpdw9p-Ed-ak6NoX_4Aeg_666058828")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    IsoMax35Text? FormsCode { get; }

    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    [IsoId("_QcpdxNp-Ed-ak6NoX_4Aeg_666059137")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    IEnumerable<string> MemoField { get; }

    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    [IsoId("_Qcpdxdp-Ed-ak6NoX_4Aeg_666059168")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    IsoMax35Text? RegionalClearingZone { get; }

    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    [IsoId("_Qcpdxtp-Ed-ak6NoX_4Aeg_666059230")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    IsoMax35Text? PrintLocation { get; }
}
