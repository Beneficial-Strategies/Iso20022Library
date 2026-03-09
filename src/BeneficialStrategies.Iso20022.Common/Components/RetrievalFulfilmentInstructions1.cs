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
/// Fulfilment instructions for the retrieval
/// </summary>
[IsoId("_zvnyIeE2EeeV6-yubHrZaQ")]
[DisplayName("Retrieval Fulfilment Instructions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RetrievalFulfilmentInstructions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains information describing the fulfilment information delivery methods.
    /// </summary>
    [IsoId("_z_Pig-E2EeeV6-yubHrZaQ")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetrievalDeliveryMethod1Choice_? Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetrievalDeliveryMethod1Choice_? Method { get; init; } 
    #else
    public RetrievalDeliveryMethod1Choice_? Method { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a retrieval fulfilment.
    /// </summary>
    [IsoId("_z_PiieE2EeeV6-yubHrZaQ")]
    [DisplayName("Delivery Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryInf")]
    #endif
    [IsoXmlTag("DlvryInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryInformation2? DeliveryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryInformation2? DeliveryInformation { get; init; } 
    #else
    public DeliveryInformation2? DeliveryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information relevant for the retrieval.
    /// </summary>
    [IsoId("_z_Pii-E2EeeV6-yubHrZaQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation22? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
