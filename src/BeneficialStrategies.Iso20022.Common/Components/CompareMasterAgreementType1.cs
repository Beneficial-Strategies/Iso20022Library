// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a master agreement type.
/// </summary>
[IsoId("_qF8XgExYEeywvc16MwOPfw")]
[DisplayName("Compare Master Agreement Type")]
public partial record CompareMasterAgreementType1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_2sRl4ExYEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public AgreementType2Choice_? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_4v-jAExYEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public AgreementType2Choice_? Value2 { get; init; } 
    
    
    #nullable disable
    
}
