// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a date code and a time.
/// </summary>
[IsoId("_ctczB5KQEeWHWpTQn1FFVg")]
[DisplayName("Date Code And Time Format")]
public partial record DateCodeAndTimeFormat4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_ctczCZKQEeWHWpTQn1FFVg")]
    [DisplayName("Date Code")]
    [IsoXmlTag("DtCd")]
    public required DateCode26Choice_ DateCode { get; init; } 
    
    /// <summary>
    /// Specifies the time.
    /// </summary>
    [IsoId("_ctczEZKQEeWHWpTQn1FFVg")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime Time { get; init; } 
    
    
    #nullable disable
    
}
