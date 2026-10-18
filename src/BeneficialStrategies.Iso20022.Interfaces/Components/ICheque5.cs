// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbmU4dp-Ed-ak6NoX_4Aeg_-1212009635")]
public interface ICheque5 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of cheque to be issued by the first agent.
    /// </summary>
    [IsoId("_QbmU4tp-Ed-ak6NoX_4Aeg_-1211088283")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    ChequeType2Code? ChequeType { get; }

    /// <summary>
    /// Identifies the cheque number.
    /// </summary>
    [IsoId("_QbmU49p-Ed-ak6NoX_4Aeg_-1211088128")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    IsoMax35Text? ChequeNumber { get; }

    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    [IsoId("_QbmU5Np-Ed-ak6NoX_4Aeg_-1210162253")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    INameAndAddress3? ChequeFrom { get; }

    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_QbmU5dp-Ed-ak6NoX_4Aeg_302562708")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    IChequeDeliveryMethod1Choice? DeliveryMethod { get; }

    /// <summary>
    /// Identifies the party to whom the debtor&apos;s agent should send the cheque.
    /// </summary>
    [IsoId("_QbmU5tp-Ed-ak6NoX_4Aeg_-1210162582")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    INameAndAddress3? DeliverTo { get; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_QbmU59p-Ed-ak6NoX_4Aeg_-1210165061")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Date when the draft becomes payable and the debtor&apos;s account is debited.
    /// </summary>
    [IsoId("_QbmU6Np-Ed-ak6NoX_4Aeg_-1210164546")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    IsoISODate? ChequeMaturityDate { get; }

    /// <summary>
    /// Code agreed between the initiating party and the debtor&apos;s agent, that specifies the cheque layout, company logo and digitised signature to be used to print the cheque.
    /// </summary>
    [IsoId("_QbmU6dp-Ed-ak6NoX_4Aeg_-1210163728")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    IsoMax35Text? FormsCode { get; }

    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    [IsoId("_QbwF4Np-Ed-ak6NoX_4Aeg_-1210163572")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    IsoMax35Text? MemoField { get; }

    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    [IsoId("_QbwF4dp-Ed-ak6NoX_4Aeg_-1210162797")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    IsoMax35Text? RegionalClearingZone { get; }

    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    [IsoId("_QbwF4tp-Ed-ak6NoX_4Aeg_-196138042")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    IsoMax35Text? PrintLocation { get; }
}
