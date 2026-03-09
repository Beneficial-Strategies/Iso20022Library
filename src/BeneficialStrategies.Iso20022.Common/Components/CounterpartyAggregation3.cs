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
/// Specifies the valuation details per counterparty aggregation.
/// </summary>
[IsoId("_SZLjaSs_EeySlt9bF77XfA")]
[DisplayName("Counterparty Aggregation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyAggregation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyAggregation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyAggregation3( CollateralParties11 reqCollateralParties )
    {
        CollateralParties = reqCollateralParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_SwlWxSs_EeySlt9bF77XfA")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType6Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType6Choice_? OptionType { get; init; } 
    #else
    public OptionType6Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    [IsoId("_SwlWxys_EeySlt9bF77XfA")]
    [DisplayName("Termination Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnOptn")]
    #endif
    [IsoXmlTag("TermntnOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    #else
    public RepoTerminationOption1Code? TerminationOption { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the baskets identification and the Eligiblity Set Profile.
    /// </summary>
    [IsoId("_SwlWySs_EeySlt9bF77XfA")]
    [DisplayName("Basket Identification And Eligibility Set Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktIdAndElgbltySetPrfl")]
    #endif
    [IsoXmlTag("BsktIdAndElgbltySetPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; } 
    #else
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Provides  the identification of the party or parties associated with the collateral agreement
    /// </summary>
    [IsoId("_SwlWyys_EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPties")]
    #endif
    [IsoXmlTag("CollPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParties11 CollateralParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParties11 CollateralParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties11 CollateralParties { get; init; } 
    #else
    public CollateralParties11 CollateralParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_SwlWzSs_EeySlt9bF77XfA")]
    [DisplayName("Valuation Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnAmts")]
    #endif
    [IsoXmlTag("ValtnAmts")]
    public ValueList<CollateralAmount16> ValuationAmounts { get; init; } = new ValueList<CollateralAmount16>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SwlWzSs_EeySlt9bF77XfA
    
    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_SwlWzys_EeySlt9bF77XfA")]
    [DisplayName("Margin Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRate")]
    #endif
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MarginRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarginRate { get; init; } 
    #else
    public System.Decimal? MarginRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status after comparing the total collateral required and the total collateral value of all transactions against counterparty.
    /// </summary>
    [IsoId("_SwlW0Ss_EeySlt9bF77XfA")]
    [DisplayName("Global Counterparty Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GblCtrPtySts")]
    #endif
    [IsoXmlTag("GblCtrPtySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralStatus1Code? GlobalCounterpartyStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralStatus1Code? GlobalCounterpartyStatus { get; init; } 
    #else
    public CollateralStatus1Code? GlobalCounterpartyStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
