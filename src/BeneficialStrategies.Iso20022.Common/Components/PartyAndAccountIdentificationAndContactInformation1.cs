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
/// Entity involved in an activity.
/// </summary>
[IsoId("_Pb-D4Np-Ed-ak6NoX_4Aeg_1550606090")]
[DisplayName("Party And Account Identification And Contact Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyAndAccountIdentificationAndContactInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyAndAccountIdentificationAndContactInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyAndAccountIdentificationAndContactInformation1( PartyIdentification8 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_Pb-D4dp-Ed-ak6NoX_4Aeg_1550606183")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8 PartyIdentification { get; init; } 
    #else
    public PartyIdentification8 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_Pb-D4tp-Ed-ak6NoX_4Aeg_1550606461")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? AccountIdentification { get; init; } 
    #else
    public CashAccount7? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_Pb-D49p-Ed-ak6NoX_4Aeg_-620262996")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? ContactInformation { get; init; } 
    #else
    public ContactIdentification1? ContactInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
