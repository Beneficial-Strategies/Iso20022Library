// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information related to the advising party.
/// </summary>
[IsoId("_GBqPw34hEeG2Zfa6JvOQSQ")]
[DisplayName("Advising Party Additional Information")]
public partial record AdvisingPartyAdditionalInformation1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned as a reference.
    /// </summary>
    [IsoId("_Br7wMH4iEeG2Zfa6JvOQSQ")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReferenceNumber { get; init; } 
    
    /// <summary>
    /// Additional information specific to the bank-to-beneficiary communication.
    /// </summary>
    [IsoId("_cw7w5zhZEeKfZIj_SwVRwA")]
    [DisplayName("Bank To Beneficiary Information")]
    [IsoXmlTag("BkToBnfcryInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> BankToBeneficiaryInformation { get; init; } = [];
    
    
    #nullable disable
    
}
