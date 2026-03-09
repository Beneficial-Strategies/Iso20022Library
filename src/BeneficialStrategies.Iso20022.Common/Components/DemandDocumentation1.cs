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
/// Document presented for examination.
/// </summary>
[IsoId("_-Eq_uHltEeG7BsjMvd1mEw_-538829885")]
[DisplayName("Demand Documentation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DemandDocumentation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DemandDocumentation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DemandDocumentation1( System.String reqCompleteIndicator )
    {
        CompleteIndicator = reqCompleteIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication as to whether the presentation is complete.
    /// </summary>
    [IsoId("_-E0JoHltEeG7BsjMvd1mEw_-572404369")]
    [DisplayName("Complete Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltInd")]
    #endif
    [IsoXmlTag("CmpltInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CompleteIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CompleteIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CompleteIndicator { get; init; } 
    #else
    public System.String CompleteIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an incomplete presentation.
    /// </summary>
    [IsoId("_-E0JoXltEeG7BsjMvd1mEw_-1669522883")]
    [DisplayName("Completion Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnInf")]
    #endif
    [IsoXmlTag("CmpltnInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? CompletionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CompletionInformation { get; init; } 
    #else
    public System.String? CompletionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the demand.
    /// </summary>
    [IsoId("_-E0JonltEeG7BsjMvd1mEw_32400156")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Narrative text constituting the demand.
    /// </summary>
    [IsoId("_-E0Jo3ltEeG7BsjMvd1mEw_370931401")]
    [DisplayName("Demand Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndNrrtv")]
    #endif
    [IsoXmlTag("DmndNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? DemandNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DemandNarrative { get; init; } 
    #else
    public System.String? DemandNarrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
