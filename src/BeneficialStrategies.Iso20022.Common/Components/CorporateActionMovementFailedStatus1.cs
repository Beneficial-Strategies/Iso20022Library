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
/// Provides information about the failure of the settlement of a movement.
/// </summary>
[IsoId("_Rjbfptp-Ed-ak6NoX_4Aeg_-659137401")]
[DisplayName("Corporate Action Movement Failed Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementFailedStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementFailedStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementFailedStatus1( System.String reqAgentAccountIdentification )
    {
        AgentAccountIdentification = reqAgentAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the agent account.
    /// </summary>
    [IsoId("_Rjbfp9p-Ed-ak6NoX_4Aeg_-123497061")]
    [DisplayName("Agent Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtAcctId")]
    #endif
    [IsoXmlTag("AgtAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AgentAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AgentAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AgentAccountIdentification { get; init; } 
    #else
    public System.String AgentAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the client account.
    /// </summary>
    [IsoId("_RjbfqNp-Ed-ak6NoX_4Aeg_-158591004")]
    [DisplayName("Client Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntAcctId")]
    #endif
    [IsoXmlTag("ClntAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientAccountIdentification { get; init; } 
    #else
    public System.String? ClientAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that owns the client account.
    /// </summary>
    [IsoId("_Rjbfqdp-Ed-ak6NoX_4Aeg_-232960947")]
    [DisplayName("Account Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrId")]
    #endif
    [IsoXmlTag("AcctOwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the resource movement that failed and the reason of the failure.
    /// </summary>
    [IsoId("_Rjbfqtp-Ed-ak6NoX_4Aeg_-1713973917")]
    [DisplayName("Resource Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsrcDtls")]
    #endif
    [IsoXmlTag("RsrcDtls")]
    public ValueList<FailedMovement1> ResourceDetails { get; init; } = new ValueList<FailedMovement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Rjbfqtp-Ed-ak6NoX_4Aeg_-1713973917
    
    
    #nullable disable
    
}
