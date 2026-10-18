// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICheque11"/>
[IsoId("_-VaZd24-EeiU9cctagi5ow")]
[DisplayName("Cheque")]
public partial record Cheque11
{
    /// <inheritdoc cref="ICheque11.ChequeType"/>
    [IsoId("_-fil1W4-EeiU9cctagi5ow")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <inheritdoc cref="ICheque11.ChequeNumber"/>
    [IsoId("_-fil124-EeiU9cctagi5ow")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <inheritdoc cref="ICheque11.ChequeFrom"/>
    [IsoId("_-fil2W4-EeiU9cctagi5ow")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress16? ChequeFrom { get; init; }

    /// <inheritdoc cref="ICheque11.DeliveryMethod"/>
    [IsoId("_-fil224-EeiU9cctagi5ow")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <inheritdoc cref="ICheque11.DeliverTo"/>
    [IsoId("_-fil3W4-EeiU9cctagi5ow")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress16? DeliverTo { get; init; }

    /// <inheritdoc cref="ICheque11.InstructionPriority"/>
    [IsoId("_-fil324-EeiU9cctagi5ow")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="ICheque11.ChequeMaturityDate"/>
    [IsoId("_-fil4W4-EeiU9cctagi5ow")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <inheritdoc cref="ICheque11.FormsCode"/>
    [IsoId("_-fil424-EeiU9cctagi5ow")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ICheque11.MemoField"/>
    [IsoId("_-fil5W4-EeiU9cctagi5ow")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> MemoField { get; init; } = [];

    /// <inheritdoc cref="ICheque11.RegionalClearingZone"/>
    [IsoId("_-fil524-EeiU9cctagi5ow")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <inheritdoc cref="ICheque11.PrintLocation"/>
    [IsoId("_-fil6W4-EeiU9cctagi5ow")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }

    /// <inheritdoc cref="ICheque11.Signature"/>
    [IsoId("_-fil624-EeiU9cctagi5ow")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<string> Signature { get; init; } = [];
}
