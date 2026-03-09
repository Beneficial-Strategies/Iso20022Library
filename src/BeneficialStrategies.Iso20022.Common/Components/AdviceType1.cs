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
/// Specifies the type of advice to report back for the transaction.
/// </summary>
[IsoId("_5ZNFsNolEembTrt_WixjyQ")]
[DisplayName("Advice Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdviceType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of credit advice requested.
    /// </summary>
    [IsoId("_bQTjANomEembTrt_WixjyQ")]
    [DisplayName("Credit Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtAdvc")]
    #endif
    [IsoXmlTag("CdtAdvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdviceType1Choice_? CreditAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdviceType1Choice_? CreditAdvice { get; init; } 
    #else
    public AdviceType1Choice_? CreditAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Type de debit advice requested.
    /// </summary>
    [IsoId("_fU3koNomEembTrt_WixjyQ")]
    [DisplayName("Debit Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtAdvc")]
    #endif
    [IsoXmlTag("DbtAdvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdviceType1Choice_? DebitAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdviceType1Choice_? DebitAdvice { get; init; } 
    #else
    public AdviceType1Choice_? DebitAdvice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
