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
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_ATmG49okEeC60axPepSq7g_-553643562")]
[DisplayName("Confirmation Party Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConfirmationPartyDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ConfirmationPartyDetails3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ConfirmationPartyDetails3( PartyIdentification32Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_ATmG5NokEeC60axPepSq7g_-667482628")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification32Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification32Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32Choice_ Identification { get; init; } 
    #else
    public PartyIdentification32Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ATmG5dokEeC60axPepSq7g_-1664554981")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount3? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount3? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount3? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_ATv34NokEeC60axPepSq7g_1633339962")]
    [DisplayName("Cash Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshDtls")]
    #endif
    [IsoXmlTag("CshDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification3Choice_? CashDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification3Choice_? CashDetails { get; init; } 
    #else
    public AccountIdentification3Choice_? CashDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_ATv34dokEeC60axPepSq7g_2115235766")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification5? AlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_ATv34tokEeC60axPepSq7g_102923008")]
    [DisplayName("Processing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgId")]
    #endif
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcessingIdentification { get; init; } 
    #else
    public System.String? ProcessingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_ATv349okEeC60axPepSq7g_-1707786691")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyTextInformation5? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyTextInformation5? AdditionalInformation { get; init; } 
    #else
    public PartyTextInformation5? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Capacity of customer placing the order. Primarily used by futures exchanges to indicate the CTI code (customer type indicator) as required by the US CFTC (Commodity Futures Trading Commission).
    /// </summary>
    [IsoId("_ATv35NokEeC60axPepSq7g_-1902030237")]
    [DisplayName("Party Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyCpcty")]
    #endif
    [IsoXmlTag("PtyCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingPartyCapacity2Choice_? PartyCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingPartyCapacity2Choice_? PartyCapacity { get; init; } 
    #else
    public TradingPartyCapacity2Choice_? PartyCapacity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
