// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the request.
/// </summary>
[IsoId("_RZlnI9p-Ed-ak6NoX_4Aeg_-946650708")]
[DisplayName("Receipt Details")]
public partial record ReceiptDetails1
{
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    [IsoId("_RZlnJNp-Ed-ak6NoX_4Aeg_1612827078")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReferences RelatedReference { get; init; } 
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_RZlnJdp-Ed-ak6NoX_4Aeg_1612826800")]
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public RequestHandling? RequestHandling { get; init; } 
    
    
    #nullable disable
    
}
