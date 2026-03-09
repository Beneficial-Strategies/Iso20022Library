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
[IsoId("_doTs95EhEeajS_7NioJdVA")]
[DisplayName("Account Balance SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountBalanceSD8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountBalanceSD8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountBalanceSD8( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_doTs-ZEhEeajS_7NioJdVA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of all uncovered protect instructions across all options.
    /// </summary>
    [IsoId("_doTs-pEhEeajS_7NioJdVA")]
    [DisplayName("Uncovered Protect Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UcvrdPrtctBal")]
    #endif
    [IsoXmlTag("UcvrdPrtctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? UncoveredProtectBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? UncoveredProtectBalance { get; init; } 
    #else
    public SignedQuantityFormat9? UncoveredProtectBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position held in DTC segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_doTs_ZEhEeajS_7NioJdVA")]
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
    /// Position held in DTC segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_doTs-JEhEeajS_7NioJdVA")]
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
    /// Position held in DTC memo segregated account. This position is eligible for payment.
    /// </summary>
    [IsoId("_doTs-5EhEeajS_7NioJdVA")]
    [DisplayName("Memo Segregation Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MemoSgrtnBal")]
    #endif
    [IsoXmlTag("MemoSgrtnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    #else
    public SignedQuantityFormat9? MemoSegregationBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
