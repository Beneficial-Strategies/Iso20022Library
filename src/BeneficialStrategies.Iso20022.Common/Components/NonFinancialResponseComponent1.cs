// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a non financial request.
/// </summary>
[IsoId("_CTdnwC_uEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Response Component")]
public partial record NonFinancialResponseComponent1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_3hVvtC_yEeugIJ3Gvoevmg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; } 
    
    /// <summary>
    /// Response of the non financial request.
    /// </summary>
    [IsoId("_3hVvti_yEeugIJ3Gvoevmg")]
    [DisplayName("Response Content")]
    [IsoXmlTag("RspnCntt")]
    public ValueList<NonFinancialResponseContentComponent1> ResponseContent { get; init; } = new ValueList<NonFinancialResponseContentComponent1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _3hVvti_yEeugIJ3Gvoevmg
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_Hwe30S_zEeugIJ3Gvoevmg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_3hVvty_yEeugIJ3Gvoevmg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
