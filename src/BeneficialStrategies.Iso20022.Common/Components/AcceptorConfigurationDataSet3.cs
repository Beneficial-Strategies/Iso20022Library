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
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
[IsoId("_yOk-QVEIEeyApZmLzm74zA")]
[DisplayName("Acceptor Configuration Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationDataSet3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorConfigurationDataSet3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorConfigurationDataSet3( DataSetIdentification9 reqIdentification,AcceptorConfigurationContent11 reqContent )
    {
        Identification = reqIdentification;
        Content = reqContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_yVVGgVEIEeyApZmLzm74zA")]
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
    [IsoId("_yVVGg1EIEeyApZmLzm74zA")]
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
    [IsoId("_yVVGhVEIEeyApZmLzm74zA")]
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
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_yVVGh1EIEeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? POIIdentification { get; init; } 
    #else
    public GenericIdentification176? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_yVVGiVEIEeyApZmLzm74zA")]
    [DisplayName("Configuration Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CfgtnScp")]
    #endif
    [IsoXmlTag("CfgtnScp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType15Code? ConfigurationScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType15Code? ConfigurationScope { get; init; } 
    #else
    public PartyType15Code? ConfigurationScope { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_yVVGi1EIEeyApZmLzm74zA")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorConfigurationContent11 Content { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorConfigurationContent11 Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorConfigurationContent11 Content { get; init; } 
    #else
    public AcceptorConfigurationContent11 Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
