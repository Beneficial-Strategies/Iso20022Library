// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[IsoId("_VNOQ1Np-Ed-ak6NoX_4Aeg_1641810312")]
[DisplayName("Transfer")]
public partial record Transfer4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VNOQ1dp-Ed-ak6NoX_4Aeg_1116256257")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    
    /// <summary>
    /// Reference that identifies the transfer in transaction.
    /// </summary>
    [IsoId("_VNOQ1tp-Ed-ak6NoX_4Aeg_882100093")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Date and optionally time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    [IsoId("_VNOQ19p-Ed-ak6NoX_4Aeg_451429524")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    
    /// <summary>
    /// Date when the transfer was received and processed.
    /// </summary>
    [IsoId("_VNOQ2Np-Ed-ak6NoX_4Aeg_-827985976")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_VNOQ2dp-Ed-ak6NoX_4Aeg_-40221122")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_VNOQ2tp-Ed-ak6NoX_4Aeg_1259759606")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit1? UnitsDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_VNYB0Np-Ed-ak6NoX_4Aeg_1714769377")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator OwnAccountTransferIndicator { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VNYB0dp-Ed-ak6NoX_4Aeg_426896784")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    
    
    #nullable disable
    
}
