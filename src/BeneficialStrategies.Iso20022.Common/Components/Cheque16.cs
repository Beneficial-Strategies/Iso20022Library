// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICheque16"/>
[IsoId("__Pad0V6HEe26aImdqMavcg")]
[DisplayName("Cheque")]
public partial record Cheque16
{
    /// <inheritdoc cref="ICheque16.ChequeType"/>
    [IsoId("__pfKtV6HEe26aImdqMavcg")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <inheritdoc cref="ICheque16.ChequeNumber"/>
    [IsoId("__pfKt16HEe26aImdqMavcg")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <inheritdoc cref="ICheque16.ChequeFrom"/>
    [IsoId("__pfKuV6HEe26aImdqMavcg")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress16? ChequeFrom { get; init; }

    /// <inheritdoc cref="ICheque16.DeliveryMethod"/>
    [IsoId("__pfKu16HEe26aImdqMavcg")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <inheritdoc cref="ICheque16.DeliverTo"/>
    [IsoId("__pfKvV6HEe26aImdqMavcg")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress16? DeliverTo { get; init; }

    /// <inheritdoc cref="ICheque16.InstructionPriority"/>
    [IsoId("__pfKv16HEe26aImdqMavcg")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="ICheque16.ChequeMaturityDate"/>
    [IsoId("__pfKwV6HEe26aImdqMavcg")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <inheritdoc cref="ICheque16.FormsCode"/>
    [IsoId("__pfKw16HEe26aImdqMavcg")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ICheque16.MemoField"/>
    [IsoId("__pfKxV6HEe26aImdqMavcg")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> MemoField { get; init; } = [];

    /// <inheritdoc cref="ICheque16.RegionalClearingZone"/>
    [IsoId("__pfKx16HEe26aImdqMavcg")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <inheritdoc cref="ICheque16.PrintLocation"/>
    [IsoId("__pfKyV6HEe26aImdqMavcg")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }

    /// <inheritdoc cref="ICheque16.Signature"/>
    [IsoId("__pfKy16HEe26aImdqMavcg")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<string> Signature { get; init; } = [];
}
