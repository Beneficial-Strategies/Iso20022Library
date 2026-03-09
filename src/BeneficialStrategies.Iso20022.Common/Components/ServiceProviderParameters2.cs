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
/// Service provider parameters of the point of interaction (POI).
/// </summary>
[IsoId("_YQodoVFMEeyApZmLzm74zA")]
[DisplayName("Service Provider Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceProviderParameters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceProviderParameters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceProviderParameters2( TerminalManagementAction3Code reqActionType,System.String reqVersion )
    {
        ActionType = reqActionType;
        Version = reqVersion;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_YW_kUVFMEeyApZmLzm74zA")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code ActionType { get; init; } 
    #else
    public TerminalManagementAction3Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the service provider.
    /// </summary>
    [IsoId("_YW_kU1FMEeyApZmLzm74zA")]
    [DisplayName("Service Provider Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcPrvdrId")]
    #endif
    [IsoXmlTag("SvcPrvdrId")]
    public ValueList<GenericIdentification176> ServiceProviderIdentification { get; init; } = new ValueList<GenericIdentification176>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _YW_kU1FMEeyApZmLzm74zA
    
    /// <summary>
    /// Version of the service provider parameters.
    /// </summary>
    [IsoId("_YW_kVVFMEeyApZmLzm74zA")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of payment application relevant for this service provider.
    /// </summary>
    [IsoId("_YW_kV1FMEeyApZmLzm74zA")]
    [DisplayName("Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplId")]
    #endif
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationIdentification { get; init; } 
    #else
    public System.String? ApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Service provider host configuration.
    /// </summary>
    [IsoId("_YW_kWVFMEeyApZmLzm74zA")]
    [DisplayName("Host")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hst")]
    #endif
    [IsoXmlTag("Hst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcquirerHostConfiguration9? Host { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerHostConfiguration9? Host { get; init; } 
    #else
    public AcquirerHostConfiguration9? Host { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of non financial action supported by the Service Provider.
    /// </summary>
    [IsoId("_YW_kW1FMEeyApZmLzm74zA")]
    [DisplayName("Non Financial Action Supported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFinActnSpprtd")]
    #endif
    [IsoXmlTag("NonFinActnSpprtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonFinancialRequestType1Code? NonFinancialActionSupported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialRequestType1Code? NonFinancialActionSupported { get; init; } 
    #else
    public NonFinancialRequestType1Code? NonFinancialActionSupported { get; set; } 
    #endif
    
    
    #nullable disable
    
}
