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
/// Specifies corporate action quantities.
/// </summary>
[IsoId("_ldPQwRu1EeyhRdHRjakS2w")]
[DisplayName("Corporate Action Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionQuantity12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_lyZocxu1EeyhRdHRjakS2w")]
    [DisplayName("Base Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseDnmtn")]
    #endif
    [IsoXmlTag("BaseDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity35Choice_? BaseDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity35Choice_? BaseDenomination { get; init; } 
    #else
    public FinancialInstrumentQuantity35Choice_? BaseDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_lyZoexu1EeyhRdHRjakS2w")]
    [DisplayName("Incremental Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrmtlDnmtn")]
    #endif
    [IsoXmlTag("IncrmtlDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity35Choice_? IncrementalDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity35Choice_? IncrementalDenomination { get; init; } 
    #else
    public FinancialInstrumentQuantity35Choice_? IncrementalDenomination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
