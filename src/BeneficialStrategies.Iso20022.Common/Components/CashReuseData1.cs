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
/// Provides details on the type and amount of the cash reinvestment in a given currency and on the cash reinvestment rate.
/// </summary>
[IsoId("_ANAEgI67EeaxxtxaoOwzAg")]
[DisplayName("Cash Reuse Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashReuseData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashReuseData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashReuseData1( System.Decimal reqCashReinvestmentRate )
    {
        CashReinvestmentRate = reqCashReinvestmentRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on the type and amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_P73YgJLiEeelrYORFsXWZg")]
    [DisplayName("Reinvested Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstdCsh")]
    #endif
    [IsoXmlTag("RinvstdCsh")]
    public ValueList<ReinvestedCashTypeAndAmount1> ReinvestedCash { get; init; } = new ValueList<ReinvestedCashTypeAndAmount1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _P73YgJLiEeelrYORFsXWZg
    
    /// <summary>
    /// Average interest rate received on cash collateral reinvestment by the lender for reinvestment of cash collateral.
    /// </summary>
    [IsoId("_AgOw8JLiEeelrYORFsXWZg")]
    [DisplayName("Cash Reinvestment Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshRinvstmtRate")]
    #endif
    [IsoXmlTag("CshRinvstmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate CashReinvestmentRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal CashReinvestmentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal CashReinvestmentRate { get; init; } 
    #else
    public System.Decimal CashReinvestmentRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
