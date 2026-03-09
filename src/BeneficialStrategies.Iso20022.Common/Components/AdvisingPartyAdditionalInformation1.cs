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
/// Additional information related to the advising party.
/// </summary>
[IsoId("_GBqPw34hEeG2Zfa6JvOQSQ")]
[DisplayName("Advising Party Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdvisingPartyAdditionalInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned as a reference.
    /// </summary>
    [IsoId("_Br7wMH4iEeG2Zfa6JvOQSQ")]
    [DisplayName("Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefNb")]
    #endif
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferenceNumber { get; init; } 
    #else
    public System.String? ReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information specific to the bank-to-beneficiary communication.
    /// </summary>
    [IsoId("_cw7w5zhZEeKfZIj_SwVRwA")]
    [DisplayName("Bank To Beneficiary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkToBnfcryInf")]
    #endif
    [IsoXmlTag("BkToBnfcryInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> BankToBeneficiaryInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
