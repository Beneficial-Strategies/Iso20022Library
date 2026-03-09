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
/// Provides the details on the margin report per margin account, and optionally per non-clearing member.
/// </summary>
[IsoId("_-eDlF6MOEeCojJW5vEuTEQ_-651188683")]
[DisplayName("Margin Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginReport2( SecuritiesAccount18 reqMarginAccount )
    {
        MarginAccount = reqMarginAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies if the margin is related to equities or fixed income.
    /// </summary>
    [IsoId("_-eDlGKMOEeCojJW5vEuTEQ_1535794841")]
    [DisplayName("Margin Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnPdct")]
    #endif
    [IsoXmlTag("MrgnPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginProductType1Choice_? MarginProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginProductType1Choice_? MarginProduct { get; init; } 
    #else
    public MarginProductType1Choice_? MarginProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the clearing member&apos;s account.
    /// </summary>
    [IsoId("_-eDlGaMOEeCojJW5vEuTEQ_-765027749")]
    [DisplayName("Margin Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnAcct")]
    #endif
    [IsoXmlTag("MrgnAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount18 MarginAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount18 MarginAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount18 MarginAccount { get; init; } 
    #else
    public SecuritiesAccount18 MarginAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Used to indicate whether the reported margin account is collateralised or not. If not collateralised, the account is configured for informational reporting.
    /// </summary>
    [IsoId("_-eMvAKMOEeCojJW5vEuTEQ_1274385428")]
    [DisplayName("Collateralised Margin Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollsdMrgnAcctInd")]
    #endif
    [IsoXmlTag("CollsdMrgnAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CollateralisedMarginAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralisedMarginAccountIndicator { get; init; } 
    #else
    public System.String? CollateralisedMarginAccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_-eMvAaMOEeCojJW5vEuTEQ_-1762100102")]
    [DisplayName("Non Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrMmb")]
    #endif
    [IsoXmlTag("NonClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #else
    public PartyIdentificationAndAccount31? NonClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the margin calculation summary per margin account.
    /// </summary>
    [IsoId("_-eMvAqMOEeCojJW5vEuTEQ_-403792512")]
    [DisplayName("Margin Calculation Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnClctnSummry")]
    #endif
    [IsoXmlTag("MrgnClctnSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCalculation1? MarginCalculationSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCalculation1? MarginCalculationSummary { get; init; } 
    #else
    public MarginCalculation1? MarginCalculationSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the margin details such as the exposure amount and the initial margin.
    /// </summary>
    [IsoId("_-eMvA6MOEeCojJW5vEuTEQ_538722488")]
    [DisplayName("Margin Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnClctn")]
    #endif
    [IsoXmlTag("MrgnClctn")]
    public ValueList<MarginCalculation2> MarginCalculation { get; init; } = new ValueList<MarginCalculation2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-eMvA6MOEeCojJW5vEuTEQ_538722488
    
    
    #nullable disable
    
}
