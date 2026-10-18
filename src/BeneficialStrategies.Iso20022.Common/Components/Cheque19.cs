// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICheque19"/>
[IsoId("_4oDGATEyEe6g-ffJsqGiSA")]
[DisplayName("Cheque19")]
public partial record Cheque19
{
    /// <inheritdoc cref="ICheque19.ChequeFrom"/>
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress18? ChequeFrom { get; init; }

    /// <inheritdoc cref="ICheque19.ChequeMaturityDate"/>
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <inheritdoc cref="ICheque19.ChequeNumber"/>
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <inheritdoc cref="ICheque19.ChequeType"/>
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <inheritdoc cref="ICheque19.DeliverTo"/>
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress18? DeliverTo { get; init; }

    /// <inheritdoc cref="ICheque19.DeliveryMethod"/>
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <inheritdoc cref="ICheque19.FormsCode"/>
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ICheque19.InstructionPriority"/>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="ICheque19.MemoField"/>
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    public SimpleValueList<IsoMax35Text> MemoField { get; init; } = [];

    /// <inheritdoc cref="ICheque19.PrintLocation"/>
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    public IsoMax35Text? PrintLocation { get; init; }

    /// <inheritdoc cref="ICheque19.RegionalClearingZone"/>
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <inheritdoc cref="ICheque19.Signature"/>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SimpleValueList<IsoMax70Text> Signature { get; init; } = [];
}
