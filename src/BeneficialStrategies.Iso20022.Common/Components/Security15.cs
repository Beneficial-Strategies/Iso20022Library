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
[IsoId("_MXso6c1VEem4K5qLxnWwMA")]
[DisplayName("Security")]
public record Security15
{
    /// <summary>
    /// Identifier of the security subject of the transaction.
    /// </summary>
    [IsoId("_MeGL0c1VEem4K5qLxnWwMA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Identification { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_MeGL081VEem4K5qLxnWwMA")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationType { get; init; }

    /// <summary>
    /// Quantity or nominal amount of the security or commodity subject of the transaction.
    /// </summary>
    [IsoId("_MeGL1c1VEem4K5qLxnWwMA")]
    [DisplayName("Quantity Or Nominal Value")]
    [IsoXmlTag("QtyOrNmnlVal")]
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; }

    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
    /// </summary>
    [IsoId("_MeGL181VEem4K5qLxnWwMA")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; }

    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_MeGL2c1VEem4K5qLxnWwMA")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    [IsoId("_MeGL281VEem4K5qLxnWwMA")]
    [DisplayName("Quality")]
    [IsoXmlTag("Qlty")]
    public CollateralQualityType1Code? Quality { get; init; }

    /// <summary>
    /// Maturity of the security.
    /// </summary>
    [IsoId("_MeGL3c1VEem4K5qLxnWwMA")]
    [DisplayName("Maturity")]
    [IsoXmlTag("Mtrty")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Maturity { get; init; }

    /// <summary>
    /// Data on the securities issuer.
    /// </summary>
    [IsoId("_MeGL381VEem4K5qLxnWwMA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public SecurityIssuer2? Issuer { get; init; }

    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    [IsoId("_MeGL4c1VEem4K5qLxnWwMA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<SecuritiesLendingType3Choice_> Type { get; init; } = [];

    /// <summary>
    /// Indication whether the borrower has exclusive access to borrow from the lender&apos;s securities portfolio.
    /// </summary>
    [IsoId("_MeGL481VEem4K5qLxnWwMA")]
    [DisplayName("Exclusive Arrangement")]
    [IsoXmlTag("ExclsvArrgmnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExclusiveArrangement { get; init; }

    /// <summary>
    /// Indication whether the collateral taker can reuse the securities provided as a collateral.
    /// </summary>
    [IsoId("_MeGL581VEem4K5qLxnWwMA")]
    [DisplayName("Available For Collateral Reuse")]
    [IsoXmlTag("AvlblForCollReuse")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AvailableForCollateralReuse { get; init; }
}
