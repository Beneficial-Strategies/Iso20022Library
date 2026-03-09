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
/// Lock status of the party for processing in the system. 
/// </summary>
[IsoId("_JfSv1mjMEeiRg5NzP0jkQg")]
[DisplayName("Party Lock Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyLockStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyLockStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyLockStatus1( LockStatus1Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the date from which the lock status is valid.
    /// </summary>
    [IsoId("_WiPMQGjNEeiRg5NzP0jkQg")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidFrom { get; init; } 
    #else
    public System.DateOnly? ValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Lock status of the party.
    /// </summary>
    [IsoId("_JfT982jMEeiRg5NzP0jkQg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LockStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LockStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LockStatus1Code Status { get; init; } 
    #else
    public LockStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying reason for the locking of the party.
    /// </summary>
    [IsoId("_JfT99GjMEeiRg5NzP0jkQg")]
    [DisplayName("Lock Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LckRsn")]
    #endif
    [IsoXmlTag("LckRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LockReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LockReason { get; init; } 
    #else
    public System.String? LockReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
