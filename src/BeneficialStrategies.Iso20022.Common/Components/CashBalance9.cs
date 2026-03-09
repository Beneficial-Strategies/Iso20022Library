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
[IsoId("_ylymkZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalance9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalance9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalance9( BalanceCounterparty1Code reqCounterpartyType )
    {
        CounterpartyType = reqCounterpartyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_yttMZ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceType8Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType8Choice_? Type { get; init; } 
    #else
    public BalanceType8Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of counterparty for which the balance is calculated.
    /// </summary>
    [IsoId("_yttMaZlcEeeE1Ya-LgRsuQ")]
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
    [IsoId("_yttMa5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? CounterpartyIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_yttMbZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch3Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch3Choice_? ValueDate { get; init; } 
    #else
    public DateAndDateTimeSearch3Choice_? ValueDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
