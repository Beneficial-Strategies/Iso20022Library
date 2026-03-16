// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_QXIrqdp-Ed-ak6NoX_4Aeg_-1139695285")]
[DisplayName("Intra Position Movement Details")]
public record IntraPositionMovementDetails1
{
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    [IsoId("_QXIrqtp-Ed-ak6NoX_4Aeg_778458994")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public References5Choice_? Identification { get; init; }

    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_QXIrq9p-Ed-ak6NoX_4Aeg_1125702783")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_QXIrrNp-Ed-ak6NoX_4Aeg_1208217404")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_QXR1kNp-Ed-ak6NoX_4Aeg_-1745108224")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_QXR1kdp-Ed-ak6NoX_4Aeg_1465556663")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesBalanceType3Choice_ BalanceTo { get; init; }

    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_QXR1ktp-Ed-ak6NoX_4Aeg_1623481978")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; }

    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_QXR1k9p-Ed-ak6NoX_4Aeg_1062635611")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTimeChoice_? AvailableDate { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_QXR1lNp-Ed-ak6NoX_4Aeg_954586631")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_QXR1ldp-Ed-ak6NoX_4Aeg_954586632")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_QXR1ltp-Ed-ak6NoX_4Aeg_1256391520")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension2> Extension { get; init; } = [];
}
