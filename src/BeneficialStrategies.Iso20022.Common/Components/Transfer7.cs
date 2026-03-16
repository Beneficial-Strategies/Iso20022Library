// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[IsoId("_SfoCKtp-Ed-ak6NoX_4Aeg_-217478218")]
[DisplayName("Transfer")]
public record Transfer7
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SfxzINp-Ed-ak6NoX_4Aeg_611843512")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_SfxzIdp-Ed-ak6NoX_4Aeg_-216558109")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationReference { get; init; }

    /// <summary>
    /// Reference that identifies the transfer in transaction.
    /// </summary>
    [IsoId("_SfxzItp-Ed-ak6NoX_4Aeg_-216558229")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_SfxzI9p-Ed-ak6NoX_4Aeg_611843529")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_SfxzJNp-Ed-ak6NoX_4Aeg_-216558204")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    [IsoId("_SfxzJdp-Ed-ak6NoX_4Aeg_-216558144")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required DateAndDateTimeChoice_ TradeDate { get; init; }

    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [IsoId("_SfxzJtp-Ed-ak6NoX_4Aeg_-216558127")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; }

    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_SfxzJ9p-Ed-ak6NoX_4Aeg_-216558063")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit3? UnitsDetails { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_SfxzKNp-Ed-ak6NoX_4Aeg_-216558187")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; }

    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_SfxzKdp-Ed-ak6NoX_4Aeg_-216558169")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_Sf69ENp-Ed-ak6NoX_4Aeg_1845750122")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }
}
