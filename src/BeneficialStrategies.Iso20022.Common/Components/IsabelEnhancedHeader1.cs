// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the enhanced parameters for an Isabel payment file.
/// </summary>
[IsoId("_wsbQIMmJEeWAGphE2LvqeA")]
[DisplayName("Isabel Enhanced Header")]
public partial record IsabelEnhancedHeader1
{
    #nullable enable
    
    /// <summary>
    /// Type of debit to be applied to the payment, as provided by the end-user.
    /// </summary>
    [IsoId("_FdV6UMmKEeWAGphE2LvqeA")]
    [DisplayName("Debit Type")]
    [IsoXmlTag("DbtTp")]
    public required DebitType1Code DebitType { get; init; } 
    
    /// <summary>
    /// Type of debit to be applied to the payment, as provided by the bank.
    /// This may supersede the debit type provided by the end-user.
    /// </summary>
    [IsoId("_aW14wcmKEeWAGphE2LvqeA")]
    [DisplayName("Bank Debit Type")]
    [IsoXmlTag("BkDbtTp")]
    public required DebitType1Code BankDebitType { get; init; } 
    
    /// <summary>
    /// Contract is defined on a specific account.
    /// </summary>
    [IsoId("_jZtncMmKEeWAGphE2LvqeA")]
    [DisplayName("Account Based Contract")]
    [IsoXmlTag("AcctBasedCtrct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator AccountBasedContract { get; init; } 
    
    /// <summary>
    /// Results of all validations performed during the processing of a file provided in the payload.
    /// </summary>
    [IsoId("_qAcD0MmKEeWAGphE2LvqeA")]
    [DisplayName("Validation Results")]
    [IsoXmlTag("VldtnRslts")]
    public required Validation1Code ValidationResults { get; init; } 
    
    /// <summary>
    /// Results of the signature validation provided by the &apos;PowerToSign&apos; user.
    /// </summary>
    [IsoId("_FDlhEMmLEeWAGphE2LvqeA")]
    [DisplayName("Power To Sign Validation Results")]
    [IsoXmlTag("PwrToSgnVldtnRslts")]
    public required Validation2Code PowerToSignValidationResults { get; init; } 
    
    /// <summary>
    /// Validation of the time stamp provided by the &apos;PowerToSign&apos; user.
    /// </summary>
    [IsoId("_LmXRkcmLEeWAGphE2LvqeA")]
    [DisplayName("Power To Sign Validation Time Stamp")]
    [IsoXmlTag("PwrToSgnVldtnTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime PowerToSignValidationTimeStamp { get; init; } 
    
    /// <summary>
    /// Trigger used by the sender to transfer the file.
    /// </summary>
    [IsoId("_W6QnsMmLEeWAGphE2LvqeA")]
    [DisplayName("Sender Trigger")]
    [IsoXmlTag("SndrTrggr")]
    public required IsabelSenderTrigger1Choice_ SenderTrigger { get; init; } 
    
    /// <summary>
    /// Time stamp on when the file is sent.
    /// </summary>
    [IsoId("_AzCccMmMEeWAGphE2LvqeA")]
    [DisplayName("Send Time Stamp")]
    [IsoXmlTag("SndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime SendTimeStamp { get; init; } 
    
    /// <summary>
    /// Indicates whether extra conditions are applicable and accepted for this file.
    /// </summary>
    [IsoId("_G6yd0MmMEeWAGphE2LvqeA")]
    [DisplayName("Extra Conditions Accepted")]
    [IsoXmlTag("XtraCondsAccptd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ExtraConditionsAccepted { get; init; } 
    
    /// <summary>
    /// Input source for the generation of the file.
    /// </summary>
    [IsoId("_M49scMmMEeWAGphE2LvqeA")]
    [DisplayName("Source")]
    [IsoXmlTag("Src")]
    public required IsabelInputSource1Choice_ Source { get; init; } 
    
    /// <summary>
    /// Number of signatures required to validate the payments file.
    /// </summary>
    [IsoId("_QCi3EMmNEeWAGphE2LvqeA")]
    [DisplayName("Number Of Required Signatures")]
    [IsoXmlTag("NbOfReqrdSgntrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfRequiredSignatures { get; init; } 
    
    /// <summary>
    /// Extended parameters for an Isabel payment initiation file.
    /// </summary>
    [IsoId("_VcsLkMmNEeWAGphE2LvqeA")]
    [DisplayName("Extended")]
    [IsoXmlTag("Xtnded")]
    public IsabelExtendedHeader1? Extended { get; init; } 
    
    
    #nullable disable
    
}
