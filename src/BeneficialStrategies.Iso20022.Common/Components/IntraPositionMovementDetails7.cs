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
[IsoId("_mKkka_7xEeCvPoRGOxRobQ")]
[DisplayName("Intra Position Movement Details")]
public record IntraPositionMovementDetails7
{
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    [IsoId("_mKkkdf7xEeCvPoRGOxRobQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public References27Choice_? Identification { get; init; }

    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_mKkkef7xEeCvPoRGOxRobQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_mKkkff7xEeCvPoRGOxRobQ")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_mKkkgf7xEeCvPoRGOxRobQ")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Number identifying a Securities Sub balance Type (e.g. restriction identification etc…).
    /// </summary>
    [IsoId("_mKkkhf7xEeCvPoRGOxRobQ")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    [IsoId("_mKkkif7xEeCvPoRGOxRobQ")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesBalanceType3Choice_ BalanceTo { get; init; }

    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_mKkkjf7xEeCvPoRGOxRobQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; }

    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_mKkkkf7xEeCvPoRGOxRobQ")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTimeChoice_? AvailableDate { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_mKkklf7xEeCvPoRGOxRobQ")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType3Choice_? CorporateActionEventType { get; init; }

    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_mKkkmf7xEeCvPoRGOxRobQ")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection9? CollateralMonitorAmount { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_mKkknf7xEeCvPoRGOxRobQ")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mKkkof7xEeCvPoRGOxRobQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
