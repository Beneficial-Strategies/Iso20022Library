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
[IsoId("_QXbmltp-Ed-ak6NoX_4Aeg_-678920950")]
[DisplayName("Intra Position Details")]
public record IntraPositionDetails2
{
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_QXbml9p-Ed-ak6NoX_4Aeg_-348579616")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_QXbmmNp-Ed-ak6NoX_4Aeg_-191425032")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_QXbmmdp-Ed-ak6NoX_4Aeg_840553151")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_QXbmmtp-Ed-ak6NoX_4Aeg_-1239243328")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; }

    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_QXkwgNp-Ed-ak6NoX_4Aeg_-1232777149")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTimeChoice_? AvailableDate { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_QXkwgdp-Ed-ak6NoX_4Aeg_161481770")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; init; }

    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    [IsoId("_QXkwgtp-Ed-ak6NoX_4Aeg_-678920890")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesBalanceType3Choice_ BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_QXkwg9p-Ed-ak6NoX_4Aeg_-678920873")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesBalanceType3Choice_ BalanceTo { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_QXkwhNp-Ed-ak6NoX_4Aeg_-678920932")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; }
}
