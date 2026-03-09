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
/// Provides information about the CA security option.
/// </summary>
[IsoId("_UHVm2dp-Ed-ak6NoX_4Aeg_-583360205")]
[DisplayName("Security Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityOption1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityOption1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityOption1( FinancialInstrumentDescription3 reqSecurityIdentification,CreditDebitCode reqCreditDebitIndicator )
    {
        SecurityIdentification = reqSecurityIdentification;
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UHVm2tp-Ed-ak6NoX_4Aeg_-527946931")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentDescription3 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentDescription3 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentDescription3 SecurityIdentification { get; init; } 
    #else
    public FinancialInstrumentDescription3 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_UHVm29p-Ed-ak6NoX_4Aeg_-564889355")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_UHfX0Np-Ed-ak6NoX_4Aeg_-454066333")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? SecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_UHfX0dp-Ed-ak6NoX_4Aeg_-121597685")]
    [DisplayName("Minimum Exercisable Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblSctiesQty")]
    #endif
    [IsoXmlTag("MinExrcblSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_UHfX0tp-Ed-ak6NoX_4Aeg_-81886522")]
    [DisplayName("Minimum Exercisable Multiple Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblMltplSctiesQty")]
    #endif
    [IsoXmlTag("MinExrcblMltplSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// New denomination of the financial instrument following, eg, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_UHfX09p-Ed-ak6NoX_4Aeg_2044074483")]
    [DisplayName("New Denomination Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDnmtnSctiesQty")]
    #endif
    [IsoXmlTag("NewDnmtnSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_UHfX1Np-Ed-ak6NoX_4Aeg_2044074761")]
    [DisplayName("New Board Lot Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBrdLotSctiesQty")]
    #endif
    [IsoXmlTag("NewBrdLotSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the shares are ranking for dividend or pari passu.
    /// </summary>
    [IsoId("_UHfX1dp-Ed-ak6NoX_4Aeg_-50486663")]
    [DisplayName("Share Ranking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrRnkg")]
    #endif
    [IsoXmlTag("ShrRnkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShareRanking1FormatChoice_? ShareRanking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShareRanking1FormatChoice_? ShareRanking { get; init; } 
    #else
    public ShareRanking1FormatChoice_? ShareRanking { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_UHfX1tp-Ed-ak6NoX_4Aeg_-2022112054")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForSbcbdRsltntScties")]
    #endif
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityToQuantityRatio1? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityToQuantityRatio1? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 
    #else
    public QuantityToQuantityRatio1? AdditionalQuantityForSubscribedResultantSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a securities movement.
    /// </summary>
    [IsoId("_UHfX19p-Ed-ak6NoX_4Aeg_-1191886959")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate3? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate3? DateDetails { get; init; } 
    #else
    public CorporateActionDate3? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a securities movement.
    /// </summary>
    [IsoId("_UHfX2Np-Ed-ak6NoX_4Aeg_-96835735")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice4? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice4? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice4? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which intermediate securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_UHfX2dp-Ed-ak6NoX_4Aeg_-1841572303")]
    [DisplayName("Trading Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPrd")]
    #endif
    [IsoXmlTag("TradgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? TradingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? TradingPeriod { get; init; } 
    #else
    public Period1? TradingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, eg, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_UHohwNp-Ed-ak6NoX_4Aeg_-2022112115")]
    [DisplayName("Additional Quantity For Existing Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlQtyForExstgScties")]
    #endif
    [IsoXmlTag("AddtlQtyForExstgScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityToQuantityRatio1? AdditionalQuantityForExistingSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityToQuantityRatio1? AdditionalQuantityForExistingSecurities { get; init; } 
    #else
    public QuantityToQuantityRatio1? AdditionalQuantityForExistingSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the security is a temporary security.
    /// </summary>
    [IsoId("_UHohwdp-Ed-ak6NoX_4Aeg_-1246757948")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempFinInstrmInd")]
    #endif
    [IsoXmlTag("TempFinInstrmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TemporaryFinancialInstrumentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TemporaryFinancialInstrumentIndicator { get; init; } 
    #else
    public System.String? TemporaryFinancialInstrumentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_UHohwtp-Ed-ak6NoX_4Aeg_-470689710")]
    [DisplayName("Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnDspstn")]
    #endif
    [IsoXmlTag("FrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; init; } 
    #else
    public FractionDispositionType1FormatChoice_? FractionDisposition { get; set; } 
    #endif
    
    
    #nullable disable
    
}
