// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original payment initiation, to which the investigation message refers.
/// </summary>
[IsoId("_L5M9MbvHEfCYYbmqNrQFSg")]
[DisplayName("Underlying Payment Instruction11")]
public record UnderlyingPaymentInstruction11
{
    [IsoId("_MBQtBbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; }

    [IsoId("_MBQtB7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; }

    [IsoId("_MBQtCbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    [IsoId("_MBQtC7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    [IsoId("_MBQtDbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    [IsoId("_MBQtD7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original Instructed Amount")]
    [IsoXmlTag("OrgnlInstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; }

    [IsoId("_MBQtEbvHEfCYYbmqNrQFSg")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice? RequestedExecutionDate { get; init; }

    [IsoId("_MBQtE7vHEfCYYbmqNrQFSg")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    public IsoISODate? RequestedCollectionDate { get; init; }

    [IsoId("_MBQtFbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference48? OriginalTransactionReference { get; init; }

    [IsoId("_MBQtF7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original Service Level")]
    [IsoXmlTag("OrgnlSvcLvl")]
    public ServiceLevel8Choice? OriginalServiceLevel { get; init; }
}
