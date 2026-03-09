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
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_eSRVgdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAmendment7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateAmendment7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAmendment7( MandateAmendmentReason2 reqAmendmentReason,Mandate18 reqMandate,OriginalMandate9Choice_ reqOriginalMandate )
    {
        AmendmentReason = reqAmendmentReason;
        Mandate = reqMandate;
        OriginalMandate = reqOriginalMandate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_eToncdcZEeqRFcf2R4bPBw")]
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
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_eTonc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Amendment Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntRsn")]
    #endif
    [IsoXmlTag("AmdmntRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateAmendmentReason2 AmendmentReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MandateAmendmentReason2 AmendmentReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateAmendmentReason2 AmendmentReason { get; init; } 
    #else
    public MandateAmendmentReason2 AmendmentReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_eTonddcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mndt")]
    #endif
    [IsoXmlTag("Mndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Mandate18 Mandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Mandate18 Mandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Mandate18 Mandate { get; init; } 
    #else
    public Mandate18 Mandate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_eTond9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndt")]
    #endif
    [IsoXmlTag("OrgnlMndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMandate9Choice_ OriginalMandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMandate9Choice_ OriginalMandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMandate9Choice_ OriginalMandate { get; init; } 
    #else
    public OriginalMandate9Choice_ OriginalMandate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eTonedcZEeqRFcf2R4bPBw")]
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
