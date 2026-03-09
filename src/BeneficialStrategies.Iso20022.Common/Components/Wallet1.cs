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
/// Container for tenders used by the customer to perform the payment transaction.
/// </summary>
[IsoId("_kmWJIEanEeeIjf8aP9KbJA")]
[DisplayName("Wallet")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Wallet1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the wallet.
    /// </summary>
    [IsoId("_LWrmQEaoEeeIjf8aP9KbJA")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? Provider { get; init; } 
    #else
    public PartyIdentification197? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Additional data associated with wallet.
    /// </summary>
    [IsoId("_Xa5YkBWJEeiTbY4xN42WAw")]
    [DisplayName("Additional Wallet Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlWlltData")]
    #endif
    [IsoXmlTag("AddtlWlltData")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalWalletData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalWalletData { get; init; } 
    #else
    public System.String? AdditionalWalletData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
