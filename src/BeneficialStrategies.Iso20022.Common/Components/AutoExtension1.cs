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
/// Automatic extension information.
/// </summary>
[IsoId("_95V5dnltEeG7BsjMvd1mEw_1894661864")]
[DisplayName("Auto Extension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AutoExtension1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that the undertaking is automatically extendable and the period of extension.
    /// </summary>
    [IsoId("_95V5d3ltEeG7BsjMvd1mEw_742198140")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutoExtend1Choice_? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutoExtend1Choice_? Period { get; init; } 
    #else
    public AutoExtend1Choice_? Period { get; set; } 
    #endif
    
    /// <summary>
    /// Final expiry date after which the undertaking will no longer be subject to automatic extension.
    /// </summary>
    [IsoId("_95V5eHltEeG7BsjMvd1mEw_-211951579")]
    [DisplayName("Final Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlXpryDt")]
    #endif
    [IsoXmlTag("FnlXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FinalExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FinalExpiryDate { get; init; } 
    #else
    public System.DateOnly? FinalExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the notification of the end of the period for notification of non-extension of the expiry date.
    /// </summary>
    [IsoId("_95V5eXltEeG7BsjMvd1mEw_-1641257680")]
    [DisplayName("Non Extension Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonXtnsnNtfctn")]
    #endif
    [IsoXmlTag("NonXtnsnNtfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonExtension1? NonExtensionNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonExtension1? NonExtensionNotification { get; init; } 
    #else
    public NonExtension1? NonExtensionNotification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
