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
/// Identification of a party. The party can be identified by providing the party&apos;s name and optionally, the BIC, account number, address, clearing system identification or LEI can also be provided.
/// </summary>
[IsoId("_dhBo04KOEeKmtdhZXgREOQ")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification59
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party expressed as the party&apos;s name.
    /// </summary>
    [IsoId("_MtaPwIKQEeKmtdhZXgREOQ")]
    [DisplayName("Party Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyNm")]
    #endif
    [IsoXmlTag("PtyNm")]
    [IsoSimpleType(IsoSimpleType.Max34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax34Text? PartyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartyName { get; init; } 
    #else
    public System.String? PartyName { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party expressed as a BIC and an optional alternative identifier.
    /// </summary>
    [IsoId("_ocnb44YsEeKuscgzs7HVKw")]
    [DisplayName("Any BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnyBIC")]
    #endif
    [IsoXmlTag("AnyBIC")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification44? AnyBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification44? AnyBIC { get; init; } 
    #else
    public PartyIdentification44? AnyBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party&apos;s account number.
    /// </summary>
    [IsoId("_vbjUsIKOEeKmtdhZXgREOQ")]
    [DisplayName("Account Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNb")]
    #endif
    [IsoXmlTag("AcctNb")]
    [IsoSimpleType(IsoSimpleType.Max34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax34Text? AccountNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountNumber { get; init; } 
    #else
    public System.String? AccountNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party&apos;s address.
    /// </summary>
    [IsoId("_nGNk8IKPEeKmtdhZXgREOQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Address { get; init; } 
    #else
    public System.String? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of a clearing system identifier.
    /// </summary>
    [IsoId("_VwsfQIoREeKINPO736UM8w")]
    [DisplayName("Clearing System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSysId")]
    #endif
    [IsoXmlTag("ClrSysId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; } 
    #else
    public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_HxyqUIKQEeKmtdhZXgREOQ")]
    [DisplayName("Legal Entity Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglNttyIdr")]
    #endif
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalEntityIdentifier { get; init; } 
    #else
    public System.String? LegalEntityIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
