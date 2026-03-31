// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document Line Information2.
/// </summary>
[IsoId("_eZxMgTE4Ee62xuUQ2zyZww")]
[DisplayName("Document Line Information2")]
public record DocumentLineInformation2
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public RemittanceAmount4? Amount { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax2048Text? Description { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<DocumentLineIdentification1> Identification { get; init; } = [];
}
