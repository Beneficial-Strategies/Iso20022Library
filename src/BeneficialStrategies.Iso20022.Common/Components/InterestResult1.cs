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
/// Consideration, such as amount of money, paid or received in exchange for an amount of money that has been invested, loaned or borrowed for a certain period.
/// </summary>
[IsoId("_SQuqh9p-Ed-ak6NoX_4Aeg_1199217791")]
[DisplayName("Interest Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestResult1( System.DateOnly reqValueDate,InterestMethod1Code reqInterestMethod,CollateralBalance1 reqClosingCollateralBalance )
    {
        ValueDate = reqValueDate;
        InterestMethod = reqInterestMethod;
        ClosingCollateralBalance = reqClosingCollateralBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SQuqiNp-Ed-ak6NoX_4Aeg_522608502")]
    [DisplayName("Interest Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstDueToA")]
    #endif
    [IsoXmlTag("IntrstDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? InterestDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? InterestDueToA { get; init; } 
    #else
    public ActiveCurrencyAndAmount? InterestDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SQuqidp-Ed-ak6NoX_4Aeg_-1725036483")]
    [DisplayName("Interest Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstDueToB")]
    #endif
    [IsoXmlTag("IntrstDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? InterestDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? InterestDueToB { get; init; } 
    #else
    public ActiveCurrencyAndAmount? InterestDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    [IsoId("_SQ30cNp-Ed-ak6NoX_4Aeg_-608633204")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValueDate { get; init; } 
    #else
    public System.DateOnly ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    [IsoId("_SQ30cdp-Ed-ak6NoX_4Aeg_-1148128675")]
    [DisplayName("Interest Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstMtd")]
    #endif
    [IsoXmlTag("IntrstMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestMethod1Code InterestMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestMethod1Code InterestMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestMethod1Code InterestMethod { get; init; } 
    #else
    public InterestMethod1Code InterestMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    [IsoId("_SQ30ctp-Ed-ak6NoX_4Aeg_1341206546")]
    [DisplayName("Opening Collateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngCollBal")]
    #endif
    [IsoXmlTag("OpngCollBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    #else
    public CollateralBalance1? OpeningCollateralBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    [IsoId("_SQ30c9p-Ed-ak6NoX_4Aeg_-74786941")]
    [DisplayName("Closing Collateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgCollBal")]
    #endif
    [IsoXmlTag("ClsgCollBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralBalance1 ClosingCollateralBalance { get; init; } 
    #else
    public CollateralBalance1 ClosingCollateralBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
