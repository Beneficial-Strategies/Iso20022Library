// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a range of securities accounts.
/// </summary>
[IsoId("_4H1_peGBEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Range")]
public partial record SecuritiesAccountRange2
{
    #nullable enable
    
    /// <summary>
    /// Securities account number or code at which the range starts.
    /// </summary>
    [IsoId("_4UfUgeGBEeWCAvUNsZ5u6g")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required SecuritiesAccount19 From { get; init; } 
    
    /// <summary>
    /// Securities account number or code at which the range ends.
    /// </summary>
    [IsoId("_4UfUg-GBEeWCAvUNsZ5u6g")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required SecuritiesAccount19 To { get; init; } 
    
    
    #nullable disable
    
}
