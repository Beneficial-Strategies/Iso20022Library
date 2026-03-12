// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial request.
/// </summary>
[IsoId("_V15BwU3kEey_VecAUE-C9Q")]
[DisplayName("Non Financial Request Content Component")]
public partial record NonFinancialRequestContentComponent2
{
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acceptor wants to be processed.
    /// </summary>
    [IsoId("_V9OY0U3kEey_VecAUE-C9Q")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public SimpleValueList<NonFinancialRequestType1Code> NonFinancialRequestType { get; init; } = new SimpleValueList<NonFinancialRequestType1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _V9OY0U3kEey_VecAUE-C9Q
    
    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_V9OY003kEey_VecAUE-C9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardPaymentTransaction119? Transaction { get; init; } 
    
    
    #nullable disable
    
}
