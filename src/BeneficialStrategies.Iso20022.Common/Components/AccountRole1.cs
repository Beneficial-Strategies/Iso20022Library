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
/// Specifies the party and owner type.
/// </summary>
[IsoId("_l5A6kC_9EeOKib24wnHaFg")]
[DisplayName("Account Role")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountRole1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountRole1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountRole1( PartyIdentification41 reqParty,OwnerType1 reqOwnerType )
    {
        Party = reqParty;
        OwnerType = reqOwnerType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account owner/user identification and contact information.
    /// </summary>
    [IsoId("_rnEpkC_9EeOKib24wnHaFg")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification41 Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification41 Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification41 Party { get; init; } 
    #else
    public PartyIdentification41 Party { get; set; } 
    #endif
    
    /// <summary>
    /// Defines account owners/users relation to the account.
    /// </summary>
    [IsoId("_BjRlsC__EeOKib24wnHaFg")]
    [DisplayName("Owner Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrTp")]
    #endif
    [IsoXmlTag("OwnrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OwnerType1 OwnerType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OwnerType1 OwnerType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OwnerType1 OwnerType { get; init; } 
    #else
    public OwnerType1 OwnerType { get; set; } 
    #endif
    
    /// <summary>
    /// Start date related to the role.
    /// </summary>
    [IsoId("_vT_nQC_9EeOKib24wnHaFg")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date related to the role.
    /// </summary>
    [IsoId("_1cJRQC_9EeOKib24wnHaFg")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
