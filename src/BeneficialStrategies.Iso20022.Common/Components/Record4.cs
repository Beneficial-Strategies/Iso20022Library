// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message in file message identified as a batch record.
/// </summary>
[IsoId("_dn4bkW7-EfC68Y4jZPNEug")]
[DisplayName("Record4")]
public record Record4
{
    /// <summary>
    /// Sequence counter of the record from 1 to n.
    /// </summary>
    [IsoId("_dqd1gW7-EfC68Y4jZPNEug")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public required IsoNumber SequenceCounter { get; init; }

    /// <summary>
    /// Value of the record to use for the computation of the checksum of the batch.
    /// </summary>
    [IsoId("_dqd1g27-EfC68Y4jZPNEug")]
    [DisplayName("Record Checksum Input Value")]
    [IsoXmlTag("RcrdChcksmInptVal")]
    public IsoMax140Binary? RecordChecksumInputValue { get; init; }

    /// <summary>
    /// Identification of the originator of the transaction.
    /// </summary>
    [IsoId("_dqd1hW7-EfC68Y4jZPNEug")]
    [DisplayName("Originator Identification")]
    [IsoXmlTag("OrgtrId")]
    public IsoMax35Text? OriginatorIdentification { get; init; }

    /// <summary>
    /// Identification of the entity assigning the originator identification.
    /// </summary>
    [IsoId("_dqd1h27-EfC68Y4jZPNEug")]
    [DisplayName("Originator Assigner")]
    [IsoXmlTag("OrgtrAssgnr")]
    public IsoMax35Text? OriginatorAssigner { get; init; }

    /// <summary>
    /// Country of the originator.
    /// </summary>
    [IsoId("_dqd1iW7-EfC68Y4jZPNEug")]
    [DisplayName("Originator Country")]
    [IsoXmlTag("OrgtrCtry")]
    public ISO3NumericCountryCode? OriginatorCountry { get; init; }

    /// <summary>
    /// Short name of the originator.
    /// </summary>
    [IsoId("_dqd1i27-EfC68Y4jZPNEug")]
    [DisplayName("Originator Short Name")]
    [IsoXmlTag("OrgtrShrtNm")]
    public IsoMax35Text? OriginatorShortName { get; init; }

    /// <summary>
    /// Identification of the destination of the transaction.
    /// </summary>
    [IsoId("_dqd1jW7-EfC68Y4jZPNEug")]
    [DisplayName("Destination Identification")]
    [IsoXmlTag("DstnId")]
    public IsoMax35Text? DestinationIdentification { get; init; }

    /// <summary>
    /// Identification of the entity assigning the destination identification.
    /// </summary>
    [IsoId("_dqd1j27-EfC68Y4jZPNEug")]
    [DisplayName("Destination Assigner")]
    [IsoXmlTag("DstnAssgnr")]
    public IsoMax35Text? DestinationAssigner { get; init; }

    /// <summary>
    /// Country of the destination.
    /// </summary>
    [IsoId("_dqd1kW7-EfC68Y4jZPNEug")]
    [DisplayName("Destination Country")]
    [IsoXmlTag("DstnCtry")]
    public ISO3NumericCountryCode? DestinationCountry { get; init; }

    /// <summary>
    /// Short name of the destination.
    /// </summary>
    [IsoId("_dqd1k27-EfC68Y4jZPNEug")]
    [DisplayName("Destination Short Name")]
    [IsoXmlTag("DstnShrtNm")]
    public IsoMax35Text? DestinationShortName { get; init; }

    /// <summary>
    /// Type of clearing of the transaction.
    /// </summary>
    [IsoId("_dqd1lW7-EfC68Y4jZPNEug")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod3Code ClearingMethod { get; init; }

    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("_dqd1mW7-EfC68Y4jZPNEug")]
    [DisplayName("Clearing Priority")]
    [IsoXmlTag("ClrPrty")]
    public IsoMax35Text? ClearingPriority { get; init; }

    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_dqd1m27-EfC68Y4jZPNEug")]
    [DisplayName("Clearing Date")]
    [IsoXmlTag("ClrDt")]
    public IsoISODate? ClearingDate { get; init; }

    /// <summary>
    /// Net clearing amount.
    /// </summary>
    [IsoId("_dqd1nW7-EfC68Y4jZPNEug")]
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public ImpliedCurrencyAndAmount? ClearingAmount { get; init; }

    /// <summary>
    /// Currency code of the net clearing amount.
    /// </summary>
    [IsoId("_dqd1n27-EfC68Y4jZPNEug")]
    [DisplayName("Clearing Currency")]
    [IsoXmlTag("ClrCcy")]
    public ISO3NumericCurrencyCode? ClearingCurrency { get; init; }

    /// <summary>
    /// Sign of net clearing amount.
    /// </summary>
    [IsoId("_dqd1oW7-EfC68Y4jZPNEug")]
    [DisplayName("Clearing Credit Debit")]
    [IsoXmlTag("ClrCdtDbt")]
    public CreditDebit3Code? ClearingCreditDebit { get; init; }

    /// <summary>
    /// Interchange fee amount.
    /// </summary>
    [IsoId("_dqd1o27-EfC68Y4jZPNEug")]
    [DisplayName("Interchange Fee Amount")]
    [IsoXmlTag("IntrchngFeeAmt")]
    public ImpliedCurrencyAndAmount? InterchangeFeeAmount { get; init; }

    /// <summary>
    /// Currency code of interchange fee amount.
    /// </summary>
    [IsoId("_dqd1pW7-EfC68Y4jZPNEug")]
    [DisplayName("Interchange Fee Currency")]
    [IsoXmlTag("IntrchngFeeCcy")]
    public ISO3NumericCurrencyCode? InterchangeFeeCurrency { get; init; }

    /// <summary>
    /// Sign of the interchange fee amount.
    /// </summary>
    [IsoId("_dqd1p27-EfC68Y4jZPNEug")]
    [DisplayName("Interchange Fee Credit Debit")]
    [IsoXmlTag("IntrchngFeeCdtDbt")]
    public CreditDebit3Code? InterchangeFeeCreditDebit { get; init; }

    /// <summary>
    /// Agent fee amount.
    /// </summary>
    [IsoId("_dqd1qW7-EfC68Y4jZPNEug")]
    [DisplayName("Agent Fee Amount")]
    [IsoXmlTag("AgtFeeAmt")]
    public ImpliedCurrencyAndAmount? AgentFeeAmount { get; init; }

    /// <summary>
    /// Currency code of agent fee amount.
    /// </summary>
    [IsoId("_dqd1q27-EfC68Y4jZPNEug")]
    [DisplayName("Agent Fee Currency")]
    [IsoXmlTag("AgtFeeCcy")]
    public ISO3NumericCurrencyCode? AgentFeeCurrency { get; init; }

    /// <summary>
    /// Sign of agent fee amount.
    /// </summary>
    [IsoId("_dqd1rW7-EfC68Y4jZPNEug")]
    [DisplayName("Agent Fee Credit Debit")]
    [IsoXmlTag("AgtFeeCdtDbt")]
    public CreditDebit3Code? AgentFeeCreditDebit { get; init; }

    /// <summary>
    /// Other amounts involved in clearing.
    /// </summary>
    [IsoId("_dqd1r27-EfC68Y4jZPNEug")]
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public OtherAmount5? OtherAmount { get; init; }

    /// <summary>
    /// Message to be sent in a batch transfer as a record.
    /// </summary>
    [IsoId("_dqd1sW7-EfC68Y4jZPNEug")]
    [DisplayName("Record Message")]
    [IsoXmlTag("RcrdMsg")]
    public required RecordMessage2Choice RecordMessage { get; init; }
}
