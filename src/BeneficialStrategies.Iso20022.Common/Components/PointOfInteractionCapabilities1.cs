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
/// Capabilities of the POI performing the transaction.
/// </summary>
[IsoId("_TGJWagEcEeCQm6a_G2yO_w_-1706794151")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_TGJWawEcEeCQm6a_G2yO_w_477826154")]
    [DisplayName("Card Reading Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdngCpblties")]
    #endif
    [IsoXmlTag("CardRdngCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading1Code? CardReadingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading1Code? CardReadingCapabilities { get; init; } 
    #else
    public CardDataReading1Code? CardReadingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_TGJWbAEcEeCQm6a_G2yO_w_1143315363")]
    [DisplayName("Cardholder Verification Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrVrfctnCpblties")]
    #endif
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; init; } 
    #else
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// On-line and off-line capabilities of the POI.
    /// </summary>
    [IsoId("_TGSgUAEcEeCQm6a_G2yO_w_1272910628")]
    [DisplayName("On Line Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineCpblties")]
    #endif
    [IsoXmlTag("OnLineCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    #else
    public OnLineCapability1Code? OnLineCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the display components performing the transaction.
    /// </summary>
    [IsoId("_TGSgUQEcEeCQm6a_G2yO_w_666196014")]
    [DisplayName("Display Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispCpblties")]
    #endif
    [IsoXmlTag("DispCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities1? DisplayCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities1? DisplayCapabilities { get; init; } 
    #else
    public DisplayCapabilities1? DisplayCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Number of columns of the printer component.
    /// </summary>
    [IsoId("_TGSgUgEcEeCQm6a_G2yO_w_-1182970689")]
    [DisplayName("Print Line Width")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtLineWidth")]
    #endif
    [IsoXmlTag("PrtLineWidth")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? PrintLineWidth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PrintLineWidth { get; init; } 
    #else
    public System.String? PrintLineWidth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
