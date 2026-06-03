// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the original payment transaction, to which the investigation message refers.
/// </summary>
[IsoId("_MPNpcbvHEfCYYbmqNrQFSg")]
[DisplayName("Underlying Payment Transaction11")]
public record UnderlyingPaymentTransaction11
{
    [IsoId("_MV78g7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; }

    [IsoId("_MV78hbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    [IsoId("_MV78h7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    [IsoId("_MV78ibvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    [IsoId("_MV78i7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    [IsoId("_MV78jbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; }

    [IsoId("_MV78j7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    public IsoISODate? OriginalInterbankSettlementDate { get; init; }

    [IsoId("_MV78kbvHEfCYYbmqNrQFSg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference48? OriginalTransactionReference { get; init; }

    [IsoId("_MV78k7vHEfCYYbmqNrQFSg")]
    [DisplayName("Original Service Level")]
    [IsoXmlTag("OrgnlSvcLvl")]
    public ServiceLevel8Choice_? OriginalServiceLevel { get; init; }
}
