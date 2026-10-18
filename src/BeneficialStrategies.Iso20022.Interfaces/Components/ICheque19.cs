// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cheque19.
/// </summary>
[IsoId("_4oDGATEyEe6g-ffJsqGiSA")]
public interface ICheque19 : IIsoComponent
{
    /// <summary>
    /// Cheque From.
    /// </summary>
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    INameAndAddress18? ChequeFrom { get; }

    /// <summary>
    /// Cheque Maturity Date.
    /// </summary>
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    IsoISODate? ChequeMaturityDate { get; }

    /// <summary>
    /// Cheque Number.
    /// </summary>
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    IsoMax35Text? ChequeNumber { get; }

    /// <summary>
    /// Cheque Type.
    /// </summary>
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    ChequeType2Code? ChequeType { get; }

    /// <summary>
    /// Deliver To.
    /// </summary>
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    INameAndAddress18? DeliverTo { get; }

    /// <summary>
    /// Delivery Method.
    /// </summary>
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    IChequeDeliveryMethod1Choice? DeliveryMethod { get; }

    /// <summary>
    /// Forms Code.
    /// </summary>
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    IsoMax35Text? FormsCode { get; }

    /// <summary>
    /// Instruction Priority.
    /// </summary>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Memo Field.
    /// </summary>
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    IEnumerable<IsoMax35Text> MemoField { get; }

    /// <summary>
    /// Print Location.
    /// </summary>
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    IsoMax35Text? PrintLocation { get; }

    /// <summary>
    /// Regional Clearing Zone.
    /// </summary>
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    IsoMax35Text? RegionalClearingZone { get; }

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    IEnumerable<IsoMax70Text> Signature { get; }
}
