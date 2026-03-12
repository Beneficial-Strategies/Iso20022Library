// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the confirmed fraudulent transaction.
/// </summary>
[IsoId("_ODlhYHbMEeef9c2nwgY9Xw")]
[DisplayName("Fraudulent Transaction Data")]
public partial record FraudulentTransactionData1
{
    #nullable enable
    
    /// <summary>
    /// Status of authorisation of the fraudulent transaction.
    /// </summary>
    [IsoId("_vj16EHbOEeef9c2nwgY9Xw")]
    [DisplayName("Authorisation Status")]
    [IsoXmlTag("AuthstnSts")]
    public AuthorisationStatus1? AuthorisationStatus { get; init; } 
    
    /// <summary>
    /// Details of the dispute if and when relevant.
    /// </summary>
    [IsoId("_SA70YHdTEeeKH6vrEwvLHA")]
    [DisplayName("Dispute Details")]
    [IsoXmlTag("DsptDtls")]
    public DisputeData2? DisputeDetails { get; init; } 
    
    /// <summary>
    /// Reason for sending the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_lWAsEsZjEeiCDcGzDHI_9Q")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MessageReason { get; init; } 
    
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    [IsoId("_ucH8AcZjEeiCDcGzDHI_9Q")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    
    /// <summary>
    /// Complete or partial details of the original message identified as fraudulent.
    /// </summary>
    [IsoId("_luPFcHdTEeeKH6vrEwvLHA")]
    [DisplayName("Fraudulent Message")]
    [IsoXmlTag("FrdlntMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? FraudulentMessage { get; init; } 
    
    
    #nullable disable
    
}
