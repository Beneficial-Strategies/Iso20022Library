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
[IsoId("_M_NF8ZwxEeazcsnODTksnQ")]
[DisplayName("Intra Position Details")]
public record IntraPositionDetails43
{
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    [IsoId("_M_NF95wxEeazcsnODTksnQ")]
    [DisplayName("Settled Quantity")]
    [IsoXmlTag("SttldQty")]
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; }

    /// <summary>
    /// Number identifying a Securities Sub balance Type (example restriction identification etc…).
    /// </summary>
    [IsoId("_M_NF_5wxEeazcsnODTksnQ")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    [IsoId("_M_NGAZwxEeazcsnODTksnQ")]
    [DisplayName("Collateral Monitor Amount")]
    [IsoXmlTag("CollMntrAmt")]
    public AmountAndDirection55? CollateralMonitorAmount { get; init; }

    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    [IsoId("_M_NGA5wxEeazcsnODTksnQ")]
    [DisplayName("Previously Settled Quantity")]
    [IsoXmlTag("PrevslySttldQty")]
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    [IsoId("_M_NGC5wxEeazcsnODTksnQ")]
    [DisplayName("Remaining To Be Settled Quantity")]
    [IsoXmlTag("RmngToBeSttldQty")]
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; }

    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    [IsoId("_M_NGE5wxEeazcsnODTksnQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTimeChoice_ SettlementDate { get; init; }

    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    [IsoId("_M_NGG5wxEeazcsnODTksnQ")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateAndDateTimeChoice_? AvailableDate { get; init; }

    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    [IsoId("_M_NGI5wxEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Event Type")]
    [IsoXmlTag("CorpActnEvtTp")]
    public CorporateActionEventType69Choice_? CorporateActionEventType { get; init; }

    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_M_NGK5wxEeazcsnODTksnQ")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown4 BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_M_NGM5wxEeazcsnODTksnQ")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown4 BalanceTo { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_M_NGO5wxEeazcsnODTksnQ")]
    [DisplayName("Instruction Processing Additional Details")]
    [IsoXmlTag("InstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; }
}
