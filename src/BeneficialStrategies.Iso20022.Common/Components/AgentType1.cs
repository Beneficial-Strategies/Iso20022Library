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
/// Identifies one or more agents involved in a transaction, with their role.
/// </summary>
[IsoId("_4zG7sKHHEeagRbKvRt3LnA")]
[DisplayName("Agent Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgentType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentType1( PaymentsPartyType1Code reqRole )
    {
        Role = reqRole;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_Wf_bUaHIEeagRbKvRt3LnA")]
    [DisplayName("Any BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnyBIC")]
    #endif
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public SimpleValueList<System.String> AnyBIC { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Wf_bUaHIEeagRbKvRt3LnA
    
    /// <summary>
    /// Specifies the role of the party in the payment chain.
    /// </summary>
    [IsoId("_pNVEMKHIEeagRbKvRt3LnA")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentsPartyType1Code Role { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentsPartyType1Code Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentsPartyType1Code Role { get; init; } 
    #else
    public PaymentsPartyType1Code Role { get; set; } 
    #endif
    
    
    #nullable disable
    
}
