// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the error.
/// </summary>
[IsoId("_Kc48cUMDEfCQAqQ9lolFUg")]
[DisplayName("Error Details4")]
public record ErrorDetails4
{
    /// <summary>
    /// Code list containing a code that identifies the error condition.
    /// </summary>
    [IsoId("_KfPF0UMDEfCQAqQ9lolFUg")]
    [DisplayName("Error Code")]
    [IsoXmlTag("ErrCd")]
    public required ISO8583MessageErrorCode ErrorCode { get; init; }

    /// <summary>
    /// Code that identifies the severity of the errors found in the message.
    /// </summary>
    [IsoId("_KfPF20MDEfCQAqQ9lolFUg")]
    [DisplayName("Severity Code")]
    [IsoXmlTag("svrtyCd")]
    public IsoMax2NumericText? SeverityCode { get; init; }

    /// <summary>
    /// Description of the error found.
    /// </summary>
    [IsoId("_KfPF3UMDEfCQAqQ9lolFUg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax500Text? Description { get; init; }

    /// <summary>
    /// Data element in error.
    /// </summary>
    [IsoId("_KfPF30MDEfCQAqQ9lolFUg")]
    [DisplayName("Data Element In Error")]
    [IsoXmlTag("DataElmtInErr")]
    public SimpleValueList<IsoMax4000Text> DataElementInError { get; init; } = [];
}
