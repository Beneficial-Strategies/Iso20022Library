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
/// Balance details for a cash account.
/// </summary>
[IsoId("_6nhacX3sEeibM9CPDGCw0g")]
[DisplayName("Cash Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalance12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalance12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalance12( BalanceCounterparty1Code reqCounterpartyType )
    {
        CounterpartyType = reqCounterpartyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_6yG5133sEeibM9CPDGCw0g")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceType11Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType11Choice_? Type { get; init; } 
    #else
    public BalanceType11Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_6yG52X3sEeibM9CPDGCw0g")]
    [DisplayName("Counterparty Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyTp")]
    #endif
    [IsoXmlTag("CtrPtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceCounterparty1Code CounterpartyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceCounterparty1Code CounterpartyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceCounterparty1Code CounterpartyType { get; init; } 
    #else
    public BalanceCounterparty1Code CounterpartyType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_6yG5233sEeibM9CPDGCw0g")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CounterpartyIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_6yG53X3sEeibM9CPDGCw0g")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch4Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch4Choice_? ValueDate { get; init; } 
    #else
    public DateAndDateTimeSearch4Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date or date time when the balance was last updated following an entry posted to the account, in the books of the account servicing institution.
    /// </summary>
    [IsoId("_HyosAbwWEeioUZ07TzVRmA")]
    [DisplayName("Processing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgDt")]
    #endif
    [IsoXmlTag("PrcgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch4Choice_? ProcessingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch4Choice_? ProcessingDate { get; init; } 
    #else
    public DateAndDateTimeSearch4Choice_? ProcessingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
