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
/// Data related to the management plan of a point of interaction (POI).
/// </summary>
[IsoId("_4Py0oU6pEeyGi9JAv6wq7Q")]
[DisplayName("Terminal Management Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalManagementDataSet31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TerminalManagementDataSet31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TerminalManagementDataSet31( DataSetIdentification9 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    [IsoId("_4WU6cU6pEeyGi9JAv6wq7Q")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification9 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification9 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification9 Identification { get; init; } 
    #else
    public DataSetIdentification9 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_4WU6c06pEeyGi9JAv6wq7Q")]
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
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_4WU6dU6pEeyGi9JAv6wq7Q")]
    [DisplayName("Last Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastSeq")]
    #endif
    [IsoXmlTag("LastSeq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LastSequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LastSequence { get; init; } 
    #else
    public System.String? LastSequence { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the management plan.
    /// </summary>
    [IsoId("_4WU6d06pEeyGi9JAv6wq7Q")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ManagementPlanContent10? Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ManagementPlanContent10? Content { get; init; } 
    #else
    public ManagementPlanContent10? Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
