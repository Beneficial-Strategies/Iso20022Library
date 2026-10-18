// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICheque7"/>
[IsoId("_tcJEcFkyEeGeoaLUQk__nA_-387134073")]
[DisplayName("Cheque")]
public partial record Cheque7
{
    /// <inheritdoc cref="ICheque7.ChequeType"/>
    [IsoId("_tcJEcVkyEeGeoaLUQk__nA_976404247")]
    [DisplayName("Cheque Type")]
    [IsoXmlTag("ChqTp")]
    public ChequeType2Code? ChequeType { get; init; }

    /// <inheritdoc cref="ICheque7.ChequeNumber"/>
    [IsoId("_tcJEclkyEeGeoaLUQk__nA_-1044651388")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <inheritdoc cref="ICheque7.ChequeFrom"/>
    [IsoId("_tcJEc1kyEeGeoaLUQk__nA_-1205181364")]
    [DisplayName("Cheque From")]
    [IsoXmlTag("ChqFr")]
    public NameAndAddress10? ChequeFrom { get; init; }

    /// <inheritdoc cref="ICheque7.DeliveryMethod"/>
    [IsoId("_tcSOYFkyEeGeoaLUQk__nA_-1812000377")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <inheritdoc cref="ICheque7.DeliverTo"/>
    [IsoId("_tcSOYVkyEeGeoaLUQk__nA_-1843971141")]
    [DisplayName("Deliver To")]
    [IsoXmlTag("DlvrTo")]
    public NameAndAddress10? DeliverTo { get; init; }

    /// <inheritdoc cref="ICheque7.InstructionPriority"/>
    [IsoId("_tcSOYlkyEeGeoaLUQk__nA_-2054191839")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="ICheque7.ChequeMaturityDate"/>
    [IsoId("_tcSOY1kyEeGeoaLUQk__nA_-1432691134")]
    [DisplayName("Cheque Maturity Date")]
    [IsoXmlTag("ChqMtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ChequeMaturityDate { get; init; }

    /// <inheritdoc cref="ICheque7.FormsCode"/>
    [IsoId("_tcSOZFkyEeGeoaLUQk__nA_1601985680")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <inheritdoc cref="ICheque7.MemoField"/>
    [IsoId("_tcb_YFkyEeGeoaLUQk__nA_-631615173")]
    [DisplayName("Memo Field")]
    [IsoXmlTag("MemoFld")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> MemoField { get; init; } = [];

    /// <inheritdoc cref="ICheque7.RegionalClearingZone"/>
    [IsoId("_tcb_YVkyEeGeoaLUQk__nA_200714969")]
    [DisplayName("Regional Clearing Zone")]
    [IsoXmlTag("RgnlClrZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionalClearingZone { get; init; }

    /// <inheritdoc cref="ICheque7.PrintLocation"/>
    [IsoId("_tcb_YlkyEeGeoaLUQk__nA_-1913299118")]
    [DisplayName("Print Location")]
    [IsoXmlTag("PrtLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PrintLocation { get; init; }

    /// <inheritdoc cref="ICheque7.Signature"/>
    [IsoId("_tcb_Y1kyEeGeoaLUQk__nA_-667422494")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<string> Signature { get; init; } = [];
}
