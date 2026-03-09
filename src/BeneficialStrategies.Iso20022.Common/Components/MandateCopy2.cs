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
/// Identifies the mandate, for which a copy of the details is requested.
/// </summary>
[IsoId("_RSUaQW49EeiU9cctagi5ow")]
[DisplayName("Mandate Copy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateCopy2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateCopy2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateCopy2( OriginalMandate6Choice_ reqOriginalMandate )
    {
        OriginalMandate = reqOriginalMandate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_Rb2wwW49EeiU9cctagi5ow")]
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
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_Rb2ww249EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndt")]
    #endif
    [IsoXmlTag("OrgnlMndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMandate6Choice_ OriginalMandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMandate6Choice_ OriginalMandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMandate6Choice_ OriginalMandate { get; init; } 
    #else
    public OriginalMandate6Choice_ OriginalMandate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the status of the mandate.
    /// </summary>
    [IsoId("_Rb2wxW49EeiU9cctagi5ow")]
    [DisplayName("Mandate Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtSts")]
    #endif
    [IsoXmlTag("MndtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateStatus1Choice_? MandateStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateStatus1Choice_? MandateStatus { get; init; } 
    #else
    public MandateStatus1Choice_? MandateStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Rb2wx249EeiU9cctagi5ow")]
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
