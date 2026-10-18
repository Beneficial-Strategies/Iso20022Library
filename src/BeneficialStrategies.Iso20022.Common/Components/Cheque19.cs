// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cheque19.
/// </summary>
[IsoId("_4oDGATEyEe6g-ffJsqGiSA")]
[DisplayName("Cheque19")]
public record Cheque19
{
    /// <summary>
    /// Cheque Type.
    /// </summary>
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <summary>
    /// Cheque Number.
    /// </summary>
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    public Max35Text? ChequeNumber { get; init; }

    /// <summary>
    /// Cheque From.
    /// </summary>
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress18? ChequeFrom { get; init; }

    /// <summary>
    /// Delivery Method.
    /// </summary>
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <summary>
    /// Deliver To.
    /// </summary>
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress18? DeliverTo { get; init; }

    /// <summary>
    /// Instruction Priority.
    /// </summary>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <summary>
    /// Cheque Maturity Date.
    /// </summary>
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    public ISODate? ChequeMaturityDate { get; init; }

    /// <summary>
    /// Forms Code.
    /// </summary>
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    public Max35Text? FormsCode { get; init; }

    /// <summary>
    /// Memo Field.
    /// </summary>
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    public SimpleValueList<Max35Text> MemoField { get; init; } = [];

    /// <summary>
    /// Regional Clearing Zone.
    /// </summary>
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    public Max35Text? RegionalClearingZone { get; init; }

    /// <summary>
    /// Print Location.
    /// </summary>
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    public Max35Text? PrintLocation { get; init; }

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SimpleValueList<Max70Text> Signature { get; init; } = [];
}
