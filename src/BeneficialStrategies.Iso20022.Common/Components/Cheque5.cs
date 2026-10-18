// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICheque5"/>
[IsoId("_QbmU4dp-Ed-ak6NoX_4Aeg_-1212009635")]
[DisplayName("Cheque")]
public partial record Cheque5
{
    /// <inheritdoc cref="ICheque5.ChequeType"/>
    [IsoId("_QbmU4tp-Ed-ak6NoX_4Aeg_-1211088283")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <inheritdoc cref="ICheque5.ChequeNumber"/>
    [IsoId("_QbmU49p-Ed-ak6NoX_4Aeg_-1211088128")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <inheritdoc cref="ICheque5.ChequeFrom"/>
    [IsoId("_QbmU5Np-Ed-ak6NoX_4Aeg_-1210162253")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress3? ChequeFrom { get; init; }

    /// <inheritdoc cref="ICheque5.DeliveryMethod"/>
    [IsoId("_QbmU5dp-Ed-ak6NoX_4Aeg_302562708")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <inheritdoc cref="ICheque5.DeliverTo"/>
    [IsoId("_QbmU5tp-Ed-ak6NoX_4Aeg_-1210162582")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress3? DeliverTo { get; init; }

    /// <inheritdoc cref="ICheque5.InstructionPriority"/>
    [IsoId("_QbmU59p-Ed-ak6NoX_4Aeg_-1210165061")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="ICheque5.ChequeMaturityDate"/>
    [IsoId("_QbmU6Np-Ed-ak6NoX_4Aeg_-1210164546")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <inheritdoc cref="ICheque5.FormsCode"/>
    [IsoId("_QbmU6dp-Ed-ak6NoX_4Aeg_-1210163728")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ICheque5.MemoField"/>
    [IsoId("_QbwF4Np-Ed-ak6NoX_4Aeg_-1210163572")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MemoField { get; init; }

    /// <inheritdoc cref="ICheque5.RegionalClearingZone"/>
    [IsoId("_QbwF4dp-Ed-ak6NoX_4Aeg_-1210162797")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <inheritdoc cref="ICheque5.PrintLocation"/>
    [IsoId("_QbwF4tp-Ed-ak6NoX_4Aeg_-196138042")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }
}
