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
[IsoId("_QTHHTNp-Ed-ak6NoX_4Aeg_1270123926")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_QTQRMNp-Ed-ak6NoX_4Aeg_1327384647")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Choice between a code and a data source scheme to identify the type of account.
    /// </summary>
    [IsoId("_QTQRMdp-Ed-ak6NoX_4Aeg_1412348342")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode1Choice_? Type { get; init; } 
    
    /// <summary>
    /// .
    /// </summary>
    [IsoId("_QTQRMtp-Ed-ak6NoX_4Aeg_1370786787")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    
    #nullable disable
    
}
