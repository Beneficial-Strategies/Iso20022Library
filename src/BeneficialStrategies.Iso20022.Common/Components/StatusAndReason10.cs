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
/// Provides details related to the status of the order.
/// </summary>
[IsoId("_AYEXMtokEeC60axPepSq7g_-1155773451")]
[DisplayName("Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusAndReason10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusAndReason10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusAndReason10( AffirmationStatus7Choice_ reqAffirmationStatus )
    {
        AffirmationStatus = reqAffirmationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_AYEXM9okEeC60axPepSq7g_-1696321282")]
    [DisplayName("Affirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffirmSts")]
    #endif
    [IsoXmlTag("AffirmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AffirmationStatus7Choice_ AffirmationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AffirmationStatus7Choice_ AffirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AffirmationStatus7Choice_ AffirmationStatus { get; init; } 
    #else
    public AffirmationStatus7Choice_ AffirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason why the instruction has an unaffirmed status.
    /// </summary>
    [IsoId("_AYEXNNokEeC60axPepSq7g_1078389926")]
    [DisplayName("Unaffirmed Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UaffrmdRsn")]
    #endif
    [IsoXmlTag("UaffrmdRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnaffirmedReason2Choice_? UnaffirmedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnaffirmedReason2Choice_? UnaffirmedReason { get; init; } 
    #else
    public UnaffirmedReason2Choice_? UnaffirmedReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_AYEXNdokEeC60axPepSq7g_1323167811")]
    [DisplayName("Additional Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsnInf")]
    #endif
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
