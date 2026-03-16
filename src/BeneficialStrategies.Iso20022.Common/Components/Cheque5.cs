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
[IsoId("_QbmU4dp-Ed-ak6NoX_4Aeg_-1212009635")]
[DisplayName("Cheque")]
public record Cheque5
{
    /// <summary>
    /// Specifies the type of cheque to be issued by the first agent.
    /// </summary>
    [IsoId("_QbmU4tp-Ed-ak6NoX_4Aeg_-1211088283")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <summary>
    /// Identifies the cheque number.
    /// </summary>
    [IsoId("_QbmU49p-Ed-ak6NoX_4Aeg_-1211088128")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    [IsoId("_QbmU5Np-Ed-ak6NoX_4Aeg_-1210162253")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress3? ChequeFrom { get; init; }

    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor&apos;s agent.
    /// </summary>
    [IsoId("_QbmU5dp-Ed-ak6NoX_4Aeg_302562708")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <summary>
    /// Identifies the party to whom the debtor&apos;s agent should send the cheque.
    /// </summary>
    [IsoId("_QbmU5tp-Ed-ak6NoX_4Aeg_-1210162582")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress3? DeliverTo { get; init; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_QbmU59p-Ed-ak6NoX_4Aeg_-1210165061")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <summary>
    /// Date when the draft becomes payable and the debtor&apos;s account is debited.
    /// </summary>
    [IsoId("_QbmU6Np-Ed-ak6NoX_4Aeg_-1210164546")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <summary>
    /// Code agreed between the initiating party and the debtor&apos;s agent, that specifies the cheque layout, company logo and digitised signature to be used to print the cheque.
    /// </summary>
    [IsoId("_QbmU6dp-Ed-ak6NoX_4Aeg_-1210163728")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    [IsoId("_QbwF4Np-Ed-ak6NoX_4Aeg_-1210163572")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MemoField { get; init; }

    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    [IsoId("_QbwF4dp-Ed-ak6NoX_4Aeg_-1210162797")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    [IsoId("_QbwF4tp-Ed-ak6NoX_4Aeg_-196138042")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }
}
