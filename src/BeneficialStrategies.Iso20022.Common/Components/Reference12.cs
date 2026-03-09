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
/// Additional references linked to the list order.
/// </summary>
[IsoId("_Q_9mNdp-Ed-ak6NoX_4Aeg_987338352")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference12( System.String reqIOIIdentification,System.String reqQuoteIdentification,System.String reqReferenceOrderIdentification )
    {
        IOIIdentification = reqIOIIdentification;
        QuoteIdentification = reqQuoteIdentification;
        ReferenceOrderIdentification = reqReferenceOrderIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for bid response as assigned by sell-side (broker, exchange, electronic communication network).
    /// </summary>
    [IsoId("_Q_9mNtp-Ed-ak6NoX_4Aeg_-477447686")]
    [DisplayName("Bid Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidId")]
    #endif
    [IsoXmlTag("BidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BidIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BidIdentification { get; init; } 
    #else
    public System.String? BidIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for a bid request as assigned by institution.
    /// </summary>
    [IsoId("_Q_9mN9p-Ed-ak6NoX_4Aeg_-436812639")]
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
    /// Unique identifier of the indication of interest message. Required for previously indicated orders.
    /// </summary>
    [IsoId("_Q_9mONp-Ed-ak6NoX_4Aeg_-410954582")]
    [DisplayName("IOI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IOIId")]
    #endif
    [IsoXmlTag("IOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IOIIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IOIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IOIIdentification { get; init; } 
    #else
    public System.String IOIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for quote. Required for previously quoted orders.
    /// </summary>
    [IsoId("_RAGwINp-Ed-ak6NoX_4Aeg_-396176364")]
    [DisplayName("Quote Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtId")]
    #endif
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text QuoteIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QuoteIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QuoteIdentification { get; init; } 
    #else
    public System.String QuoteIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the order being hit or taken.
    /// </summary>
    [IsoId("_RAGwIdp-Ed-ak6NoX_4Aeg_1024198853")]
    [DisplayName("Reference Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefOrdrId")]
    #endif
    [IsoXmlTag("RefOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReferenceOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReferenceOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReferenceOrderIdentification { get; init; } 
    #else
    public System.String ReferenceOrderIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
