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
/// Specifies the voting entitlement for rights holders.
/// </summary>
[IsoId("_VIOZJ67yEemG7MmivSuE5g")]
[DisplayName("Eligible Position")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EligiblePosition8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EligiblePosition8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EligiblePosition8( System.String reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_Vcv3pa7yEemG7MmivSuE5g")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountIdentification { get; init; } 
    #else
    public System.String AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Vcv3p67yEemG7MmivSuE5g")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification223? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification223? AccountOwner { get; init; } 
    #else
    public PartyIdentification223? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    [IsoId("_Vcv3qa7yEemG7MmivSuE5g")]
    [DisplayName("Holding Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgBal")]
    #endif
    [IsoXmlTag("HldgBal")]
    [MinLength(0)]
    [MaxLength(15)]
    public ValueList<HoldingBalance9> HoldingBalance { get; init; } = new ValueList<HoldingBalance9>(){};
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_Vcv3q67yEemG7MmivSuE5g")]
    [DisplayName("Rights Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsHldr")]
    #endif
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification231> RightsHolder { get; init; } = new ValueList<PartyIdentification231>(){};
    
    
    #nullable disable
    
}
