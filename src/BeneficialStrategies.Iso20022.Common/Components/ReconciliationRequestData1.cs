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
/// Content of the Reconciliation Request message.
/// </summary>
[IsoId("__qugkNxdEeioifFt1dhnJA")]
[DisplayName("Reconciliation Request Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationRequestData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationRequestData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationRequestData1( ReconciliationType1Code reqReconciliationType )
    {
        ReconciliationType = reqReconciliationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of Reconciliation requested by the Sale to the POI.
    /// </summary>
    [IsoId("_E1kNwNxeEeioifFt1dhnJA")]
    [DisplayName("Reconciliation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnTp")]
    #endif
    [IsoXmlTag("RcncltnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationType1Code ReconciliationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationType1Code ReconciliationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationType1Code ReconciliationType { get; init; } 
    #else
    public ReconciliationType1Code ReconciliationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_lzjRwNxeEeioifFt1dhnJA")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerIdentification { get; init; } 
    #else
    public System.String? AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [IsoId("_pqqtQNxeEeioifFt1dhnJA")]
    [DisplayName("POI Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIRcncltnId")]
    #endif
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIReconciliationIdentification { get; init; } 
    #else
    public System.String? POIReconciliationIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
