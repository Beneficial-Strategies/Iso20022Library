// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial institution.
/// </summary>
[IsoId("_U3JqwVOVEeijdq8ilaxyOA")]
[DisplayName("Financial Institution Identification")]
public partial record FinancialInstitutionIdentification16
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial institution expressed as a BIC.
    /// </summary>
    [IsoId("_nvIdZVOVEeijdq8ilaxyOA")]
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIDec2014Identifier)]
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_nvIdZlOVEeijdq8ilaxyOA")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification4Choice_? ClearingSystemMemberIdentification { get; init; } 
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_vThb4VOVEeijdq8ilaxyOA")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress5? NameAndAddress { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_VHX4E1OVEeijdq8ilaxyOA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_CZuQsVOWEeijdq8ilaxyOA")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProprietaryIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a specific branch of the financial institution.
    /// </summary>
    [IsoId("_P36UIFOWEeijdq8ilaxyOA")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData2? BranchIdentification { get; init; } 
    
    
    #nullable disable
    
}
