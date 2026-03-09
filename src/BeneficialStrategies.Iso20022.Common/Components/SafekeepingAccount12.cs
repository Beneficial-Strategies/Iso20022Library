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
/// Identification and information about a securities account and balance.
/// </summary>
[IsoId("_jOHEkfQ9EeqAradXpAelDQ")]
[DisplayName("Safekeeping Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafekeepingAccount12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SafekeepingAccount12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SafekeepingAccount12( System.String reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jgtQd_Q9EeqAradXpAelDQ")]
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
    [IsoId("_jgtQefQ9EeqAradXpAelDQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification231Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_jgtQe_Q9EeqAradXpAelDQ")]
    [DisplayName("Sub Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctId")]
    #endif
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubAccountIdentification { get; init; } 
    #else
    public System.String? SubAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_jgtQffQ9EeqAradXpAelDQ")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    [MinLength(1)]
    [MaxLength(15)]
    public ValueList<HoldingBalance10> InstructedBalance { get; init; } = new ValueList<HoldingBalance10>(){};
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_jgtQf_Q9EeqAradXpAelDQ")]
    [DisplayName("Rights Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsHldr")]
    #endif
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(250)]
    public ValueList<PartyIdentification233Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification233Choice_>(){};
    
    /// <summary>
    /// Detailed information about the pledge.
    /// </summary>
    [IsoId("_nqkBwPQ9EeqAradXpAelDQ")]
    [DisplayName("Pledge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PldgDtls")]
    #endif
    [IsoXmlTag("PldgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PledgeInformation1? PledgeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PledgeInformation1? PledgeDetails { get; init; } 
    #else
    public PledgeInformation1? PledgeDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
