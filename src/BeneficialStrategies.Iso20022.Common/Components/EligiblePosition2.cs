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
/// Specifies the voting entitlement.
/// </summary>
[IsoId("_R_4yK9p-Ed-ak6NoX_4Aeg_968137287")]
[DisplayName("Eligible Position")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EligiblePosition2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_R_4yLNp-Ed-ak6NoX_4Aeg_968137289")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies party that legally owns the account.
    /// </summary>
    [IsoId("_SACjINp-Ed-ak6NoX_4Aeg_753462259")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification9Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification9Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_SACjIdp-Ed-ak6NoX_4Aeg_1972671566")]
    [DisplayName("Holding Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgBal")]
    #endif
    [IsoXmlTag("HldgBal")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<HoldingBalance3> HoldingBalance { get; init; } = new ValueList<HoldingBalance3>(){};
    
    /// <summary>
    /// Identifies owner of the voting rights.
    /// </summary>
    [IsoId("_SACjItp-Ed-ak6NoX_4Aeg_757155583")]
    [DisplayName("Rights Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsHldr")]
    #endif
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification9Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification9Choice_>(){};
    
    
    #nullable disable
    
}
