// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Record3.
/// </summary>
[IsoId("_lw9CQY1KEe6S0_1AaJzQCA")]
[DisplayName("Record3")]
public record Record3
{
    /// <summary>
    /// Agent Fee Amount.
    /// </summary>
    [DisplayName("Agent Fee Amount")]
    [IsoXmlTag("AgtFeeAmt")]
    public ImpliedCurrencyAndAmount? AgentFeeAmount { get; init; }

    /// <summary>
    /// Agent Fee Credit Debit.
    /// </summary>
    [DisplayName("Agent Fee Credit Debit")]
    [IsoXmlTag("AgtFeeCdtDbt")]
    public CreditDebit3Code? AgentFeeCreditDebit { get; init; }

    /// <summary>
    /// Agent Fee Currency.
    /// </summary>
    [DisplayName("Agent Fee Currency")]
    [IsoXmlTag("AgtFeeCcy")]
    public ISO3NumericCurrencyCode? AgentFeeCurrency { get; init; }

    /// <summary>
    /// Clearing Amount.
    /// </summary>
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public ImpliedCurrencyAndAmount? ClearingAmount { get; init; }

    /// <summary>
    /// Clearing Credit Debit.
    /// </summary>
    [DisplayName("Clearing Credit Debit")]
    [IsoXmlTag("ClrCdtDbt")]
    public CreditDebit3Code? ClearingCreditDebit { get; init; }

    /// <summary>
    /// Clearing Currency.
    /// </summary>
    [DisplayName("Clearing Currency")]
    [IsoXmlTag("ClrCcy")]
    public ISO3NumericCurrencyCode? ClearingCurrency { get; init; }

    /// <summary>
    /// Clearing Date.
    /// </summary>
    [DisplayName("Clearing Date")]
    [IsoXmlTag("ClrDt")]
    public IsoISODate? ClearingDate { get; init; }

    /// <summary>
    /// Clearing Method.
    /// </summary>
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod2Code ClearingMethod { get; init; }

    /// <summary>
    /// Clearing Priority.
    /// </summary>
    [DisplayName("Clearing Priority")]
    [IsoXmlTag("ClrPrty")]
    public IsoMax35Text? ClearingPriority { get; init; }

    /// <summary>
    /// Destination Assigner.
    /// </summary>
    [DisplayName("Destination Assigner")]
    [IsoXmlTag("DstnAssgnr")]
    public IsoMax35Text? DestinationAssigner { get; init; }

    /// <summary>
    /// Destination Country.
    /// </summary>
    [DisplayName("Destination Country")]
    [IsoXmlTag("DstnCtry")]
    public ISO3NumericCountryCode? DestinationCountry { get; init; }

    /// <summary>
    /// Destination Identification.
    /// </summary>
    [DisplayName("Destination Identification")]
    [IsoXmlTag("DstnId")]
    public IsoMax35Text? DestinationIdentification { get; init; }

    /// <summary>
    /// Destination Short Name.
    /// </summary>
    [DisplayName("Destination Short Name")]
    [IsoXmlTag("DstnShrtNm")]
    public IsoMax35Text? DestinationShortName { get; init; }

    /// <summary>
    /// Interchange Fee Amount.
    /// </summary>
    [DisplayName("Interchange Fee Amount")]
    [IsoXmlTag("IntrchngFeeAmt")]
    public ImpliedCurrencyAndAmount? InterchangeFeeAmount { get; init; }

    /// <summary>
    /// Interchange Fee Credit Debit.
    /// </summary>
    [DisplayName("Interchange Fee Credit Debit")]
    [IsoXmlTag("IntrchngFeeCdtDbt")]
    public CreditDebit3Code? InterchangeFeeCreditDebit { get; init; }

    /// <summary>
    /// Interchange Fee Currency.
    /// </summary>
    [DisplayName("Interchange Fee Currency")]
    [IsoXmlTag("IntrchngFeeCcy")]
    public ISO3NumericCurrencyCode? InterchangeFeeCurrency { get; init; }

    /// <summary>
    /// Originator Assigner.
    /// </summary>
    [DisplayName("Originator Assigner")]
    [IsoXmlTag("OrgtrAssgnr")]
    public IsoMax35Text? OriginatorAssigner { get; init; }

    /// <summary>
    /// Originator Country.
    /// </summary>
    [DisplayName("Originator Country")]
    [IsoXmlTag("OrgtrCtry")]
    public ISO3NumericCountryCode? OriginatorCountry { get; init; }

    /// <summary>
    /// Originator Identification.
    /// </summary>
    [DisplayName("Originator Identification")]
    [IsoXmlTag("OrgtrId")]
    public IsoMax35Text? OriginatorIdentification { get; init; }

    /// <summary>
    /// Originator Short Name.
    /// </summary>
    [DisplayName("Originator Short Name")]
    [IsoXmlTag("OrgtrShrtNm")]
    public IsoMax35Text? OriginatorShortName { get; init; }

    /// <summary>
    /// Other Amount.
    /// </summary>
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public OtherAmount5? OtherAmount { get; init; }

    /// <summary>
    /// Other Clearing Method.
    /// </summary>
    [DisplayName("Other Clearing Method")]
    [IsoXmlTag("OthrClrMtd")]
    public IsoMax35Text? OtherClearingMethod { get; init; }

    /// <summary>
    /// Record Checksum Input Value.
    /// </summary>
    [DisplayName("Record Checksum Input Value")]
    [IsoXmlTag("RcrdChcksmInptVal")]
    public IsoMax140Binary? RecordChecksumInputValue { get; init; }

    /// <summary>
    /// Record Message.
    /// </summary>
    [DisplayName("Record Message")]
    [IsoXmlTag("RcrdMsg")]
    public required RecordMessage1Choice_ RecordMessage { get; init; }

    /// <summary>
    /// Sequence Counter.
    /// </summary>
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public required IsoNumber SequenceCounter { get; init; }
}
