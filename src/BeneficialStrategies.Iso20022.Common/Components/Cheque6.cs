// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICheque6"/>
[IsoId("_QbwF6dp-Ed-ak6NoX_4Aeg_666058434")]
[DisplayName("Cheque")]
public partial record Cheque6
{
    /// <inheritdoc cref="ICheque6.ChequeType"/>
    [IsoId("_QbwF6tp-Ed-ak6NoX_4Aeg_666058436")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <inheritdoc cref="ICheque6.ChequeNumber"/>
    [IsoId("_Qb524Np-Ed-ak6NoX_4Aeg_666058713")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <inheritdoc cref="ICheque6.ChequeFrom"/>
    [IsoId("_Qb524dp-Ed-ak6NoX_4Aeg_-1889220517")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress10? ChequeFrom { get; init; }

    /// <inheritdoc cref="ICheque6.DeliveryMethod"/>
    [IsoId("_Qb524tp-Ed-ak6NoX_4Aeg_666059292")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <inheritdoc cref="ICheque6.DeliverTo"/>
    [IsoId("_QcpdwNp-Ed-ak6NoX_4Aeg_1987389380")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress10? DeliverTo { get; init; }

    /// <inheritdoc cref="ICheque6.InstructionPriority"/>
    [IsoId("_Qcpdwdp-Ed-ak6NoX_4Aeg_666058743")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="ICheque6.ChequeMaturityDate"/>
    [IsoId("_Qcpdwtp-Ed-ak6NoX_4Aeg_666058797")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <inheritdoc cref="ICheque6.FormsCode"/>
    [IsoId("_Qcpdw9p-Ed-ak6NoX_4Aeg_666058828")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ICheque6.MemoField"/>
    [IsoId("_QcpdxNp-Ed-ak6NoX_4Aeg_666059137")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> MemoField { get; init; } = [];

    /// <inheritdoc cref="ICheque6.RegionalClearingZone"/>
    [IsoId("_Qcpdxdp-Ed-ak6NoX_4Aeg_666059168")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <inheritdoc cref="ICheque6.PrintLocation"/>
    [IsoId("_Qcpdxtp-Ed-ak6NoX_4Aeg_666059230")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }
}
