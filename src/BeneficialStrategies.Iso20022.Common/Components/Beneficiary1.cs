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
/// Details related to the beneficiary.
/// </summary>
[IsoId("_-EXduHltEeG7BsjMvd1mEw_-57311934")]
[DisplayName("Beneficiary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Beneficiary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Beneficiary1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Beneficiary1( AddressOrParty1Choice_ reqNewAddressOrNewBeneficiary )
    {
        NewAddressOrNewBeneficiary = reqNewAddressOrNewBeneficiary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// New beneficiary address, or new beneficiary name and address.
    /// </summary>
    [IsoId("_-EXduXltEeG7BsjMvd1mEw_-1298911644")]
    [DisplayName("New Address Or New Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAdrOrNewBnfcry")]
    #endif
    [IsoXmlTag("NewAdrOrNewBnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AddressOrParty1Choice_ NewAddressOrNewBeneficiary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AddressOrParty1Choice_ NewAddressOrNewBeneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressOrParty1Choice_ NewAddressOrNewBeneficiary { get; init; } 
    #else
    public AddressOrParty1Choice_ NewAddressOrNewBeneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information concerning the amended beneficiary details.
    /// </summary>
    [IsoId("_-EhOsHltEeG7BsjMvd1mEw_1955117019")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
