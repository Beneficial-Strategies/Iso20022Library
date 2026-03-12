// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common details for all payment instruction.
/// </summary>
[IsoId("_mKHMIZlgEeeE1Ya-LgRsuQ")]
[DisplayName("Payment Common")]
public partial record PaymentCommon3
{
    #nullable enable
    
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_mSmZw5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment From")]
    [IsoXmlTag("PmtFr")]
    public System1? PaymentFrom { get; init; } 
    
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_mSsgYZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment To")]
    [IsoXmlTag("PmtTo")]
    public System1? PaymentTo { get; init; } 
    
    /// <summary>
    /// Status of a transfer.|.
    /// </summary>
    [IsoId("_mSsgY5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Common Status")]
    [IsoXmlTag("CmonSts")]
    public PaymentStatus3? CommonStatus { get; init; } 
    
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_mSsgZZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    
    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_mSsgZ5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Entry Date")]
    [IsoXmlTag("NtryDt")]
    public DateAndDateTime2Choice_? EntryDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment instruction is a debit or a credit.|.
    /// </summary>
    [IsoId("_mSsgaZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [IsoId("_mSsga5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    
    
    #nullable disable
    
}
