// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Account Statement3.
/// </summary>
[IsoId("_6Q3v8aETEe-MRKYsaX6JDg")]
[DisplayName("ATM Account Statement3")]
public partial record ATMAccountStatement3
{
    #nullable enable

    /// <summary>
    /// Account Identifier.
    /// </summary>
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public required AccountIdentification80Choice_ AccountIdentifier { get; init; } 

    /// <summary>
    /// Account Name.
    /// </summary>
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax70Text? AccountName { get; init; } 

    /// <summary>
    /// Account Statement.
    /// </summary>
    [DisplayName("Account Statement")]
    [IsoXmlTag("AcctStmt")]
    public ValueList<ATMAccountStatement2> AccountStatement { get; init; } = [];

    
    #nullable disable
    
}
