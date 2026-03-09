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
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
[IsoId("__pGIsWqGEeS8RZDTbvnB_A")]
[DisplayName("Maintenance Delegation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegation2( Response2Code reqResponse )
    {
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("__16csWqGEeS8RZDTbvnB_A")]
    [DisplayName("Maintenance Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncSvc")]
    #endif
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory6Code> MaintenanceService { get; init; } = new SimpleValueList<DataSetCategory6Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is __16csWqGEeS8RZDTbvnB_A
    
    /// <summary>
    /// Response of the MTM to the delegation of the maintenance service.
    /// </summary>
    [IsoId("_p_-1wGqHEeS8RZDTbvnB_A")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Response2Code Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Response2Code Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response2Code Response { get; init; } 
    #else
    public Response2Code Response { get; set; } 
    #endif
    
    /// <summary>
    /// Reason of the response of the MTM.
    /// </summary>
    [IsoId("_PqNmcGqIEeS8RZDTbvnB_A")]
    [DisplayName("Response Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRsn")]
    #endif
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ResponseReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponseReason { get; init; } 
    #else
    public System.String? ResponseReason { get; set; } 
    #endif
    
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("__16ctWqGEeS8RZDTbvnB_A")]
    [DisplayName("POI Subset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POISubset")]
    #endif
    [IsoXmlTag("POISubset")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POISubset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POISubset { get; init; } 
    #else
    public System.String? POISubset { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("__16cuWqGEeS8RZDTbvnB_A")]
    [DisplayName("Parameters Subset Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamsSubsetId")]
    #endif
    [IsoXmlTag("ParamsSubsetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ParametersSubsetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParametersSubsetIdentification { get; init; } 
    #else
    public System.String? ParametersSubsetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of the subset of application parameters, for instance the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("__16cu2qGEeS8RZDTbvnB_A")]
    [DisplayName("Parameters Subset Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamsSubsetDef")]
    #endif
    [IsoXmlTag("ParamsSubsetDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? ParametersSubsetDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ParametersSubsetDefinition { get; init; } 
    #else
    public System.Byte[]? ParametersSubsetDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Proof of delegation to be verified by the POI, when performing the delegated actions.
    /// </summary>
    [IsoId("_h8pcAGqIEeS8RZDTbvnB_A")]
    [DisplayName("Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnProof")]
    #endif
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? DelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationProof { get; init; } 
    #else
    public System.Byte[]? DelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_oNyp8GqIEeS8RZDTbvnB_A")]
    [DisplayName("Protected Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdDlgtnProof")]
    #endif
    [IsoXmlTag("PrtctdDlgtnProof")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType12? ProtectedDelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12? ProtectedDelegationProof { get; init; } 
    #else
    public ContentInformationType12? ProtectedDelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("__16cv2qGEeS8RZDTbvnB_A")]
    [DisplayName("POI Identification Association")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIIdAssoctn")]
    #endif
    [IsoXmlTag("POIIdAssoctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    #else
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
