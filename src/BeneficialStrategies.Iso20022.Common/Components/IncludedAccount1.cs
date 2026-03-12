// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the account that is impacted or not by the standing instruction.
/// </summary>
[IsoId("_QUmVCNp-Ed-ak6NoX_4Aeg_1997970663")]
[DisplayName("Included Account")]
public partial record IncludedAccount1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_QUwGANp-Ed-ak6NoX_4Aeg_-2068886946")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SecuritiesAccountIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the account is impacted or not by the standing instruction.||Yes = The account is impacted by the standing instruction.|No = The account is not impacted by the standing instruction.
    /// </summary>
    [IsoId("_QUwGAdp-Ed-ak6NoX_4Aeg_-2068886937")]
    [DisplayName("Included Indicator")]
    [IsoXmlTag("InclInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator IncludedIndicator { get; init; } 
    
    
    #nullable disable
    
}
