// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number assigned by a government agency to identify foreign nationals.
/// </summary>
[IsoId("_AUpPwNokEeC60axPepSq7g_151195730")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount20
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_AUpPwdokEeC60axPepSq7g_37356664")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Choice between a code and a data source scheme to identify the type of account.
    /// </summary>
    [IsoId("_AUyZsNokEeC60axPepSq7g_-845876623")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ClearingAccountType1Code Type { get; init; } 
    
    /// <summary>
    /// .
    /// </summary>
    [IsoId("_AUyZsdokEeC60axPepSq7g_-1842948976")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    
    #nullable disable
    
}
