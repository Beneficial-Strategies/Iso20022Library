// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the infromation on the type of the master agrement are matching or not.
/// </summary>
[IsoId("_FHLgwKxoEem81-uIvTF5rQ")]
[DisplayName("Compare Agreement Type")]
public partial record CompareAgreementType1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_LsvfgKxoEem81-uIvTF5rQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public AgreementType1Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_NrttoKxoEem81-uIvTF5rQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public AgreementType1Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
