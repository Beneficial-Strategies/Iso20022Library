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
[IsoId("_7JKuIecXEei5aPS232E3Mw")]
[DisplayName("Account Balance SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountBalanceSD14
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
    [IsoId("_7xerUecXEei5aPS232E3Mw")]
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
    [IsoId("_7xerU-cXEei5aPS232E3Mw")]
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
    /// Portion of the original balance position held in DTC general free account as of day prior to publication date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_7xerVecXEei5aPS232E3Mw")]
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
    /// Portion of the original balance position held in DTC segregated account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_7xerV-cXEei5aPS232E3Mw")]
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
    /// Portion of the original balance position held in DTC investment account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_7xerWecXEei5aPS232E3Mw")]
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
    
    /// <summary>
    /// For rights subscription events, total number of oversubscribed units applicable to the payment or the subscription charge.
    /// </summary>
    [IsoId("_7xerX-cXEei5aPS232E3Mw")]
    [DisplayName("Oversubscription Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptBal")]
    #endif
    [IsoXmlTag("OvrsbcptBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? OversubscriptionBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
