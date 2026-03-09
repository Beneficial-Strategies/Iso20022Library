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
/// Provides the details of the collateral used in the transaction.
/// </summary>
[IsoId("_QMn0QcguEeuGrNSsxk3B0A")]
[DisplayName("Collateral Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralData33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_QOdAQ8guEeuGrNSsxk3B0A")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXpsrCollstnInd")]
    #endif
    [IsoXmlTag("NetXpsrCollstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NetExposureCollateralisationIndicator { get; init; } 
    #else
    public System.String? NetExposureCollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_QOdARcguEeuGrNSsxk3B0A")]
    [DisplayName("Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpntTp")]
    #endif
    [IsoXmlTag("CmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType6Code? ComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType6Code? ComponentType { get; init; } 
    #else
    public CollateralType6Code? ComponentType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of unit of cash collateral component.
    /// </summary>
    [IsoId("_QOdAR8guEeuGrNSsxk3B0A")]
    [DisplayName("Cash Collateral Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCollCcy")]
    #endif
    [IsoXmlTag("CshCollCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? CashCollateralCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CashCollateralCurrency { get; init; } 
    #else
    public string? CashCollateralCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of price of unit of collateral component.
    /// </summary>
    [IsoId("_QOdAScguEeuGrNSsxk3B0A")]
    [DisplayName("Price Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricCcy")]
    #endif
    [IsoXmlTag("PricCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? PriceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PriceCurrency { get; init; } 
    #else
    public string? PriceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    [IsoId("_QOdAS8guEeuGrNSsxk3B0A")]
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
    /// Maturity of the security.
    /// </summary>
    [IsoId("_QOdATcguEeuGrNSsxk3B0A")]
    [DisplayName("Maturity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtrty")]
    #endif
    [IsoXmlTag("Mtrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractTerm6Choice_? Maturity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractTerm6Choice_? Maturity { get; init; } 
    #else
    public ContractTerm6Choice_? Maturity { get; set; } 
    #endif
    
    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. 
    /// </summary>
    [IsoId("_QOdAT8guEeuGrNSsxk3B0A")]
    [DisplayName("Issuer Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrJursdctn")]
    #endif
    [IsoXmlTag("IssrJursdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IssuerJurisdiction1Choice_? IssuerJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerJurisdiction1Choice_? IssuerJurisdiction { get; init; } 
    #else
    public IssuerJurisdiction1Choice_? IssuerJurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    [IsoId("_QOdAUcguEeuGrNSsxk3B0A")]
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
    /// Trade Repository to which the other counterparty reported.
    /// </summary>
    [IsoId("_QOdAU8guEeuGrNSsxk3B0A")]
    [DisplayName("Trade Repository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRpstry")]
    #endif
    [IsoXmlTag("TradRpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? TradeRepository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? TradeRepository { get; init; } 
    #else
    public OrganisationIdentification15Choice_? TradeRepository { get; set; } 
    #endif
    
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_QOdAVcguEeuGrNSsxk3B0A")]
    [DisplayName("Reconciliation Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnFlg")]
    #endif
    [IsoXmlTag("RcncltnFlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    #else
    public ReconciliationFlag2? ReconciliationFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the type and amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_QOdAV8guEeuGrNSsxk3B0A")]
    [DisplayName("Reinvested Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstdCsh")]
    #endif
    [IsoXmlTag("RinvstdCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReinvestedCashTypeAndAmount2? ReinvestedCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReinvestedCashTypeAndAmount2? ReinvestedCash { get; init; } 
    #else
    public ReinvestedCashTypeAndAmount2? ReinvestedCash { get; set; } 
    #endif
    
    
    #nullable disable
    
}
