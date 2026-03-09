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
/// Contains the content of a report.
/// </summary>
[IsoId("_dItHIMlVEeuJ35KoBRZFOg")]
[DisplayName("Report Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportContent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportContent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportContent1( ReportContent1Choice_ reqFormattedContent )
    {
        FormattedContent = reqFormattedContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequence number of the report line in the report.
    /// </summary>
    [IsoId("_3xe8kMlVEeuJ35KoBRZFOg")]
    [DisplayName("Report Line Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptLineSeq")]
    #endif
    [IsoXmlTag("RptLineSeq")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? ReportLineSequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportLineSequence { get; init; } 
    #else
    public System.String? ReportLineSequence { get; set; } 
    #endif
    
    /// <summary>
    /// Formatted or unformatted report content.
    /// </summary>
    [IsoId("_GZ00EMlYEeuJ35KoBRZFOg")]
    [DisplayName("Formatted Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmtdCntt")]
    #endif
    [IsoXmlTag("FrmtdCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportContent1Choice_ FormattedContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportContent1Choice_ FormattedContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportContent1Choice_ FormattedContent { get; init; } 
    #else
    public ReportContent1Choice_ FormattedContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
