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
/// Data to be present in a dispute.
/// </summary>
[IsoId("_1xe1ccZiEeiCDcGzDHI_9Q")]
[DisplayName("Dispute Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisputeData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the cycle of presentment or of the chargeback  (1= first cycle for chargeback, 2= second cycle of presentment or chargeback, etc.).
    /// </summary>
    [IsoId("_18M3scZiEeiCDcGzDHI_9Q")]
    [DisplayName("Presentment Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntmntCycl")]
    #endif
    [IsoXmlTag("PresntmntCycl")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? PresentmentCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PresentmentCycle { get; init; } 
    #else
    public System.String? PresentmentCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Condition of the dispute.
    /// </summary>
    [IsoId("_18M3s8ZiEeiCDcGzDHI_9Q")]
    [DisplayName("Dispute Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptCond")]
    #endif
    [IsoXmlTag("DsptCond")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DisputeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisputeCondition { get; init; } 
    #else
    public System.String? DisputeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Reference for the dispute.
    /// </summary>
    [IsoId("_18M3ucZiEeiCDcGzDHI_9Q")]
    [DisplayName("Dispute Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptRef")]
    #endif
    [IsoXmlTag("DsptRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisputeReference1? DisputeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisputeReference1? DisputeReference { get; init; } 
    #else
    public DisputeReference1? DisputeReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
