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
[IsoId("_APfkAY4DEeWrZqsymMFdfg")]
[DisplayName("Maintenance Delegation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegation3( TerminalManagementAction3Code reqDelegationType )
    {
        DelegationType = reqDelegationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_JQ56II4DEeWrZqsymMFdfg")]
    [DisplayName("Delegation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnTp")]
    #endif
    [IsoXmlTag("DlgtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code DelegationType { get; init; } 
    #else
    public TerminalManagementAction3Code DelegationType { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_AahvUY4DEeWrZqsymMFdfg")]
    [DisplayName("Maintenance Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncSvc")]
    #endif
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory11Code> MaintenanceService { get; init; } = new SimpleValueList<DataSetCategory11Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _AahvUY4DEeWrZqsymMFdfg
    
    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    [IsoId("_AahvU44DEeWrZqsymMFdfg")]
    [DisplayName("Partial Delegation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlDlgtn")]
    #endif
    [IsoXmlTag("PrtlDlgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PartialDelegation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialDelegation { get; init; } 
    #else
    public System.String? PartialDelegation { get; set; } 
    #endif
    
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_AahvVY4DEeWrZqsymMFdfg")]
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
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    [IsoId("_AahvV44DEeWrZqsymMFdfg")]
    [DisplayName("Delegated Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtdActn")]
    #endif
    [IsoXmlTag("DlgtdActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaintenanceDelegateAction2? DelegatedAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceDelegateAction2? DelegatedAction { get; init; } 
    #else
    public MaintenanceDelegateAction2? DelegatedAction { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_AahvWY4DEeWrZqsymMFdfg")]
    [DisplayName("Delegation Scope Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnScpId")]
    #endif
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelegationScopeIdentification { get; init; } 
    #else
    public System.String? DelegationScopeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of the delegation scope, for instance inside the payment application parameters the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("_AahvW44DEeWrZqsymMFdfg")]
    [DisplayName("Delegation Scope Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnScpDef")]
    #endif
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationScopeDefinition { get; init; } 
    #else
    public System.Byte[]? DelegationScopeDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    [IsoId("_AahvXY4DEeWrZqsymMFdfg")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_AahvX44DEeWrZqsymMFdfg")]
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
    
    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    [IsoId("_AahvYY4DEeWrZqsymMFdfg")]
    [DisplayName("Symmetric Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SmmtrcKey")]
    #endif
    [IsoXmlTag("SmmtrcKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KEKIdentifier5? SymmetricKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier5? SymmetricKey { get; init; } 
    #else
    public KEKIdentifier5? SymmetricKey { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    [IsoId("_AahvY44DEeWrZqsymMFdfg")]
    [DisplayName("Parameter Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamDataSet")]
    #endif
    [IsoXmlTag("ParamDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalManagementDataSet19? ParameterDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementDataSet19? ParameterDataSet { get; init; } 
    #else
    public TerminalManagementDataSet19? ParameterDataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
