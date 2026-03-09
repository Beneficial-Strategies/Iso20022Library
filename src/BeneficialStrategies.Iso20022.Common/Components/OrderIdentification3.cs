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
/// Provides identifications related to the order processing.
/// </summary>
[IsoId("_S4XSQ9p-Ed-ak6NoX_4Aeg_1055247135")]
[DisplayName("Order Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrderIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderIdentification3( System.String reqClientOrderIdentification )
    {
        ClientOrderIdentification = reqClientOrderIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [IsoId("_S4XSRNp-Ed-ak6NoX_4Aeg_-1038002624")]
    [DisplayName("Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrId")]
    #endif
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderIdentification { get; init; } 
    #else
    public System.String? OrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for the order as assigned by the buyside. Uniqueness must be guaranteed within a single trading day. Firms, particularly those that electronically submit multi-day orders, trade globally or throughout market close periods, should ensure uniqueness across days, for example by embedding a date within the ClientOrderIdentification element.
    /// </summary>
    [IsoId("_S4XSRdp-Ed-ak6NoX_4Aeg_1102346319")]
    [DisplayName("Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntOrdrId")]
    #endif
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ClientOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClientOrderIdentification { get; init; } 
    #else
    public System.String ClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Assigned by the party that originates the order. Can be used to provide the ClientOrderIdentification used by an exchange or executing system.
    /// </summary>
    [IsoId("_S4XSRtp-Ed-ak6NoX_4Aeg_1102346301")]
    [DisplayName("Secondary Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryClntOrdrId")]
    #endif
    [IsoXmlTag("ScndryClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecondaryClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondaryClientOrderIdentification { get; init; } 
    #else
    public System.String? SecondaryClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_S4XSR9p-Ed-ak6NoX_4Aeg_-246196560")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Side1Code? Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side1Code? Side { get; init; } 
    #else
    public Side1Code? Side { get; set; } 
    #endif
    
    /// <summary>
    /// Permits order originators to tie together groups of orders in which trades resulting from orders are associated for a specific purpose, for example the calculation of average execution price for a customer or to associate lists submitted to a broker as waves of a larger program trade.
    /// </summary>
    [IsoId("_S4XSSNp-Ed-ak6NoX_4Aeg_293714089")]
    [DisplayName("Client Order Link Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntOrdrLkId")]
    #endif
    [IsoXmlTag("ClntOrdrLkId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientOrderLinkIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientOrderLinkIdentification { get; init; } 
    #else
    public System.String? ClientOrderLinkIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
