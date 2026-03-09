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
/// Specifies the arrangement of the transport of goods and services and the parties involved in this process.
/// </summary>
[IsoId("_S-10hgEcEeCQm6a_G2yO_w_-323080810")]
[DisplayName("Consignment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Consignment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party consigning goods as stipulated in the transport contract by the party ordering transport.
    /// </summary>
    [IsoId("_S-10hwEcEeCQm6a_G2yO_w_379767677")]
    [DisplayName("Consignor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnr")]
    #endif
    [IsoXmlTag("Consgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Consignor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Consignor { get; init; } 
    #else
    public TradeParty1? Consignor { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which goods are consigned.
    /// </summary>
    [IsoId("_S-10iAEcEeCQm6a_G2yO_w_-20999364")]
    [DisplayName("Consignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgn")]
    #endif
    [IsoXmlTag("Consgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Consignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Consignee { get; init; } 
    #else
    public TradeParty1? Consignee { get; set; } 
    #endif
    
    /// <summary>
    /// Particular aircraft, vehicle, vessel or other device used for the transport of a consignment.
    /// </summary>
    [IsoId("_S-_lgAEcEeCQm6a_G2yO_w_-1584428859")]
    [DisplayName("Transport Means")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtMeans")]
    #endif
    [IsoXmlTag("TrnsprtMeans")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportMeans3? TransportMeans { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportMeans3? TransportMeans { get; init; } 
    #else
    public TransportMeans3? TransportMeans { get; set; } 
    #endif
    
    
    #nullable disable
    
}
