// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services that have been or are to be performed in conjunction with the transaction.
/// </summary>
[IsoId("_n_3QoRN4EfC1ZfCQz0xB3g")]
[DisplayName("Additional Service3")]
public record AdditionalService3
{
    /// <summary>
    /// Type of additional service applied to the transaction.
    /// </summary>
    [IsoId("_oHY08RN4EfC1ZfCQz0xB3g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdditionalServiceType3Code Type { get; init; }

    /// <summary>
    /// Sub type of the additional service.
    /// </summary>
    [IsoId("_cIp1IBUEEfC_aaedwHHlmw")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax10Text? SubType { get; init; }

    /// <summary>
    /// Result from performing the identified service.
    /// </summary>
    [IsoId("_oHdtcxN4EfC1ZfCQz0xB3g")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public ISO8583AdditionalServiceResultCode? Result { get; init; }

    /// <summary>
    /// Contains additional information for the execution or results of the service.
    /// </summary>
    [IsoId("_oHdtdxN4EfC1ZfCQz0xB3g")]
    [DisplayName("Detail")]
    [IsoXmlTag("Dtl")]
    public LaxProcessing? Detail { get; init; }
}
