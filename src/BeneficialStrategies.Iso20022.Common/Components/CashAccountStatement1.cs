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
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[IsoId("_k2l3kO5NEeCisYr99QEiWA_-1812697527")]
[DisplayName("Cash Account Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountStatement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccountStatement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccountStatement1( System.DateOnly reqSystemDate )
    {
        SystemDate = reqSystemDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_k2l3ke5NEeCisYr99QEiWA_1470807263")]
    [DisplayName("System Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysDt")]
    #endif
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SystemDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SystemDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SystemDate { get; init; } 
    #else
    public System.DateOnly SystemDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the actual change occurred to the cash account.
    /// </summary>
    [IsoId("_k2l3ku5NEeCisYr99QEiWA_1400190648")]
    [DisplayName("Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chng")]
    #endif
    [IsoXmlTag("Chng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountReferenceDataChange1? Change { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountReferenceDataChange1? Change { get; init; } 
    #else
    public CashAccountReferenceDataChange1? Change { get; set; } 
    #endif
    
    
    #nullable disable
    
}
