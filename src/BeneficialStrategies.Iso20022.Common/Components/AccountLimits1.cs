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
/// Characteristics and values set for account limits.
/// </summary>
[IsoId("_M0i6YBwpEeaSw8_Cr7PTfA")]
[DisplayName("Account Limits")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountLimits1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountLimits1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountLimits1( System.String reqLimitType,ActiveCurrencyAndAmount reqLimitAmount )
    {
        LimitType = reqLimitType;
        LimitAmount = reqLimitAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines type of funds limits.
    /// </summary>
    [IsoId("_1mqMkBwqEeaSw8_Cr7PTfA")]
    [DisplayName("Limit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtTp")]
    #endif
    [IsoXmlTag("LmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LimitType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LimitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LimitType { get; init; } 
    #else
    public System.String LimitType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money of the limit.
    /// </summary>
    [IsoId("_sT1O8BwtEeaSw8_Cr7PTfA")]
    [DisplayName("Limit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtAmt")]
    #endif
    [IsoXmlTag("LmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount LimitAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount LimitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount LimitAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount LimitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of used funds out of defined limit.
    /// </summary>
    [IsoId("_AwVvYBwuEeaSw8_Cr7PTfA")]
    [DisplayName("Limit Utilisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtUtlstnAmt")]
    #endif
    [IsoXmlTag("LmtUtlstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? LimitUtilisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? LimitUtilisationAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? LimitUtilisationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_l8WTABwuEeaSw8_Cr7PTfA")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilLmtCtrPtyId")]
    #endif
    [IsoXmlTag("BilLmtCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing scheme related to Registry of the Clearing Positions (RCP).
    /// </summary>
    [IsoId("_V6qioBwvEeaSw8_Cr7PTfA")]
    [DisplayName("Clearing Circuit Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCrctSchme")]
    #endif
    [IsoXmlTag("ClrCrctSchme")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingScheme1Choice_? ClearingCircuitScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingScheme1Choice_? ClearingCircuitScheme { get; init; } 
    #else
    public ClearingScheme1Choice_? ClearingCircuitScheme { get; set; } 
    #endif
    
    
    #nullable disable
    
}
