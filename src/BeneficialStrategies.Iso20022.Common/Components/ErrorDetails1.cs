// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the error
/// </summary>
[IsoId("_BixN8ccuEeiYIbmhB2-RrQ")]
[DisplayName("Error Details")]
public record ErrorDetails1
{
    /// <summary>
    /// Code list containing a code that identifies the error condition.
    /// </summary>
    [IsoId("_nOwFsPGtEeiGNursv3uE_g")]
    [DisplayName("Message Error Type")]
    [IsoXmlTag("MsgErrTp")]
    public required MessageError1Code MessageErrorType { get; init; }

    /// <summary>
    /// Other message error type defined at national or private level.
    /// </summary>
    [IsoId("_sd_xwPGtEeiGNursv3uE_g")]
    [DisplayName("Other Message Error Type")]
    [IsoXmlTag("OthrMsgErrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherMessageErrorType { get; init; }

    /// <summary>
    /// Error code defined in ISO 8583:2003 table A.10 Message error codes (bit 18).
    /// </summary>
    [IsoId("_Sw4i8McyEeiYIbmhB2-RrQ")]
    [DisplayName("Error Code")]
    [IsoXmlTag("ErrCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ErrorCode { get; init; }

    /// <summary>
    /// Other Message Error Code.
    /// </summary>
    [IsoId("_ZavL0McyEeiYIbmhB2-RrQ")]
    [DisplayName("Error Description")]
    [IsoXmlTag("ErrDesc")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? ErrorDescription { get; init; }

    /// <summary>
    /// Data element in error.
    /// </summary>
    [IsoId("_uYYqcMcyEeiYIbmhB2-RrQ")]
    [DisplayName("Data Element In Error")]
    [IsoXmlTag("DataElmtInErr")]
    public SimpleValueList<IsoMax4000Text> DataElementInError { get; init; } = [];
}
