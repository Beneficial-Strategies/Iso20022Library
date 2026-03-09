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
/// Specifies the attributes of a report and its content.
/// </summary>
[IsoId("_fuq9cMlNEeuJ35KoBRZFOg")]
[DisplayName("Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the report.
    /// </summary>
    [IsoId("_hWn9QMlOEeuJ35KoBRZFOg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Report identification.
    /// </summary>
    [IsoId("_qKltQMlOEeuJ35KoBRZFOg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional specific information to ID (Country, Service, etc.)
    /// </summary>
    [IsoId("_vtcR0MlOEeuJ35KoBRZFOg")]
    [DisplayName("Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qlfr")]
    #endif
    [IsoXmlTag("Qlfr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Qualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Qualifier { get; init; } 
    #else
    public System.String? Qualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the report.
    /// </summary>
    [IsoId("_7jbBUMlOEeuJ35KoBRZFOg")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Time of the report.
    /// </summary>
    [IsoId("__aO60MlOEeuJ35KoBRZFOg")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Time { get; init; } 
    #else
    public System.TimeOnly? Time { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the specific instance of the report (e.g., sequence “2” of the report within a specific time frame).
    /// </summary>
    [IsoId("_ElHrUMlPEeuJ35KoBRZFOg")]
    [DisplayName("Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Seq")]
    #endif
    [IsoXmlTag("Seq")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? Sequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sequence { get; init; } 
    #else
    public System.String? Sequence { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the expected total number of occurrences of the report within a specific time frame.
    /// </summary>
    [IsoId("_PRaO4MlPEeuJ35KoBRZFOg")]
    [DisplayName("Total Occurrences")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOcrncs")]
    #endif
    [IsoXmlTag("TtlOcrncs")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? TotalOccurrences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalOccurrences { get; init; } 
    #else
    public System.String? TotalOccurrences { get; set; } 
    #endif
    
    /// <summary>
    /// Report frequency.
    /// </summary>
    [IsoId("__6uG0MlQEeuJ35KoBRZFOg")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency17Code? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency17Code? Frequency { get; init; } 
    #else
    public Frequency17Code? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies that is a corrected version of a report that was previously sent.
    /// </summary>
    [IsoId("_H1V0AclREeuJ35KoBRZFOg")]
    [DisplayName("Correction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crrctn")]
    #endif
    [IsoXmlTag("Crrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorrectionIdentification1? Correction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorrectionIdentification1? Correction { get; init; } 
    #else
    public CorrectionIdentification1? Correction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that report is not complete.
    /// </summary>
    [IsoId("_hC0JEclREeuJ35KoBRZFOg")]
    [DisplayName("Continuation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConttnInd")]
    #endif
    [IsoXmlTag("ConttnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContinuationIndicator { get; init; } 
    #else
    public System.String? ContinuationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional report attributes or information.
    /// </summary>
    [IsoId("_ugTB4MlREeuJ35KoBRZFOg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    /// <summary>
    /// Report format.
    /// </summary>
    [IsoId("_L19M8MlVEeuJ35KoBRZFOg")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat5Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat5Code? Format { get; init; } 
    #else
    public OutputFormat5Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Other report format defined by national organization or by bi-lateral agreement.
    /// </summary>
    [IsoId("_UY1M8MlVEeuJ35KoBRZFOg")]
    [DisplayName("Other Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFrmt")]
    #endif
    [IsoXmlTag("OthrFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFormat { get; init; } 
    #else
    public System.String? OtherFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the content of a report.
    /// </summary>
    [IsoId("_syuwAMlVEeuJ35KoBRZFOg")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportContent1? Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportContent1? Content { get; init; } 
    #else
    public ReportContent1? Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
