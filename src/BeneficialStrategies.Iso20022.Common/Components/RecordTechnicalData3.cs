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
/// Instrument specific technical data to support identification.
/// </summary>
[IsoId("_CSn_MVCTEeWchIYf-qgDzg")]
[DisplayName("Record Technical Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecordTechnicalData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Flag to say if there is an inconsistency across all submitting entities records.
    /// </summary>
    [IsoId("_gw4RYFCTEeWchIYf-qgDzg")]
    [DisplayName("Inconsistency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncnsstncyInd")]
    #endif
    [IsoXmlTag("IncnsstncyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InconsistencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InconsistencyIndicator { get; init; } 
    #else
    public System.String? InconsistencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Last date for which data was received for this instrument.
    /// </summary>
    [IsoId("_XEmxMHNBEeWkbcw9bLh6lw")]
    [DisplayName("Last Update")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpd")]
    #endif
    [IsoXmlTag("LastUpd")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? LastUpdate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? LastUpdate { get; init; } 
    #else
    public System.DateTime? LastUpdate { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the date and time when this instrument was originally received at the submission destination.
    /// </summary>
    [IsoId("_gMahsb7ZEeWWIvvK6uU0tA")]
    [DisplayName("Submission Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmissnDtTm")]
    #endif
    [IsoXmlTag("SubmissnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SubmissionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SubmissionDateTime { get; init; } 
    #else
    public System.DateTime? SubmissionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Country code of the relevant competent authority of the instrument.
    /// </summary>
    [IsoId("_p2RvoFCTEeWchIYf-qgDzg")]
    [DisplayName("Relevant Competent Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RlvntCmptntAuthrty")]
    #endif
    [IsoXmlTag("RlvntCmptntAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RelevantCompetentAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RelevantCompetentAuthority { get; init; } 
    #else
    public string? RelevantCompetentAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Period for which the associated instrument has been publically available.
    /// </summary>
    [IsoId("_rwwNYMXFEeW12P7QiJHPKQ")]
    [DisplayName("Publication Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PblctnPrd")]
    #endif
    [IsoXmlTag("PblctnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? PublicationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? PublicationPeriod { get; init; } 
    #else
    public Period4Choice_? PublicationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to say if the record has ever been published.
    /// </summary>
    [IsoId("_EVs10OJBEeWWKb0jFHxViQ")]
    [DisplayName("Never Published")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NvrPblshd")]
    #endif
    [IsoXmlTag("NvrPblshd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NeverPublished { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NeverPublished { get; init; } 
    #else
    public System.String? NeverPublished { get; set; } 
    #endif
    
    
    #nullable disable
    
}
