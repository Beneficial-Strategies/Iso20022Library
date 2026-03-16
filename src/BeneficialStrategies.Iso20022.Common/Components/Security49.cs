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
[IsoId("_F9siIcguEeuGrNSsxk3B0A")]
[DisplayName("Security")]
public record Security49
{
    /// <summary>
    /// Identifier of the security subject of the transaction.
    /// </summary>
    [IsoId("_F_GQUcguEeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Identification { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_F_GQU8guEeuGrNSsxk3B0A")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationType { get; init; }

    /// <summary>
    /// Quantity or nominal amount of the security or commodity subject of the transaction.
    /// </summary>
    [IsoId("_F_GQVcguEeuGrNSsxk3B0A")]
    [DisplayName("Quantity Or Nominal Value")]
    [IsoXmlTag("QtyOrNmnlVal")]
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; }

    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
    /// </summary>
    [IsoId("_F_GQV8guEeuGrNSsxk3B0A")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; }

    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_F_GQWcguEeuGrNSsxk3B0A")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public AmountAndDirection53? MarketValue { get; init; }

    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    [IsoId("_F_GQW8guEeuGrNSsxk3B0A")]
    [DisplayName("Quality")]
    [IsoXmlTag("Qlty")]
    public CollateralQualityType1Code? Quality { get; init; }

    /// <summary>
    /// Maturity date of the security.
    /// </summary>
    [IsoId("_F_GQXcguEeuGrNSsxk3B0A")]
    [DisplayName("Maturity")]
    [IsoXmlTag("Mtrty")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Maturity { get; init; }

    /// <summary>
    /// Data on the securities issuer.
    /// </summary>
    [IsoId("_F_G3YcguEeuGrNSsxk3B0A")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public SecurityIssuer4? Issuer { get; init; }

    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    [IsoId("_F_G3Y8guEeuGrNSsxk3B0A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<SecuritiesLendingType3Choice_> Type { get; init; } = [];

    /// <summary>
    /// Indication whether the borrower has exclusive access to borrow from the lender&apos;s securities portfolio.
    /// </summary>
    [IsoId("_F_G3ZcguEeuGrNSsxk3B0A")]
    [DisplayName("Exclusive Arrangement")]
    [IsoXmlTag("ExclsvArrgmnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExclusiveArrangement { get; init; }
}
