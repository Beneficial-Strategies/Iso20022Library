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
[IsoId("_5IxrwGqFEeS8RZDTbvnB_A")]
[DisplayName("Maintenance Delegation Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegationResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegationResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegationResponse1( GenericIdentification72 reqTMIdentification )
    {
        TMIdentification = reqTMIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_SszfoGqGEeS8RZDTbvnB_A")]
    [DisplayName("TM Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMId")]
    #endif
    [IsoXmlTag("TMId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification72 TMIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification72 TMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification72 TMIdentification { get; init; } 
    #else
    public GenericIdentification72 TMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_bn054GqGEeS8RZDTbvnB_A")]
    [DisplayName("Master TM Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrTMId")]
    #endif
    [IsoXmlTag("MstrTMId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    #else
    public GenericIdentification72? MasterTMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_0C2eUGqGEeS8RZDTbvnB_A")]
    [DisplayName("Delegation Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnRspn")]
    #endif
    [IsoXmlTag("DlgtnRspn")]
    public ValueList<MaintenanceDelegation2> DelegationResponse { get; init; } = new ValueList<MaintenanceDelegation2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _0C2eUGqGEeS8RZDTbvnB_A
    
    
    #nullable disable
    
}
