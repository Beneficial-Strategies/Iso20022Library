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
/// Investor’s investment requirements.
/// </summary>
[IsoId("_BNvksDcZEeidBoT_PugKiA")]
[DisplayName("Investor Requirements")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestorRequirements1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for the preservation of capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05010. In EMT v2, this is known as Return Profile Client Looking for Preservation.
    /// </summary>
    [IsoId("_L8owUDcZEeidBoT_PugKiA")]
    [DisplayName("Return Profile Preservation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflPrsrvtn")]
    #endif
    [IsoXmlTag("RtrPrflPrsrvtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfilePreservation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfilePreservation { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfilePreservation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is compatible with a client looking for capitalisation growth.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05020. In EMT v2, this is known as Return Profile Client Looking for Capitalized Growth.
    /// </summary>
    [IsoId("_3N8BwDcaEeidBoT_PugKiA")]
    [DisplayName("Return Profile Growth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflGrwth")]
    #endif
    [IsoXmlTag("RtrPrflGrwth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfileGrowth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfileGrowth { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfileGrowth { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for income. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05030. In EMT v2, this is known as Return Profile Client Looking for Income.
    /// </summary>
    [IsoId("_8iVTkDcaEeidBoT_PugKiA")]
    [DisplayName("Return Profile Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflIncm")]
    #endif
    [IsoXmlTag("RtrPrflIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfileIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfileIncome { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfileIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with the hedging profile of a structured security product.
    /// In EMT v2, this element is not supported for funds. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05040. In EMT v2, this element is not supported for funds.
    /// </summary>
    [IsoId("_5m4dEIvzEeicrr-UkGlMQA")]
    [DisplayName("Return Profile Hedging")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflHdgg")]
    #endif
    [IsoXmlTag("RtrPrflHdgg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfileHedging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfileHedging { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfileHedging { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with the option or leveraged return profile of a structured security product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05050. In EMT v2, this element is not supported for funds.
    /// </summary>
    [IsoId("_MhcpoIv0Eeicrr-UkGlMQA")]
    [DisplayName("Option Or Leveraged Return Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnOrLvrgdRtrPrfl")]
    #endif
    [IsoXmlTag("OptnOrLvrgdRtrPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; } 
    #else
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with ‘another return’ profile of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05060.
    /// </summary>
    [IsoId("_MpHw8DcbEeidBoT_PugKiA")]
    [DisplayName("Return Profile Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflOthr")]
    #endif
    [IsoXmlTag("RtrPrflOthr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket2Code? ReturnProfileOther { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket2Code? ReturnProfileOther { get; init; } 
    #else
    public TargetMarket2Code? ReturnProfileOther { get; set; } 
    #endif
    
    /// <summary>
    /// Level of compatibility of the investor risk profile with the Return Profile Pension Scheme Germany profile of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05070.
    /// </summary>
    [IsoId("_R1DqUDcbEeidBoT_PugKiA")]
    [DisplayName("Return Profile Pension Scheme Germany")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrPrflPnsnSchmeDE")]
    #endif
    [IsoXmlTag("RtrPrflPnsnSchmeDE")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; } 
    #else
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum recommended holding period (RHP).
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05080. In EMT v1, this is known as Time Horizon.
    /// </summary>
    [IsoId("_WYjqsDcbEeidBoT_PugKiA")]
    [DisplayName("Minimum Holding Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinHldgPrd")]
    #endif
    [IsoXmlTag("MinHldgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeHorizon1Choice_? MinimumHoldingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeHorizon1Choice_? MinimumHoldingPeriod { get; init; } 
    #else
    public TimeHorizon1Choice_? MinimumHoldingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the product may be terminated early. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05100.
    /// </summary>
    [IsoId("_Zm1AAIs6EeiLhuH9WH7MLg")]
    [DisplayName("May Be Terminated Early")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MayBeTermntdEarly")]
    #endif
    [IsoXmlTag("MayBeTermntdEarly")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1Code? MayBeTerminatedEarly { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1Code? MayBeTerminatedEarly { get; init; } 
    #else
    public TargetMarket1Code? MayBeTerminatedEarly { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies specific indicative investment needs. Should be discussed and agreed between the asset manager and bank. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05110.
    /// </summary>
    [IsoId("_CQQ00DcdEeidBoT_PugKiA")]
    [DisplayName("Specific Investment Need")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpcfcInvstmtNeed")]
    #endif
    [IsoXmlTag("SpcfcInvstmtNeed")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentNeed1Choice_? SpecificInvestmentNeed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentNeed1Choice_? SpecificInvestmentNeed { get; init; } 
    #else
    public InvestmentNeed1Choice_? SpecificInvestmentNeed { get; set; } 
    #endif
    
    /// <summary>
    /// Other investment need. 
    /// </summary>
    [IsoId("_EcKPMDceEeidBoT_PugKiA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherInvestmentNeed1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherInvestmentNeed1? Other { get; init; } 
    #else
    public OtherInvestmentNeed1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
