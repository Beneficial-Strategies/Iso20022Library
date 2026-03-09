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
/// Expiry conditions.
/// </summary>
[IsoId("_rhWRxoAAEeGOn4dfTT_QdQ")]
[DisplayName("Expiry Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExpiryTerms2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_rhW4yoAAEeGOn4dfTT_QdQ")]
    [DisplayName("Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtTm")]
    #endif
    [IsoXmlTag("DtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? DateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the automatic extension of the undertaking.
    /// </summary>
    [IsoId("_rhW43IAAEeGOn4dfTT_QdQ")]
    [DisplayName("Auto Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutoXtnsn")]
    #endif
    [IsoXmlTag("AutoXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutoExtension1? AutoExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutoExtension1? AutoExtension { get; init; } 
    #else
    public AutoExtension1? AutoExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Documentary condition that indicates when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_rhW4xIAAEeGOn4dfTT_QdQ")]
    [DisplayName("Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond")]
    #endif
    [IsoXmlTag("Cond")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? Condition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition { get; init; } 
    #else
    public System.String? Condition { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the expiry terms are without a fixed expiry date.
    /// </summary>
    [IsoId("_rhW40oAAEeGOn4dfTT_QdQ")]
    [DisplayName("Open Ended Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnEnddInd")]
    #endif
    [IsoXmlTag("OpnEnddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OpenEndedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpenEndedIndicator { get; init; } 
    #else
    public System.String? OpenEndedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
