// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to securities being subject to the transaction.
/// </summary>
[IsoId("_Nqo-scg5Eeu4ecZgAYuz5w")]
[DisplayName("Security")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Security55
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the security subject of the transaction.
    /// </summary>
    [IsoId("_NsTyo8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_NsTypcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassificationType { get; init; } 
    #else
    public System.String? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity or nominal amount of the security or commodity subject of the transaction.
    /// </summary>
    [IsoId("_NsTyp8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Quantity Or Nominal Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyOrNmnlVal")]
    #endif
    [IsoXmlTag("QtyOrNmnlVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; } 
    #else
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; set; } 
    #endif
    
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
    /// </summary>
    [IsoId("_NsTyqcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    #else
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_NsTyq8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? MarketValue { get; init; } 
    #else
    public AmountAndDirection53? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    [IsoId("_NsTyrcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Quality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qlty")]
    #endif
    [IsoXmlTag("Qlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralQualityType1Code? Quality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralQualityType1Code? Quality { get; init; } 
    #else
    public CollateralQualityType1Code? Quality { get; set; } 
    #endif
    
    /// <summary>
    /// Maturity date of the security.
    /// </summary>
    [IsoId("_NsTyr8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Maturity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtrty")]
    #endif
    [IsoXmlTag("Mtrty")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Maturity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Maturity { get; init; } 
    #else
    public System.DateOnly? Maturity { get; set; } 
    #endif
    
    /// <summary>
    /// Data on the securities issuer.
    /// </summary>
    [IsoId("_NsTyscg5Eeu4ecZgAYuz5w")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIssuer4? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIssuer4? Issuer { get; init; } 
    #else
    public SecurityIssuer4? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    [IsoId("_NsTys8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesLendingType3Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesLendingType3Choice_? Type { get; init; } 
    #else
    public SecuritiesLendingType3Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the borrower has exclusive access to borrow from the lender&apos;s securities portfolio.
    /// </summary>
    [IsoId("_NsTytcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Exclusive Arrangement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExclsvArrgmnt")]
    #endif
    [IsoXmlTag("ExclsvArrgmnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ExclusiveArrangement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExclusiveArrangement { get; init; } 
    #else
    public System.String? ExclusiveArrangement { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the collateral taker can reuse the securities provided as a collateral.
    /// </summary>
    [IsoId("_NsTyt8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Available For Collateral Reuse")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblForCollReuse")]
    #endif
    [IsoXmlTag("AvlblForCollReuse")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AvailableForCollateralReuse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AvailableForCollateralReuse { get; init; } 
    #else
    public System.String? AvailableForCollateralReuse { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_NsTyucg5Eeu4ecZgAYuz5w")]
    [DisplayName("Haircut Or Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HrcutOrMrgn")]
    #endif
    [IsoXmlTag("HrcutOrMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? HaircutOrMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? HaircutOrMargin { get; init; } 
    #else
    public System.Decimal? HaircutOrMargin { get; set; } 
    #endif
    
    
    #nullable disable
    
}
