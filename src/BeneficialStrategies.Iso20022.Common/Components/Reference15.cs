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
/// Additional references linked to the order status.
/// </summary>
[IsoId("_Q_z1Mdp-Ed-ak6NoX_4Aeg_-766441894")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference15( System.String reqOrderIdentification )
    {
        OrderIdentification = reqOrderIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by issuer of Mass Status Request to uniquely identify the request.
    /// </summary>
    [IsoId("_Q_z1Mtp-Ed-ak6NoX_4Aeg_-1656495387")]
    [DisplayName("Order Mass Status Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrMassStsReqId")]
    #endif
    [IsoXmlTag("OrdrMassStsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderMassStatusRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderMassStatusRequestIdentification { get; init; } 
    #else
    public System.String? OrderMassStatusRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by issuer of Order Status Request to uniquely identify the request.
    /// </summary>
    [IsoId("_Q_z1M9p-Ed-ak6NoX_4Aeg_-1369282249")]
    [DisplayName("Order Status Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrStsReqId")]
    #endif
    [IsoXmlTag("OrdrStsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderStatusRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderStatusRequestIdentification { get; init; } 
    #else
    public System.String? OrderStatusRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for Order as assigned by sell-side.
    /// </summary>
    [IsoId("_Q_z1NNp-Ed-ak6NoX_4Aeg_378019497")]
    [DisplayName("Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrId")]
    #endif
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OrderIdentification { get; init; } 
    #else
    public System.String OrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Host assigned entity identification that can be used to reference all components of a cross; sides + strategy + legs. The HostCrossID will be used to link together components of the Cross Order. For example, each individual Notice of Execution associated with the order will carry HostCrossID in order to tie back to the original cross order.
    /// </summary>
    [IsoId("_Q_z1Ndp-Ed-ak6NoX_4Aeg_-1839590348")]
    [DisplayName("Host Cross Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstCrossId")]
    #endif
    [IsoXmlTag("HstCrossId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? HostCrossIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HostCrossIdentification { get; init; } 
    #else
    public System.String? HostCrossIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier for a cross order. Must be unique during a given trading day.
    /// </summary>
    [IsoId("_Q_z1Ntp-Ed-ak6NoX_4Aeg_-1607785677")]
    [DisplayName("Cross Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrossOrdrId")]
    #endif
    [IsoXmlTag("CrossOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CrossOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CrossOrderIdentification { get; init; } 
    #else
    public System.String? CrossOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Cross Identification of the previous cross order (not the initial cross order of the day) as assigned by the institution, used to identify the previous cross order in Cross Order Modification Request and Cross Order Cancellation Request.
    /// </summary>
    [IsoId("_Q_z1N9p-Ed-ak6NoX_4Aeg_-1551450786")]
    [DisplayName("Original Cross Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCrossOrdrId")]
    #endif
    [IsoXmlTag("OrgnlCrossOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalCrossOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalCrossOrderIdentification { get; init; } 
    #else
    public System.String? OriginalCrossOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for Order as assigned by the buy-side.
    /// </summary>
    [IsoId("_Q_z1ONp-Ed-ak6NoX_4Aeg_-1465565690")]
    [DisplayName("Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntOrdrId")]
    #endif
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientOrderIdentification { get; init; } 
    #else
    public System.String? ClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier assigned by the party which accepts the order.
    /// </summary>
    [IsoId("_Q_9mMNp-Ed-ak6NoX_4Aeg_-331136006")]
    [DisplayName("Secondary Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOrdrId")]
    #endif
    [IsoXmlTag("ScndryOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecondaryOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondaryOrderIdentification { get; init; } 
    #else
    public System.String? SecondaryOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier assigned by the party which originates the order.
    /// </summary>
    [IsoId("_Q_9mMdp-Ed-ak6NoX_4Aeg_99226144")]
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
    
    
    #nullable disable
    
}
