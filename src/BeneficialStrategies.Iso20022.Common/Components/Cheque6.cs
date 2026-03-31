// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbwF6dp-Ed-ak6NoX_4Aeg_666058434")]
[DisplayName("Cheque")]
public record Cheque6
{
    /// <summary>
    /// Specifies the type of cheque to be issued.
    /// </summary>
    [IsoId("_QbwF6tp-Ed-ak6NoX_4Aeg_666058436")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_Qb524Np-Ed-ak6NoX_4Aeg_666058713")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    [IsoId("_Qb524dp-Ed-ak6NoX_4Aeg_-1889220517")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress10? ChequeFrom { get; init; }

    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_Qb524tp-Ed-ak6NoX_4Aeg_666059292")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <summary>
    /// Party to whom the debtor&apos;s agent needs to send the cheque.
    /// </summary>
    [IsoId("_QcpdwNp-Ed-ak6NoX_4Aeg_1987389380")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress10? DeliverTo { get; init; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_Qcpdwdp-Ed-ak6NoX_4Aeg_666058743")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <summary>
    /// Date when the draft becomes payable and the debtor&apos;s account is debited.
    /// </summary>
    [IsoId("_Qcpdwtp-Ed-ak6NoX_4Aeg_666058797")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <summary>
    /// Identifies, in a coded form, the cheque layout, company logo and digitised signature to be used to print the cheque, as agreed between the initiating party and the debtor&apos;s agent.
    /// </summary>
    [IsoId("_Qcpdw9p-Ed-ak6NoX_4Aeg_666058828")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    [IsoId("_QcpdxNp-Ed-ak6NoX_4Aeg_666059137")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> MemoField { get; init; } = [];

    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    [IsoId("_Qcpdxdp-Ed-ak6NoX_4Aeg_666059168")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    [IsoId("_Qcpdxtp-Ed-ak6NoX_4Aeg_666059230")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }
}
