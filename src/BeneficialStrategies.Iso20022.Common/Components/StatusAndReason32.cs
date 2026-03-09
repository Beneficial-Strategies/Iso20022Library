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
/// Status and reason of an instructed order.
/// </summary>
[IsoId("_VnSLYXAoEeaxWKxOD2aB-w")]
[DisplayName("Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusAndReason32
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusAndReason32 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusAndReason32( Status18Choice_ reqStatusAndReason )
    {
        StatusAndReason = reqStatusAndReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_V_1OQXAoEeaxWKxOD2aB-w")]
    [DisplayName("Status And Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsAndRsn")]
    #endif
    [IsoXmlTag("StsAndRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status18Choice_ StatusAndReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status18Choice_ StatusAndReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status18Choice_ StatusAndReason { get; init; } 
    #else
    public Status18Choice_ StatusAndReason { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    [IsoId("_V_1ORXAoEeaxWKxOD2aB-w")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Transaction54? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction54? Transaction { get; init; } 
    #else
    public Transaction54? Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
