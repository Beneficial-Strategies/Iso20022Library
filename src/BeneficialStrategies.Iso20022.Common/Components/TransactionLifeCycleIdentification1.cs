// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique global identification structure used to match transactions throughout their lifecycle (for example, authorisation to financial, financial to chargebacks, etc.).
/// It shall contain the same value in all messages throughout a transaction&apos;s lifecycle.
/// ISO 8583:2003 bit 21
/// </summary>
[IsoId("_5kV_sER7Eeeb1MmUPTrSMw")]
[DisplayName("Transaction Life Cycle Identification")]
public record TransactionLifeCycleIdentification1
{
    /// <summary>
    /// Unique transaction identifier.
    /// ISO 8583:2003 bit 21-2
    /// </summary>
    [IsoId("_URUEoKdZEeiva6IOmhpVHw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Exact15Text)]
    public required IsoExact15Text Identification { get; init; }

    /// <summary>
    /// Contains authorisation sequence number.
    /// </summary>
    [IsoId("_uA1W0KdZEeiva6IOmhpVHw")]
    [DisplayName("Authorisation Sequence Number")]
    [IsoXmlTag("AuthstnSeqNb")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; }

    /// <summary>
    /// Number used with trace identifier to uniquely identify where a single authorisation was obtained covering a number of financial presentments.
    /// ISO 8583:2003 bit 21-3
    /// </summary>
    [IsoId("_27MCsKdZEeiva6IOmhpVHw")]
    [DisplayName("Presentment Sequence Number")]
    [IsoXmlTag("PresntmntSeqNb")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; }

    /// <summary>
    /// Expected maximum number of presentments for this transaction.
    /// </summary>
    [IsoId("_8vlqQKdZEeiva6IOmhpVHw")]
    [DisplayName("Presentment Sequence Count")]
    [IsoXmlTag("PresntmntSeqCnt")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; }

    /// <summary>
    /// Code calculated using an algorithm against key transaction data elements that are common to both authorisation and financial messages.
    /// ISO 8583:2003 bit 21-4
    /// </summary>
    [IsoId("_A0fqIKdaEeiva6IOmhpVHw")]
    [DisplayName("Authentication Token")]
    [IsoXmlTag("AuthntcnTkn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AuthenticationToken { get; init; }
}
