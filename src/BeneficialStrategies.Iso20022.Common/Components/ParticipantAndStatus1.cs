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
/// Provides details on the participant and their operational status.
/// </summary>
[IsoId("_Odl2BdNSEeWCqoSJYcWUsg")]
[DisplayName("Participant And Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ParticipantAndStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ParticipantAndStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ParticipantAndStatus1( FinancialInstitutionIdentification13 reqParticipantIdentification )
    {
        ParticipantIdentification = reqParticipantIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of participant.
    /// </summary>
    [IsoId("_Odl2B9NSEeWCqoSJYcWUsg")]
    [DisplayName("Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptId")]
    #endif
    [IsoXmlTag("PtcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification13 ParticipantIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification13 ParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification13 ParticipantIdentification { get; init; } 
    #else
    public FinancialInstitutionIdentification13 ParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to indicate how to contact the participant.
    /// </summary>
    [IsoId("_Odl2BtNSEeWCqoSJYcWUsg")]
    [DisplayName("Participant Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptCtctDtls")]
    #endif
    [IsoXmlTag("PtcptCtctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactDetails2? ParticipantContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactDetails2? ParticipantContactDetails { get; init; } 
    #else
    public ContactDetails2? ParticipantContactDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on operational availability of the participant business service.
    /// </summary>
    [IsoId("_Odl2CdNSEeWCqoSJYcWUsg")]
    [DisplayName("Service Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcAvlbty")]
    #endif
    [IsoXmlTag("SvcAvlbty")]
    public ValueList<ServiceAvailability1> ServiceAvailability { get; init; } = new ValueList<ServiceAvailability1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Odl2CdNSEeWCqoSJYcWUsg
    
    
    #nullable disable
    
}
