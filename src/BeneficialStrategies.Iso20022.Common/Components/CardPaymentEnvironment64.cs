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
/// Environment of the diagnostic exchange.
/// </summary>
[IsoId("_pAXm8apzEeanIZ10Ka8PnA")]
[DisplayName("Card Payment Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment64
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment64 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment64( Acquirer4 reqAcquirer )
    {
        Acquirer = reqAcquirer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_pLD0AapzEeanIZ10Ka8PnA")]
    [DisplayName("Acquirer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acqrr")]
    #endif
    [IsoXmlTag("Acqrr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Acquirer4 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Acquirer4 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer4 Acquirer { get; init; } 
    #else
    public Acquirer4 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    [IsoId("_pLD0A6pzEeanIZ10Ka8PnA")]
    [DisplayName("Acquirer Availability Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrAvlbtyReqd")]
    #endif
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerAvailabilityRequested { get; init; } 
    #else
    public System.String? AcquirerAvailabilityRequested { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_pLD0BapzEeanIZ10Ka8PnA")]
    [DisplayName("Merchant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntId")]
    #endif
    [IsoXmlTag("MrchntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification53? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53? MerchantIdentification { get; init; } 
    #else
    public GenericIdentification53? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [IsoId("_pLD0B6pzEeanIZ10Ka8PnA")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? POIIdentification { get; init; } 
    #else
    public GenericIdentification32? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    [IsoId("_pLD0CapzEeanIZ10Ka8PnA")]
    [DisplayName("POI Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpnt")]
    #endif
    [IsoXmlTag("POICmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent7? POIComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent7? POIComponent { get; init; } 
    #else
    public PointOfInteractionComponent7? POIComponent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
