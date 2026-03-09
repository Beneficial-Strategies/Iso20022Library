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
[IsoId("_Kw_ykGp5EeSojYXQbRlLzA")]
[DisplayName("Maintenance Delegation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_lFEjUGp5EeSojYXQbRlLzA")]
    [DisplayName("Maintenance Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncSvc")]
    #endif
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory6Code> MaintenanceService { get; init; } = new SimpleValueList<DataSetCategory6Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _lFEjUGp5EeSojYXQbRlLzA
    
    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    [IsoId("_NHM4IGp9EeSojYXQbRlLzA")]
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
    [IsoId("_XrpHQGp9EeSojYXQbRlLzA")]
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
    [IsoId("_gycTsGp9EeSojYXQbRlLzA")]
    [DisplayName("Delegated Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtdActn")]
    #endif
    [IsoXmlTag("DlgtdActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaintenanceDelegateAction1? DelegatedAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceDelegateAction1? DelegatedAction { get; init; } 
    #else
    public MaintenanceDelegateAction1? DelegatedAction { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_FI1hIGqCEeSojYXQbRlLzA")]
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
    [IsoId("_MoXNwGqCEeSojYXQbRlLzA")]
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
    /// Certificate path of the terminal manager.
    /// </summary>
    [IsoId("_XiCtEGqCEeSojYXQbRlLzA")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_dIVnMGqCEeSojYXQbRlLzA")]
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
    [IsoId("_KQjzcGqDEeSojYXQbRlLzA")]
    [DisplayName("Symmetric Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SmmtrcKey")]
    #endif
    [IsoXmlTag("SmmtrcKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KEKIdentifier2? SymmetricKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KEKIdentifier2? SymmetricKey { get; init; } 
    #else
    public KEKIdentifier2? SymmetricKey { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    [IsoId("_T8tIoGqDEeSojYXQbRlLzA")]
    [DisplayName("Parameter Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamDataSet")]
    #endif
    [IsoXmlTag("ParamDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminalManagementDataSet14? ParameterDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementDataSet14? ParameterDataSet { get; init; } 
    #else
    public TerminalManagementDataSet14? ParameterDataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
