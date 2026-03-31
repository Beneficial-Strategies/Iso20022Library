// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the CA security option.
/// </summary>
[IsoId("_UHVm2dp-Ed-ak6NoX_4Aeg_-583360205")]
[DisplayName("Security Option")]
public record SecurityOption1
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UHVm2tp-Ed-ak6NoX_4Aeg_-527946931")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required FinancialInstrumentDescription3 SecurityIdentification { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_UHVm29p-Ed-ak6NoX_4Aeg_-564889355")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_UHfX0Np-Ed-ak6NoX_4Aeg_-454066333")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public UnitOrFaceAmount1Choice_? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_UHfX0dp-Ed-ak6NoX_4Aeg_-121597685")]
    [DisplayName("Minimum Exercisable Securities Quantity")]
    [IsoXmlTag("MinExrcblSctiesQty")]
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_UHfX0tp-Ed-ak6NoX_4Aeg_-81886522")]
    [DisplayName("Minimum Exercisable Multiple Securities Quantity")]
    [IsoXmlTag("MinExrcblMltplSctiesQty")]
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; init; }

    /// <summary>
    /// New denomination of the financial instrument following, eg, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_UHfX09p-Ed-ak6NoX_4Aeg_2044074483")]
    [DisplayName("New Denomination Securities Quantity")]
    [IsoXmlTag("NewDnmtnSctiesQty")]
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_UHfX1Np-Ed-ak6NoX_4Aeg_2044074761")]
    [DisplayName("New Board Lot Securities Quantity")]
    [IsoXmlTag("NewBrdLotSctiesQty")]
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; init; }

    /// <summary>
    /// Specifies whether the shares are ranking for dividend or pari passu.
    /// </summary>
    [IsoId("_UHfX1dp-Ed-ak6NoX_4Aeg_-50486663")]
    [DisplayName("Share Ranking")]
    [IsoXmlTag("ShrRnkg")]
    public ShareRanking1FormatChoice_? ShareRanking { get; init; }

    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_UHfX1tp-Ed-ak6NoX_4Aeg_-2022112054")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public QuantityToQuantityRatio1? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Provides information about the dates related to a securities movement.
    /// </summary>
    [IsoId("_UHfX19p-Ed-ak6NoX_4Aeg_-1191886959")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate3? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a securities movement.
    /// </summary>
    [IsoId("_UHfX2Np-Ed-ak6NoX_4Aeg_-96835735")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice4? PriceDetails { get; init; }

    /// <summary>
    /// Period during which intermediate securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_UHfX2dp-Ed-ak6NoX_4Aeg_-1841572303")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period1? TradingPeriod { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, eg, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_UHohwNp-Ed-ak6NoX_4Aeg_-2022112115")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public QuantityToQuantityRatio1? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Specifies that the security is a temporary security.
    /// </summary>
    [IsoId("_UHohwdp-Ed-ak6NoX_4Aeg_-1246757948")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_UHohwtp-Ed-ak6NoX_4Aeg_-470689710")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; init; }
}
