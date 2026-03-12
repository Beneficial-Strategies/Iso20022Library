// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional details to clarify response codes.
/// </summary>
[IsoId("_W-pnUBE7EeafpqhYGpTDnw")]
[DisplayName("Response Details")]
public partial record ResponseDetails1
{
    #nullable enable
    
    /// <summary>
    /// Code for account servicer warnings, rejections, pay no/pay responses and technical rejections. 
    /// </summary>
    [IsoId("_kLn-8BE7EeafpqhYGpTDnw")]
    [DisplayName("Response Code")]
    [IsoXmlTag("RspnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ResponseCode { get; init; } 
    
    /// <summary>
    /// Additional information to elaborate upon response codes.
    /// </summary>
    [IsoId("_n4DNYBE7EeafpqhYGpTDnw")]
    [DisplayName("Additional Details")]
    [IsoXmlTag("AddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalDetails { get; init; } 
    
    
    #nullable disable
    
}
