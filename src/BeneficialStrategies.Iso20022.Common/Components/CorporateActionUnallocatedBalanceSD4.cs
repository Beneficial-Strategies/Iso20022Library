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
/// Balance types related to an unallocated redemption payment.
/// </summary>
[IsoId("_npjhEcnxEee6kIhZjMqQ2Q")]
[DisplayName("Corporate Action Unallocated Balance SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedBalanceSD4
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
    [IsoId("_n69aIcnxEee6kIhZjMqQ2Q")]
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
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_n69aI8nxEee6kIhZjMqQ2Q")]
    [DisplayName("Total Eligible Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblBal")]
    #endif
    [IsoXmlTag("TtlElgblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalEligibleBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position held in DTC Segregated account. This position is ineligible for payment until released from pledgee.
    /// </summary>
    [IsoId("_n69aMcnxEee6kIhZjMqQ2Q")]
    [DisplayName("Pledged Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PldgdBal")]
    #endif
    [IsoXmlTag("PldgdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? PledgedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? PledgedBalance { get; init; } 
    #else
    public SignedQuantityFormat9? PledgedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position held in DTC Segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    [IsoId("_n69aM8nxEee6kIhZjMqQ2Q")]
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
    /// Position held in DTC Segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events. 
    /// </summary>
    [IsoId("_n69aNcnxEee6kIhZjMqQ2Q")]
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
    /// Position held in DTC Segregated account. This position is eligible for payment.
    /// </summary>
    [IsoId("_n69aN8nxEee6kIhZjMqQ2Q")]
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
