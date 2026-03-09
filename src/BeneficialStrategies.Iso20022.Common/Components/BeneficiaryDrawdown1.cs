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
/// Information about the beneficiary of a drawdown.
/// </summary>
[IsoId("_l8_kcFNgEeijdq8ilaxyOA")]
[DisplayName("Beneficiary Drawdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BeneficiaryDrawdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of beneficiary.
    /// </summary>
    [IsoId("_q0YKIFNgEeijdq8ilaxyOA")]
    [DisplayName("Beneficiary Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryTp")]
    #endif
    [IsoXmlTag("BnfcryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryType1Choice_? BeneficiaryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryType1Choice_? BeneficiaryType { get; init; } 
    #else
    public BeneficiaryType1Choice_? BeneficiaryType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the original pension holder was under the age limit when deceased. Typically, in the UK this limit is seventy-five.
    /// </summary>
    [IsoId("_salS8FNgEeijdq8ilaxyOA")]
    [DisplayName("Death Under Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DthUdrLmt")]
    #endif
    [IsoXmlTag("DthUdrLmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DeathUnderLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeathUnderLimit { get; init; } 
    #else
    public System.String? DeathUnderLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the recipient of the drawdown.
    /// </summary>
    [IsoId("_7qdhYZC0EeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
