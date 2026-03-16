// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Instruction47.
/// </summary>
[IsoId("_13dNuzEyEe6g-ffJsqGiSA")]
[DisplayName("Payment Instruction47")]
public record PaymentInstruction47
{
    /// <summary>
    /// End To End Identification.
    /// </summary>
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Generated Order.
    /// </summary>
    [DisplayName("Generated Order")]
    [IsoXmlTag("GnrtdOrdr")]
    public IsoTrueFalseIndicator? GeneratedOrder { get; init; }

    /// <summary>
    /// Instructed Amount.
    /// </summary>
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public Amount3Choice_? InstructedAmount { get; init; }

    /// <summary>
    /// Instruction Copy.
    /// </summary>
    [DisplayName("Instruction Copy")]
    [IsoXmlTag("InstrCpy")]
    public IsoMax20000Text? InstructionCopy { get; init; }

    /// <summary>
    /// Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public Amount2Choice_? InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Parties.
    /// </summary>
    [DisplayName("Parties")]
    [IsoXmlTag("Pties")]
    public PaymentTransactionParty4? Parties { get; init; }

    /// <summary>
    /// Payment Method.
    /// </summary>
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentOrigin1Choice_? PaymentMethod { get; init; }

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public Priority1Choice_? Priority { get; init; }

    /// <summary>
    /// Processing Validity Time.
    /// </summary>
    [DisplayName("Processing Validity Time")]
    [IsoXmlTag("PrcgVldtyTm")]
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; }

    /// <summary>
    /// Purpose.
    /// </summary>
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public IsoMax10Text? Purpose { get; init; }

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<PaymentStatus6> Status { get; init; } = [];

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PaymentType4Choice_? Type { get; init; }
}
