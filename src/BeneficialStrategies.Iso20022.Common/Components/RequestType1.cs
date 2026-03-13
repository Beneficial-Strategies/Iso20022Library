// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the original transaction number.
/// </summary>
[IsoId("_0AWOcGHcEeGrBqfAqyy96Q")]
[DisplayName("Request Type")]
public partial record RequestType1
{
    #nullable enable
    
    /// <summary>
    /// Idetifies the transaction number.
    /// </summary>
    [IsoId("_py93vGHgEeGrBqfAqyy96Q")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; } 
    
    /// <summary>
    /// Identifies the type of information request related to an original transaction number as a code.
    /// </summary>
    [IsoId("_wc1usWHgEeGrBqfAqyy96Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SimpleValueList<TransactionRequestType1Code> Type { get; init; } = [];
    // ID for the above is _wc1usWHgEeGrBqfAqyy96Q
    
    /// <summary>
    /// Additional information, in free text form, to complement the requested information.
    /// </summary>
    [IsoId("_yowzsWHgEeGrBqfAqyy96Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
