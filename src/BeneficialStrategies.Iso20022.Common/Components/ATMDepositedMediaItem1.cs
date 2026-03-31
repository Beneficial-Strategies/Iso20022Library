// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Deposited Media Item1.
/// </summary>
[IsoId("_9MMZ0J2rEe-4seDr3Li2Ew")]
[DisplayName("ATM Deposited Media Item1")]
public record ATMDepositedMediaItem1
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<GenericInformation1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Code Line.
    /// </summary>
    [DisplayName("Code Line")]
    [IsoXmlTag("CdLine")]
    public IsoMax70Text? CodeLine { get; init; }

    /// <summary>
    /// Code Line Format.
    /// </summary>
    [DisplayName("Code Line Format")]
    [IsoXmlTag("CdLineFrmt")]
    public CheckCodeLine1Code? CodeLineFormat { get; init; }

    /// <summary>
    /// Confidence Level.
    /// </summary>
    [DisplayName("Confidence Level")]
    [IsoXmlTag("CnfdncLvl")]
    public IsoPercentageRate? ConfidenceLevel { get; init; }

    /// <summary>
    /// Count.
    /// </summary>
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    public IsoNumber? Count { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Media Identification.
    /// </summary>
    [DisplayName("Media Identification")]
    [IsoXmlTag("MdiaId")]
    public IsoMax70Text? MediaIdentification { get; init; }

    /// <summary>
    /// Media Status.
    /// </summary>
    [DisplayName("Media Status")]
    [IsoXmlTag("MdiaSts")]
    public ATMMediaStatus1Code? MediaStatus { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax70Text? Reference { get; init; }

    /// <summary>
    /// Rejected Reason.
    /// </summary>
    [DisplayName("Rejected Reason")]
    [IsoXmlTag("RjctdRsn")]
    public IsoMax70Text? RejectedReason { get; init; }

    /// <summary>
    /// Scanned Value.
    /// </summary>
    [DisplayName("Scanned Value")]
    [IsoXmlTag("ScnndVal")]
    public ImpliedCurrencyAndAmount? ScannedValue { get; init; }

    /// <summary>
    /// Unit Value.
    /// </summary>
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public ImpliedCurrencyAndAmount? UnitValue { get; init; }
}
