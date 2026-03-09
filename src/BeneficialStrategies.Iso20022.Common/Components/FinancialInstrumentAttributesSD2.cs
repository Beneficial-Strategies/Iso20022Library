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
/// Provides additional information regarding security that will be distributed as part of entitlement.
/// </summary>
[IsoId("_1RIYYjL3EeKU9IrkkToqcw_1649073602")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Security identification of the security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_1RIYYzL3EeKU9IrkkToqcw_805259150")]
    [DisplayName("Declared Disbursed Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdDsbrsdSctyId")]
    #endif
    [IsoXmlTag("DclrdDsbrsdSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification15? DeclaredDisbursedSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15? DeclaredDisbursedSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification15? DeclaredDisbursedSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Declared disbursed security description.
    /// </summary>
    [IsoId("_1RIYZDL3EeKU9IrkkToqcw_1268382321")]
    [DisplayName("Declared Disbursed Security Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdDsbrsdSctyDesc")]
    #endif
    [IsoXmlTag("DclrdDsbrsdSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? DeclaredDisbursedSecurityDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclaredDisbursedSecurityDescription { get; init; } 
    #else
    public System.String? DeclaredDisbursedSecurityDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
