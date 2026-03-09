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
/// Profile of the customer selected by an ATM.
/// </summary>
[IsoId("_WGD8Ya14EeWMg5rOByfExw")]
[DisplayName("ATM Customer Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCustomerProfile4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCustomerProfile4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCustomerProfile4( ATMCustomerProfile1Code reqRetrievalMode )
    {
        RetrievalMode = reqRetrievalMode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Describes the main way customer information was collected to build up the customer menu and to provide the service.
    /// </summary>
    [IsoId("_WR-4ga14EeWMg5rOByfExw")]
    [DisplayName("Retrieval Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrvlMd")]
    #endif
    [IsoXmlTag("RtrvlMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCustomerProfile1Code RetrievalMode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCustomerProfile1Code RetrievalMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCustomerProfile1Code RetrievalMode { get; init; } 
    #else
    public ATMCustomerProfile1Code RetrievalMode { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the customer profile.
    /// </summary>
    [IsoId("_WR-4g614EeWMg5rOByfExw")]
    [DisplayName("Profile Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrflRef")]
    #endif
    [IsoXmlTag("PrflRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProfileReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProfileReference { get; init; } 
    #else
    public System.String? ProfileReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the customer for the bank.
    /// </summary>
    [IsoId("_WR-4ha14EeWMg5rOByfExw")]
    [DisplayName("Customer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrId")]
    #endif
    [IsoXmlTag("CstmrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CustomerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerIdentification { get; init; } 
    #else
    public System.String? CustomerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
