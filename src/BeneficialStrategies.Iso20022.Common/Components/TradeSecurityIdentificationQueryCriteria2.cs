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
/// Specifies the query criteria related to securities.
/// </summary>
[IsoId("_YwmEUdGREeaQk737TH1Fzw")]
[DisplayName("Trade Security Identification Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeSecurityIdentificationQueryCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeSecurityIdentificationQueryCriteria2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeSecurityIdentificationQueryCriteria2( Operation3Code reqOperator )
    {
        Operator = reqOperator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_Y5Yz8dGREeaQk737TH1Fzw")]
    [DisplayName("Operator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oprtr")]
    #endif
    [IsoXmlTag("Oprtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Operation3Code Operator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Operation3Code Operator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Operation3Code Operator { get; init; } 
    #else
    public Operation3Code Operator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the product through ISIN or AII.
    /// </summary>
    [IsoId("_Y5Yz89GREeaQk737TH1Fzw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentificationQueryCriteria1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentificationQueryCriteria1? Identification { get; init; } 
    #else
    public SecurityIdentificationQueryCriteria1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type. 
    /// </summary>
    [IsoId("_Y5Yz9dGREeaQk737TH1Fzw")]
    [DisplayName("Underlying Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrmId")]
    #endif
    [IsoXmlTag("UndrlygInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentificationQuery3Choice_? UnderlyingInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentificationQuery3Choice_? UnderlyingInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentificationQuery3Choice_? UnderlyingInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
