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
/// Data related to the status report of a point of interaction (POI).
/// </summary>
[IsoId("_ua_VIBBeEeqgJK7e3n_EXA")]
[DisplayName("Status Report Data Set Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReportDataSetRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReportDataSetRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReportDataSetRequest1( DataSetIdentification8 reqIdentification,StatusReportContent9 reqContent )
    {
        Identification = reqIdentification;
        Content = reqContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_ua_8MBBeEeqgJK7e3n_EXA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification8 Identification { get; init; } 
    #else
    public DataSetIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_ua_VIRBeEeqgJK7e3n_EXA")]
    [DisplayName("Sequence Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqCntr")]
    #endif
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceCounter { get; init; } 
    #else
    public System.String? SequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the status report.
    /// </summary>
    [IsoId("_ua_8MRBeEeqgJK7e3n_EXA")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusReportContent9 Content { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatusReportContent9 Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReportContent9 Content { get; init; } 
    #else
    public StatusReportContent9 Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
