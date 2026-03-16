// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Financial Request Content Component5.
/// </summary>
[IsoId("_SmEB0Z9WEe-nbM0aSPcoiQ")]
[DisplayName("Non Financial Request Content Component5")]
public partial record NonFinancialRequestContentComponent5
{
    #nullable enable

    /// <summary>
    /// Additional Request.
    /// </summary>
    [DisplayName("Additional Request")]
    [IsoXmlTag("AddtlReq")]
    public ExternallyDefinedData5? AdditionalRequest { get; init; } 

    /// <summary>
    /// Non Financial Request Type.
    /// </summary>
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public ValueList<NonFinancialRequestType2Code> NonFinancialRequestType { get; init; } = [];

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction139? Transaction { get; init; } 

    
    #nullable disable
    
}
