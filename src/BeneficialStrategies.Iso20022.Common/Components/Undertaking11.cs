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
/// Details related to the local undertaking.
/// </summary>
[IsoId("_PjZ-2379EeGvEbxvurqpIg")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the requested new amount for the local undertaking.
    /// </summary>
    [IsoId("_PjZ-5X79EeGvEbxvurqpIg")]
    [DisplayName("New Undertaking Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewUdrtkgAmt")]
    #endif
    [IsoXmlTag("NewUdrtkgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingAmount2? NewUndertakingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount2? NewUndertakingAmount { get; init; } 
    #else
    public UndertakingAmount2? NewUndertakingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the requested new expiry terms for the local undertaking.
    /// </summary>
    [IsoId("_PjZ-4H79EeGvEbxvurqpIg")]
    [DisplayName("New Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewXpryDtls")]
    #endif
    [IsoXmlTag("NewXpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    #else
    public ExpiryDetails1? NewExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the requested new beneficiary for the local undertaking.
    /// </summary>
    [IsoId("_Z7SjNX7-EeGvEbxvurqpIg")]
    [DisplayName("New Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBnfcry")]
    #endif
    [IsoXmlTag("NewBnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? NewBeneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? NewBeneficiary { get; init; } 
    #else
    public PartyIdentification43? NewBeneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the requested new terms and conditions for the local undertaking.
    /// </summary>
    [IsoId("_4Bx1oH7-EeGvEbxvurqpIg")]
    [DisplayName("New Undertaking Terms And Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewUdrtkgTermsAndConds")]
    #endif
    [IsoXmlTag("NewUdrtkgTermsAndConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    #else
    public Narrative1? NewUndertakingTermsAndConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the delivery channel for the amended local undertaking.
    /// </summary>
    [IsoId("_KR6lIH7_EeGvEbxvurqpIg")]
    [DisplayName("Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryChanl")]
    #endif
    [IsoXmlTag("DlvryChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #else
    public CommunicationChannel1? DeliveryChannel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
