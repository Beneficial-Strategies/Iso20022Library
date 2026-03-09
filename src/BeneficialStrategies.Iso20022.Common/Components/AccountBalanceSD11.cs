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
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_mlwo4b5YEeexmbB7KsjCwA")]
[DisplayName("Account Balance SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountBalanceSD11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_m1rUMb5YEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_m1rUM75YEeexmbB7KsjCwA")]
    [DisplayName("Original Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlBal")]
    #endif
    [IsoXmlTag("OrgnlBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    #else
    public SignedQuantityFormat9? OriginalBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Adjusted position held in a security that is subject to redemption call.
    /// </summary>
    [IsoId("_m1rUNb5YEeexmbB7KsjCwA")]
    [DisplayName("Adjusted Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdBal")]
    #endif
    [IsoXmlTag("AdjstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? AdjustedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? AdjustedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? AdjustedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_m1rUN75YEeexmbB7KsjCwA")]
    [DisplayName("Unpledged Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpldgdBal")]
    #endif
    [IsoXmlTag("UpldgdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? UnpledgedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_m1rUOb5YEeexmbB7KsjCwA")]
    [DisplayName("Investment Unpledged Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtUpldgdBal")]
    #endif
    [IsoXmlTag("InvstmtUpldgdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_m1rUO75YEeexmbB7KsjCwA")]
    [DisplayName("Investment Pledged Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtPldgdBal")]
    #endif
    [IsoXmlTag("InvstmtPldgdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
