// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Funds transfer service
/// </summary>
[IsoId("__MxEsEUTEeea-M6VZkEPUw")]
[DisplayName("Transfer Service")]
public record TransferService1
{
    /// <summary>
    /// Identification of the funding service provider.
    /// </summary>
    [IsoId("_Zywr4EUUEeea-M6VZkEPUw")]
    [DisplayName("Service Provider")]
    [IsoXmlTag("SvcPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceProvider { get; init; }

    /// <summary>
    /// Name of the funding service (for example, MoneyGram, Western Union, etc.).
    /// </summary>
    [IsoId("_i6qEgEUUEeea-M6VZkEPUw")]
    [DisplayName("Service Name")]
    [IsoXmlTag("SvcNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceName { get; init; }

    /// <summary>
    /// Reference to the funding service.
    /// </summary>
    [IsoId("_qNfY8EUUEeea-M6VZkEPUw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Purpose of the transfer. For example: person to person, business-to-business and mobile top-up.
    /// </summary>
    [IsoId("_3dKWwdIsEeirx-13kKhDlQ")]
    [DisplayName("Business Purpose")]
    [IsoXmlTag("BizPurp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BusinessPurpose { get; init; }

    /// <summary>
    /// Free text that can be used between the sender and the receiver to describe the details of the transfer.
    /// </summary>
    [IsoId("_8KdMUdIsEeirx-13kKhDlQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; }
}
