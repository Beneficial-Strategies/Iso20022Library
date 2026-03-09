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
/// Defines the securities account position query criteria.
/// </summary>
[IsoId("_3wfPkeGBEeWCAvUNsZ5u6g")]
[DisplayName("Position Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PositionSearchCriteria2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PositionSearchCriteria2( System.String reqReturnZeroPosition )
    {
        ReturnZeroPosition = reqReturnZeroPosition;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_38iukeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? AccountOwner { get; init; } 
    #else
    public PartyIdentification100? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_38iuk-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? AccountServicer { get; init; } 
    #else
    public PartyIdentification100? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_38iuleGBEeWCAvUNsZ5u6g")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount2Choice_? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount2Choice_? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount2Choice_? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-à-vis the issuer.
    /// </summary>
    [IsoId("_38iul-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrm")]
    #endif
    [IsoXmlTag("FinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrument { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the security is issued.
    /// </summary>
    [IsoId("_38iumeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Country Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIsse")]
    #endif
    [IsoXmlTag("CtryOfIsse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfIssue { get; init; } 
    #else
    public string? CountryOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Defines specific restriction characteristics for a securities position.
    /// </summary>
    [IsoId("_38ium-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalTp")]
    #endif
    [IsoXmlTag("SubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesBalanceType7Choice_? SubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType7Choice_? SubBalanceType { get; init; } 
    #else
    public SecuritiesBalanceType7Choice_? SubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Option to provide output zero position in the results.
    /// </summary>
    [IsoId("_38iuneGBEeWCAvUNsZ5u6g")]
    [DisplayName("Return Zero Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrZeroPos")]
    #endif
    [IsoXmlTag("RtrZeroPos")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ReturnZeroPosition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReturnZeroPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReturnZeroPosition { get; init; } 
    #else
    public System.String ReturnZeroPosition { get; set; } 
    #endif
    
    
    #nullable disable
    
}
