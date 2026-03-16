// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response Type12.
/// </summary>
[IsoId("_1IgUcZ9REe-nbM0aSPcoiQ")]
[DisplayName("Response Type12")]
public partial record ResponseType12
{
    #nullable enable

    /// <summary>
    /// Additional Response Information.
    /// </summary>
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response12Code Response { get; init; } 

    /// <summary>
    /// Response Reason.
    /// </summary>
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public ResultDetail5Code? ResponseReason { get; init; } 

    
    #nullable disable
    
}
