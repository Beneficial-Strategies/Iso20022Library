// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to securities being subject to the transaction.
/// </summary>
[IsoId("_rpXycdLvEem1A4OOmCK97A")]
[DisplayName("Security")]
public record Security16
{
    /// <summary>
    /// Identifier of the security subject of the transaction.
    /// </summary>
    [IsoId("_rt67QdLvEem1A4OOmCK97A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Identification { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_rt67Q9LvEem1A4OOmCK97A")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationType { get; init; }

    /// <summary>
    /// Quantity or nominal amount of the security or commodity subject of the transaction.
    /// </summary>
    [IsoId("_rt67RdLvEem1A4OOmCK97A")]
    [DisplayName("Quantity Or Nominal Value")]
    [IsoXmlTag("QtyOrNmnlVal")]
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; }

    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
    /// </summary>
    [IsoId("_rt67R9LvEem1A4OOmCK97A")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; }

    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_rt67SdLvEem1A4OOmCK97A")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    [IsoId("_rt67S9LvEem1A4OOmCK97A")]
    [DisplayName("Quality")]
    [IsoXmlTag("Qlty")]
    public CollateralQualityType1Code? Quality { get; init; }

    /// <summary>
    /// Maturity of the security.
    /// </summary>
    [IsoId("_rt67TdLvEem1A4OOmCK97A")]
    [DisplayName("Maturity")]
    [IsoXmlTag("Mtrty")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Maturity { get; init; }

    /// <summary>
    /// Data on the securities issuer.
    /// </summary>
    [IsoId("_rt67T9LvEem1A4OOmCK97A")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public SecurityIssuer2? Issuer { get; init; }

    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    [IsoId("_rt67UdLvEem1A4OOmCK97A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SecuritiesLendingType3Choice_? Type { get; init; }

    /// <summary>
    /// Indication whether the borrower has exclusive access to borrow from the lender&apos;s securities portfolio.
    /// </summary>
    [IsoId("_rt67U9LvEem1A4OOmCK97A")]
    [DisplayName("Exclusive Arrangement")]
    [IsoXmlTag("ExclsvArrgmnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExclusiveArrangement { get; init; }

    /// <summary>
    /// Indication whether the collateral taker can reuse the securities provided as a collateral.
    /// </summary>
    [IsoId("_rt67VdLvEem1A4OOmCK97A")]
    [DisplayName("Available For Collateral Reuse")]
    [IsoXmlTag("AvlblForCollReuse")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AvailableForCollateralReuse { get; init; }

    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_rt67V9LvEem1A4OOmCK97A")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HaircutOrMargin { get; init; }
}
