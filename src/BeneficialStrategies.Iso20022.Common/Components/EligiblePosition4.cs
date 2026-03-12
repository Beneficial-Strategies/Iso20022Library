// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement.
/// </summary>
[IsoId("_R7tcwtp-Ed-ak6NoX_4Aeg_-758914703")]
[DisplayName("Eligible Position")]
public partial record EligiblePosition4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_R73NwNp-Ed-ak6NoX_4Aeg_-1970577751")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Identifies party that legally owns the account.
    /// </summary>
    [IsoId("_R73Nwdp-Ed-ak6NoX_4Aeg_1436711571")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification39? AccountOwner { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_R73Nwtp-Ed-ak6NoX_4Aeg_632876877")]
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<HoldingBalance6> HoldingBalance { get; init; } = new ValueList<HoldingBalance6>(){};
    
    /// <summary>
    /// Identifies owner of the voting rights.
    /// </summary>
    [IsoId("_R73Nw9p-Ed-ak6NoX_4Aeg_1847729299")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification39> RightsHolder { get; init; } = new ValueList<PartyIdentification39>(){};
    
    
    #nullable disable
    
}
