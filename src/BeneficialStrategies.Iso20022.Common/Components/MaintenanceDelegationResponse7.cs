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
/// Information related to the request of maintenance delegations.
/// </summary>
[IsoId("_t9XGkXJkEe299ZbWCkdR_w")]
[DisplayName("Maintenance Delegation Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegationResponse7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegationResponse7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegationResponse7( GenericIdentification176 reqTMIdentification,System.DateTime reqTMDateTime,System.Byte[] reqTMChallengeValue )
    {
        TMIdentification = reqTMIdentification;
        TMDateTime = reqTMDateTime;
        TMChallengeValue = reqTMChallengeValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_uDx3oXJkEe299ZbWCkdR_w")]
    [DisplayName("TM Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMId")]
    #endif
    [IsoXmlTag("TMId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification176 TMIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification176 TMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176 TMIdentification { get; init; } 
    #else
    public GenericIdentification176 TMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_uDx3o3JkEe299ZbWCkdR_w")]
    [DisplayName("Master TM Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrTMId")]
    #endif
    [IsoXmlTag("MstrTMId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? MasterTMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? MasterTMIdentification { get; init; } 
    #else
    public GenericIdentification176? MasterTMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and Time of the TMS.
    /// </summary>
    [IsoId("_WZpIIHJlEe299ZbWCkdR_w")]
    [DisplayName("TM Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMDtTm")]
    #endif
    [IsoXmlTag("TMDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TMDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TMDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TMDateTime { get; init; } 
    #else
    public System.DateTime TMDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Challenge value sends by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_C0kwkHJmEe299ZbWCkdR_w")]
    [DisplayName("TM Challenge Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllngVal")]
    #endif
    [IsoXmlTag("TMChllngVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Binary TMChallengeValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] TMChallengeValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] TMChallengeValue { get; init; } 
    #else
    public System.Byte[] TMChallengeValue { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_uDx3pXJkEe299ZbWCkdR_w")]
    [DisplayName("Delegation Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnRspn")]
    #endif
    [IsoXmlTag("DlgtnRspn")]
    public ValueList<MaintenanceDelegation16> DelegationResponse { get; init; } = new ValueList<MaintenanceDelegation16>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _uDx3pXJkEe299ZbWCkdR_w
    
    
    #nullable disable
    
}
