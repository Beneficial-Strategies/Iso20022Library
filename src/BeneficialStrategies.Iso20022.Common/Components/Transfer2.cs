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
[IsoId("_VNFG4dp-Ed-ak6NoX_4Aeg_-1626718035")]
[DisplayName("Transfer")]
public partial record Transfer2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VNFG4tp-Ed-ak6NoX_4Aeg_1313625755")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    
    /// <summary>
    /// Reference that identifies the whole transfer out transaction.
    /// </summary>
    [IsoId("_VNFG49p-Ed-ak6NoX_4Aeg_-1943607980")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Date and optionally time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    [IsoId("_VNFG5Np-Ed-ak6NoX_4Aeg_-881372013")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    
    /// <summary>
    /// Date when the transfer was received and processed.
    /// </summary>
    [IsoId("_VNFG5dp-Ed-ak6NoX_4Aeg_-284362116")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_VNFG5tp-Ed-ak6NoX_4Aeg_395185062")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_VNFG59p-Ed-ak6NoX_4Aeg_1908338067")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit1? UnitsDetails { get; init; } 
    
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_VNFG6Np-Ed-ak6NoX_4Aeg_395185349")]
    [DisplayName("Portfolio Transfer Out Rate")]
    [IsoXmlTag("PrtflTrfOutRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PortfolioTransferOutRate { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_VNFG6dp-Ed-ak6NoX_4Aeg_387481252")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator OwnAccountTransferIndicator { get; init; } 
    
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_VNOQ0Np-Ed-ak6NoX_4Aeg_671128385")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    
    
    #nullable disable
    
}
