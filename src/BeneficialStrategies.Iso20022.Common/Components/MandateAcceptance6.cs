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
/// Identifies the mandate, which is being accepted.
/// </summary>
[IsoId("_ZoVqAW49EeiU9cctagi5ow")]
[DisplayName("Mandate Acceptance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAcceptance6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateAcceptance6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAcceptance6( AcceptanceResult6 reqAcceptanceResult )
    {
        AcceptanceResult = reqAcceptanceResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_ZyBKdW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgInf")]
    #endif
    [IsoXmlTag("OrgnlMsgInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    #else
    public OriginalMessageInformation1? OriginalMessageInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the acceptance result.
    /// </summary>
    [IsoId("_ZyBKd249EeiU9cctagi5ow")]
    [DisplayName("Acceptance Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncRslt")]
    #endif
    [IsoXmlTag("AccptncRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptanceResult6 AcceptanceResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptanceResult6 AcceptanceResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptanceResult6 AcceptanceResult { get; init; } 
    #else
    public AcceptanceResult6 AcceptanceResult { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_ZyBKeW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndt")]
    #endif
    [IsoXmlTag("OrgnlMndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalMandate7Choice_? OriginalMandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMandate7Choice_? OriginalMandate { get; init; } 
    #else
    public OriginalMandate7Choice_? OriginalMandate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZyBKe249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
