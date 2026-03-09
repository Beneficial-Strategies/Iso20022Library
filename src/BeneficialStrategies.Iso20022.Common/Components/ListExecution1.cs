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
/// Provides details about of a list that must be executed.
/// </summary>
[IsoId("_SzmHCNp-Ed-ak6NoX_4Aeg_922397507")]
[DisplayName("List Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ListExecution1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ListExecution1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ListExecution1( System.String reqListIdentification,System.String reqBidIdentification )
    {
        ListIdentification = reqListIdentification;
        BidIdentification = reqBidIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_SzmHCdp-Ed-ak6NoX_4Aeg_991661320")]
    [DisplayName("List Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListId")]
    #endif
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ListIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ListIdentification { get; init; } 
    #else
    public System.String ListIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a bid made by a client, to which the list is associated.
    /// </summary>
    [IsoId("_SzmHCtp-Ed-ak6NoX_4Aeg_1792356567")]
    [DisplayName("Client Bid Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntBidId")]
    #endif
    [IsoXmlTag("ClntBidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientBidIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientBidIdentification { get; init; } 
    #else
    public System.String? ClientBidIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_SzvQ8Np-Ed-ak6NoX_4Aeg_348987448")]
    [DisplayName("Bid Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidId")]
    #endif
    [IsoXmlTag("BidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BidIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BidIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BidIdentification { get; init; } 
    #else
    public System.String BidIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
